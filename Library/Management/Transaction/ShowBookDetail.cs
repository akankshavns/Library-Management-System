using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library.TransactionManagement
{
    public partial class ShowBookDetail : UserControl
    {
        public string availableBookId { get; set; }
        public int returnDays;
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public ShowBookDetail()
        {
            InitializeComponent();
        }

        private void EnrollBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IssueButton.Visible=true;
                newupdatedreturndays();
                ReturnDate.Value = issueDate.Value.AddDays(returnDays);
                if (string.IsNullOrEmpty(EnrollBox.Text))
                {
                    CheckEnrollBox.SetError(EnrollBox, "This Field is required.");

                }
                else if (string.IsNullOrEmpty(Semester.Text))
                {
                    checkSemesterBox.SetError(Semester, "This field is required");
                }
                else
                {
                    ShowDetailInTextBox();
                }
            }
        }
        public void ShowDetailInTextBox()
        {
            InfoPanel.Visible = true;
            BookInfo.Visible = true;
            string Bookquery = "SELECT Accession_No,BookName,AuthorName FROM AddBooks WHERE Accession_No = @BookId";
            string studentquery = "SELECT StudentName,Department,Contact,Email,Address FROM StudentInformation WHERE EnrollmentNumber = @Enrollment";
            try
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(Bookquery, con);
                        cmd.Parameters.AddWithValue("@BookId", availableBookId);
                        SqlCommand command = new SqlCommand(studentquery, con);
                        command.Parameters.AddWithValue("@Enrollment", EnrollBox.Text);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read()) // If there is data
                        {
                            BookId.Text = reader["Accession_No"].ToString();
                            BookName.Text = reader["BookName"].ToString();
                            AuthorName.Text = reader["AuthorName"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Book records not found.");
                        }

                        reader.Close();
                        SqlDataReader reader1 = command.ExecuteReader();
                        if (reader1.Read())
                        {
                            StudentName.Text = reader1["StudentName"].ToString();
                            Cont.Text = reader1["Contact"].ToString();
                            Dep.Text = reader1["Department"].ToString();
                            mail.Text = reader1["Email"].ToString();
                            Addre.Text = reader1["Address"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Student record not found.");
                        }

                        reader1.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void IssueButton_Click_1(object sender, EventArgs e)
        {
            string checkIssueQuery = "SELECT COUNT(*) FROM IssueBookList WHERE studentEnrollment = @EnrollBox AND BookId = @BookId";
            string issueQuerry = "INSERT INTO IssueBookList (BookId, BookName, AuthorName, StudentEnrollment, StudentName, Deparment, Semester, Contact, Email, Address, issueDate, ReturnDate,fine, isReturnBook) VALUES (@BookId, @BookName, @AuthorName, @EnrollBox, @StudentName, @Dep, @Semester, @Cont, @mail, @Addre, @issueDate, @ReturnDate, @fine,@isReturn)";
            string updateAvailableBook = "UPDATE AddBooks SET AvailableBook = @Available WHERE sno = @sno";
            try
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand checkCmd = new SqlCommand(checkIssueQuery, con);
                        checkCmd.Parameters.AddWithValue("@EnrollBox", EnrollBox.Text);
                        checkCmd.Parameters.AddWithValue("@BookId", BookId.Text);

                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("This book has already been issued to this student.");
                            return; 
                        }
                        SqlCommand cmd = new SqlCommand(issueQuerry, con);
                        cmd.Parameters.AddWithValue("@BookId", BookId.Text);
                        cmd.Parameters.AddWithValue("@BookName", BookName.Text);
                        cmd.Parameters.AddWithValue("@AuthorName", AuthorName.Text);
                        cmd.Parameters.AddWithValue("@EnrollBox", EnrollBox.Text);
                        cmd.Parameters.AddWithValue("@StudentName", StudentName.Text);
                        cmd.Parameters.AddWithValue("@Dep", Dep.Text);
                        cmd.Parameters.AddWithValue("@Semester", Semester.Text);
                        cmd.Parameters.AddWithValue("@Cont", Cont.Text);
                        cmd.Parameters.AddWithValue("@ReturnDate", ReturnDate.Text);
                        cmd.Parameters.AddWithValue("@issueDate", issueDate.Text);
                        cmd.Parameters.AddWithValue("@mail", mail.Text);
                        cmd.Parameters.AddWithValue("@Addre", Addre.Text);
                        cmd.Parameters.AddWithValue("@isReturn", "Hold");
                        cmd.Parameters.AddWithValue("@fine", "0");

                        int isInsert = cmd.ExecuteNonQuery();
                        if (isInsert >= 1)
                        {
                            // Update AvailableBook count
                            int updatedAvailableBook = SearchBooks.num - 1;

                            SqlCommand updateCmd = new SqlCommand(updateAvailableBook, con);
                            updateCmd.Parameters.AddWithValue("@Available", updatedAvailableBook);
                            updateCmd.Parameters.AddWithValue("@sno", SearchBooks.sno); // Assuming sno is the same as BookId; adjust if necessary

                            int isUpdate = updateCmd.ExecuteNonQuery();
                            if (isUpdate >= 1)
                            {
                                MessageBox.Show("Book issued successfully and AvailableBook count updated.");
                            }
                            else
                            {
                                MessageBox.Show("Book issued, but failed to update AvailableBook count.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong with book issuance.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            

            IssueButton.Visible= false;
            BookId.Clear();
            BookName.Clear();
            AuthorName.Clear();
            EnrollBox.Clear();
            StudentName.Clear();
            Semester.Text = "";
            mail.Clear();
            Addre.Clear();
            Dep.Clear();
            Cont.Clear();
        }
        private void Semester_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IssueButton.Visible = true;
                newupdatedreturndays();
                if (string.IsNullOrEmpty(EnrollBox.Text))
                {
                    CheckEnrollBox.SetError(EnrollBox, "This Field is required.");

                }
                else if (string.IsNullOrEmpty(Semester.Text))
                {
                    checkSemesterBox.SetError(Semester, "This field is required");
                }
                else
                {
                    ShowDetailInTextBox();
                }
            }
        }
        private void EnrollBox_TextChanged(object sender, EventArgs e)
        {
            CheckEnrollBox.SetError(EnrollBox, "");
        }

        private void Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkSemesterBox.SetError(Semester, "");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }

        private void ShowBookDetail_Load(object sender, EventArgs e)
        {
            issueDate.MaxDate = DateTime.Now.AddSeconds(1);
            issueDate.Value = DateTime.Now;
            newupdatedreturndays();
        }
        public void newupdatedreturndays()
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    string setValue = "Select Returndays from TransactionSetting";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(setValue, con);
                        SqlDataReader rdr = cmd.ExecuteReader();
                        if (rdr.Read())
                        {
                            returnDays = Convert.ToInt32(rdr.GetValue(0));
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
