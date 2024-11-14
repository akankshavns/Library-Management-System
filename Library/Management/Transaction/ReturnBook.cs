using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;


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
                    string checkQuery = "SELECT COUNT(*) FROM IssueBookList WHERE StudentEnrollment = @EnrollBox and BookId = @BookID and isReturnBook=@status";
                    string query = "SELECT BookName, AuthorName, StudentName, Deparment, Email, issueDate FROM IssueBookList WHERE StudentEnrollment = @EnrollBox and BookId = @BookID and IsReturnBook = @ReturnStatus";
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
                            MessageBox.Show("No records found for the given enrollment and book ID.");
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
                            Dep.Text = reader["Deparment"].ToString();
                            mail.Text = reader["Email"].ToString();
                            issueDate.Text = reader["issueDate"].ToString();
                            InfoPanel.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("This Book is already return by the student.");
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
                    string fineQuery = "SELECT ReturnDate FROM IssueBookList WHERE BookId = @BookID AND StudentEnrollment = @enroll";
                    string updateAvailable = "UPDATE AddBooks SET AvailableBook = AvailableBook + 1 WHERE Accession_No = @BookID";
                    string changeReturn = "UPDATE IssueBookList SET isReturnBook = @Return WHERE BookId = @BookId AND StudentEnrollment = @enroll";
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
                            MessageBox.Show(fineCharge.ToString());
                            double fine = daysLate * fineCharge;
                            MessageBox.Show($"Book is returned late. You have to pay a fine of ₹{fine}.");
                            scanner scan = new scanner();
                            scan.Show();
                            if (Return.Enabled == true)
                            {
                                SqlCommand cmd = new SqlCommand(updateAvailable, con);
                                cmd.Parameters.AddWithValue("@BookID", BookID.Text);
                                SqlCommand comm = new SqlCommand(changeReturn, con);
                                comm.Parameters.AddWithValue("@enroll", EnrollBox.Text);
                                comm.Parameters.AddWithValue("@BookId", BookID.Text);
                                comm.Parameters.AddWithValue("@Return", "Return");
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
                            else
                            {
                                MessageBox.Show("Please deposite your fine!");
                            }
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand(updateAvailable, con);
                            cmd.Parameters.AddWithValue("@BookID", BookID.Text);
                            SqlCommand comm = new SqlCommand(changeReturn, con);
                            comm.Parameters.AddWithValue("@enroll", EnrollBox.Text);
                            comm.Parameters.AddWithValue("@BookId", BookID.Text);
                            comm.Parameters.AddWithValue("@Return", "Return");
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
    }

}
