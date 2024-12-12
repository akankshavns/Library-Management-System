using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Library.Management.Student;
using Library.Management.Transaction;


namespace Library.TransactionManagement
{
    public partial class ReturnBook : UserControl
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public int fineCharge;
        public ReturnBook()
        {
            InitializeComponent();
        }
        private void Search_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string checkQuery = "SELECT COUNT(*) FROM IssueBookDetail WHERE EnrollmentNumber = @EnrollBox and ISBNNumber = @BookID and isReturnBook=@status";
                    string query = "SELECT b.BookName, b.AuthorName, s.StudentName, s.Department, s.Email, i.issueDate FROM IssueBookDetail i JOIN AddBooks b ON i.ISBNNumber = b.ISBNNumber JOIN StudentInformation s ON i.EnrollmentNumber = s.EnrollmentNumber WHERE i.EnrollmentNumber = @EnrollBox and i.ISBNNumber = @BookID and IsReturnBook = @ReturnStatus";
                    try
                    {
                        con.Open();

                        // Check if any record exists for given StudentEnrollment and BookID
                        SqlCommand checkCommand = new SqlCommand(checkQuery, con);
                        checkCommand.Parameters.AddWithValue("@status", "Hold");
                        checkCommand.Parameters.AddWithValue("@EnrollBox", EnrollBox.Text);
                        checkCommand.Parameters.AddWithValue("@BookID", BookID.Text);
                        int recordCount = (int)checkCommand.ExecuteScalar();

                        if (recordCount == 0)
                        {
                            MessageBox.Show("This book is already retuned");
                            return;
                        }

                        SqlCommand command = new SqlCommand(query, con);
                        command.Parameters.AddWithValue("@EnrollBox", EnrollBox.Text);
                        command.Parameters.AddWithValue("@BookID", BookID.Text);
                        command.Parameters.AddWithValue("@ReturnStatus", "Hold");
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            BookName.Text = reader["BookName"].ToString();
                            AuthorName.Text = reader["AuthorName"].ToString();
                            StudentName.Text = reader["StudentName"].ToString();
                            Dep.Text = reader["Department"].ToString();
                            mail.Text = reader["Email"].ToString();
                            issueDate.Text = reader["issueDate"].ToString();
                            InfoPanel.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("This Book is already return by the student.No data data found in hold  book");
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }


