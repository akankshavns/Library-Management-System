using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library.TransactionManagement
{
    public partial class ShowBookDetail : UserControl
    {
        public int? availableBookId { get; set; }

        public int returnDays;
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public ShowBookDetail()
        {
            InitializeComponent();
        }
        //get the student enrollment no. for issuing the book
        private void EnrollBox_KeyDown(object sender, KeyEventArgs e)
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
       
        public void ShowDetailInTextBox()
        {
            InfoPanel.Visible = true;
            BookInfo.Visible = true;
            string Bookquery = "SELECT ISBNNumber,BookName,AuthorName FROM AddBooks WHERE ISBNNumber= @BookId";
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

                        if (reader.Read())
                        {
                            BookId.Text = reader["ISBNNumber"].ToString();
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
        int NoOfIssueBookPerStud;
       public void getNoOfIssueBookPerStudent()
        {
            string getQuerry = "select numberofissuedbook from TransactionSetting ";
            try
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd =  new SqlCommand(getQuerry, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            NoOfIssueBookPerStud = reader.GetInt32(0);
                        }
                    }
                }

        
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        //issue a book and save the data in the database .
        private void IssueButton_Click_1(object sender, EventArgs e)
        {
            string checkIssueQuery1 = "SELECT COUNT(*) FROM IssueBookDetail WHERE EnrollmentNumber = @EnrollBox";
            string checkIssueQuery2 = "SELECT COUNT(*) FROM IssueBookDetail WHERE EnrollmentNumber = @EnrollBox AND ISBNNumber = @BookId";

            string issueQuerry = "INSERT INTO IssueBookDetail(ISBNNumber, EnrollmentNumber,IssueDate, DueDate, ReturnDate, FineAmount, isReturnBook) VALUES (@BookId, @Enroll, @issueDate, @DueDate, @ReturnDate, @fine,@isReturn)";
            string updateAvailableBook = "UPDATE AddBooks SET AvailableBook = @Available WHERE ISBNNumber = @sno";
            try
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand checkCmd1 = new SqlCommand(checkIssueQuery1, con);
                        checkCmd1.Parameters.AddWithValue("@EnrollBox", EnrollBox.Text);

                        int count1 = (int)checkCmd1.ExecuteScalar();
                        if (NoOfIssueBookPerStud == count1)
                        {
                            MessageBox.Show($"This student has already issued {count1} books.");
                            return;
                        }
                        else
                        {
                            con.Close();
                            con.Open();
                            SqlCommand checkCmd2 = new SqlCommand(checkIssueQuery2, con);
                            checkCmd2.Parameters.AddWithValue("@EnrollBox", EnrollBox.Text);
                            checkCmd2.Parameters.AddWithValue("@BookId", BookId.Text);

                            int count2 = (int)checkCmd2.ExecuteScalar();

                            if (count2 > 0)
                            {
                                MessageBox.Show("This student has already issued this books.");
                            }
                            else
                            {
                                SqlCommand cmd = new SqlCommand(issueQuerry, con);
                                cmd.Parameters.AddWithValue("@BookId", BookId.Text);
                                cmd.Parameters.AddWithValue("@Enroll", EnrollBox.Text);
                                cmd.Parameters.AddWithValue("@DueDate", DueDate.Value);
                                cmd.Parameters.AddWithValue("@issueDate", issueDate.Text);
                                cmd.Parameters.AddWithValue("@ReturnDate", DBNull.Value);
                                cmd.Parameters.AddWithValue("@isReturn", "Hold");
                                cmd.Parameters.AddWithValue("@fine", "0");
                                int isInsert = cmd.ExecuteNonQuery();
                                if (isInsert >= 1)
                                {
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
                            }
                        } 
                        
                        
                        //else
                        //{
                        //    MessageBox.Show("Something went wrong with book issuance.");
                        //}
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

        private void ShowBookDetail_Load(object sender, EventArgs e)
        {
            issueDate.MaxDate = DateTime.Now.AddSeconds(1);
            issueDate.Value = DateTime.Now;
            getNoOfIssueBookPerStudent();
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
                            DueDate.Value = issueDate.Value.AddDays(returnDays);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void issueDate_ValueChanged(object sender, EventArgs e)
        {
            DueDate.Value = issueDate.Value.AddDays(returnDays);
        }
    }
}
