using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;Pooling=False;");
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string query = "SELECT BookName, AuthorName, StudentName,Deparment,Email,issueDate FROM IssueBookList WHERE StudentEnrollment = '" + EnrollBox.Text + "' and BookId = '" + BookID.Text + "'";
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
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
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            string updateAvalable = "update AddBooks set AvailableBook = AvailableBook + 1 Where Accession_No = '" + BookID.Text + "'";
            string changeReturn = "update IssueBookList set isReturnBook='yes'";
            try
            {
                con.Open();
                SqlCommand cmd =new SqlCommand(updateAvalable, con);
                SqlCommand comm = new SqlCommand(changeReturn, con);
                int  i = cmd.ExecuteNonQuery();
                if (i == 0)
                {
                    MessageBox.Show("Book not Return succesfully");
                }
                else {
                    MessageBox.Show("Book Return succesfully");
                }
                BookName.Text = "";
                AuthorName.Text = "";
                EnrollBox.Text = "";
                StudentName.Text = "";
                mail.Text = "";
                issueDate.Text = "";
                ReturnDate.Text = "";
                Dep.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