        private void Return_Click(object sender, EventArgs e)
        {
            DateTime actualReturnDate = ActualReturnDate.Value;
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string fineQuery = "SELECT DueDate FROM IssueBookDetail WHERE ISBNNUmber = @BookID AND EnrollmentNumber = @enroll";
                    string updateBookAvailable = "UPDATE AddBooks SET AvailableBook = AvailableBook + 1 WHERE ISBNNumber = @BookID";
                    string UpdateIssuedStatus = "UPDATE IssueBookDetail SET isReturnBook = @status,FineAmount=@fine,ReturnDate=@Todaydate WHERE ISBNNumber = @BookId AND EnrollmentNumber = @enroll";
                    try
                    {
                        con.Open();
                        // Check for Return Date and Calculate Fine if Late
                        SqlCommand fineCmd = new SqlCommand(fineQuery, con);
                        fineCmd.Parameters.AddWithValue("@BookID", BookID.Text);
                        fineCmd.Parameters.AddWithValue("@enroll", EnrollBox.Text);
                        SqlDataReader reader = fineCmd.ExecuteReader();
                        DateTime returnDate = DateTime.MinValue;
                        if (reader.Read())
                        {
                            returnDate = reader.GetDateTime(0);
                        }
                        reader.Close();
                        // calculate the fine
                        if (actualReturnDate > returnDate)
                        {
                            Return.Enabled= false;
                            TimeSpan difference = actualReturnDate - returnDate;
                            int daysLate = difference.Days;
                            double fine = daysLate * fineCharge;
                            MessageBox.Show($"Book is returned late. You have to pay a fine of ₹{fine}.");
                            Fine.Enabled = true;
                            Form dialogForm = new Form
                            {
                                Text = "Scan me!",
                                Size = new Size(643, 443), // Adjust the size to fit your UserControl
                                StartPosition = FormStartPosition.CenterParent, // Center the dialog on the parent form
                                FormBorderStyle = FormBorderStyle.FixedDialog, // Prevent resizing
                                MaximizeBox = false,
                                MinimizeBox = false
                            };
                            Scanner1 scan = new Scanner1();
                            scan.Dock = DockStyle.Fill;
                            dialogForm.Controls.Add(scan);
                            dialogForm.ShowDialog();
                            if (Return.Enabled == true)
                            {
                                SqlCommand cmd = new SqlCommand(updateBookAvailable, con);
                                cmd.Parameters.AddWithValue("@BookID", BookID.Text);
                                SqlCommand comm = new SqlCommand(UpdateIssuedStatus, con);
                                comm.Parameters.AddWithValue("@enroll", EnrollBox.Text);
                                comm.Parameters.AddWithValue("@BookId", BookID.Text);
                                comm.Parameters.AddWithValue("@status", "Return");
                                comm.Parameters.AddWithValue("@Todaydate ", ActualReturnDate.Value);
                                comm.Parameters.AddWithValue("@fine", fine);
                                int availableUpdateResult = cmd.ExecuteNonQuery();
                                int returnUpdateResult = comm.ExecuteNonQuery();
                                if (availableUpdateResult > 0 && returnUpdateResult > 0)
                                {
                                    Fine.Enabled= true;
                                    MessageBox.Show("Book returned successfully and inventory updated.");
                                }
                                else
                                {
                                    MessageBox.Show("Book return process failed.");
                                }
                                BookName.Clear();
                                AuthorName.Clear();
                                EnrollBox.Clear();
                                StudentName.Clear();
                                mail.Clear();
                                issueDate.Clear();
                                Dep.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Please deposite your fine!");
                            }
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand(updateBookAvailable, con);
                            cmd.Parameters.AddWithValue("@BookID", BookID.Text);
                            SqlCommand comm = new SqlCommand(UpdateIssuedStatus, con);
                            comm.Parameters.AddWithValue("@enroll", EnrollBox.Text);
                            comm.Parameters.AddWithValue("@BookId", BookID.Text);
                            comm.Parameters.AddWithValue("@status", "Return");
                            comm.Parameters.AddWithValue("@Todaydate ", ActualReturnDate.Value);
                            comm.Parameters.AddWithValue("@fine", 0);
                            int availableUpdateResult = cmd.ExecuteNonQuery();
                            int returnUpdateResult = comm.ExecuteNonQuery();
                            if (availableUpdateResult > 0 && returnUpdateResult > 0)
                            {
                                MessageBox.Show("Book returned successfully and inventory updated.");
                            }
                            else
                            {
                                MessageBox.Show("Book return process failed.");
                            }
                            BookName.Clear();
                            AuthorName.Clear();
                            EnrollBox.Clear();
                            StudentName.Clear();
                            mail.Clear();
                            issueDate.Clear();
                            Dep.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }



        private void ReturnBook_Load(object sender, EventArgs e)
        {
            int Fine, returnDays;
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    string setValue = "Select * from TransactionSetting";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(setValue, con);
                        SqlDataReader rdr = cmd.ExecuteReader();
                        if (rdr.Read())
                        {
                            Fine = Convert.ToInt32(rdr.GetValue(1));
                            //issuedBook = Convert.ToInt32(rdr.GetValue(2));
                            returnDays = Convert.ToInt32(rdr.GetValue(3));
                            ActualReturnDate.MaxDate = DateTime.Today.AddDays(returnDays);
                            fineCharge = Fine;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }


            }

        }

        private void Fine_Click(object sender, EventArgs e)
        {
            Form dialogForm = new Form
            {
                Text = "Scan me!",
                Size = new Size(688, 488), // Adjust the size to fit your UserControl
                StartPosition = FormStartPosition.CenterParent, // Center the dialog on the parent form
                FormBorderStyle = FormBorderStyle.FixedDialog, // Prevent resizing
                MaximizeBox = false,
                MinimizeBox = false
            };
            Scanner1 scan = new Scanner1();
            scan.Dock = DockStyle.Fill;
            dialogForm.Controls.Add(scan);
            dialogForm.ShowDialog();

        }
    }

}
