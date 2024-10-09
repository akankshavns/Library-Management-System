using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library.TransactionManagement
{
    public partial class ReturnBook : UserControl
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public ReturnBook()
        {
            InitializeComponent();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }
        private void Search_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT BookName, AuthorName, StudentName,Deparment,Email,issueDate FROM IssueBookList WHERE StudentEnrollment = @EnrollBox and BookId =  @BookID";
                    try
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand(query, con);
                        command.Parameters.AddWithValue("@EnrollBox", EnrollBox.Text);
                        command.Parameters.AddWithValue("@BookID", BookID.Text);
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
                            MessageBox.Show("No data found.");
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
                    string finequerry = "select ReturnDate from IssueBookList where BookId= @BookID ";
                    string updateAvalable = "update AddBooks set AvailableBook = AvailableBook + 1 Where Accession_No = @BookID";
                    string changeReturn = "update IssueBookList set isReturnBook='yes'";
                    try
                    {
                        con.Open();
                        SqlCommand finecmd = new SqlCommand(finequerry, con);
                        finecmd.Parameters.AddWithValue("@BookID", BookID.Text);
                        SqlDataReader reader = finecmd.ExecuteReader();
                        DateTime returnDate = DateTime.MinValue;
                        if (reader.Read())
                        {
                            returnDate = reader.GetDateTime(0);
                        }
                        reader.Close();
                        if (actualReturnDate > returnDate)
                        {
                            TimeSpan difference = actualReturnDate - returnDate;
                            int daysLate = difference.Days;
                            double fine = daysLate * 5;  // $5 fine per day
                            MessageBox.Show($"Book is returned late. You have to pay a fine of ${fine}.");
                            //How to collect fine.
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand(updateAvalable, con);
                            cmd.Parameters.AddWithValue("@BookID", BookID.Text);
                            SqlCommand comm = new SqlCommand(changeReturn, con);
                            int i = cmd.ExecuteNonQuery();
                            if (i == 0)
                            {
                                MessageBox.Show("Book not Return succesfully");
                            }
                            else
                            {
                                MessageBox.Show("Book Return succesfully");
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
            ActualReturnDate.MaxDate = DateTime.Today.AddDays(7);
        }
    }
    
}
