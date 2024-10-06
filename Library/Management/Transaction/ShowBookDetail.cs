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
    public partial class ShowBookDetail : UserControl
    {
         public string availableBookId {  get; set; }
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
                InfoPanel.Visible = true;
                ReturnDate.Value = issueDate.Value.AddDays(7);
                string Bookquery = "SELECT Accession_No,BookName,AuthorName FROM AddBooks WHERE Accession_No = '" + availableBookId + "'";
                string studentquery = "SELECT StudentName,Department,Contact,Email,Address FROM StudentInformation WHERE EnrollmentNumber = '" + EnrollBox.Text + "'";
                try
                {
                    string connectionString = GetConnectionString();
                    if (connectionString != null)
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand(Bookquery, con);
                            SqlCommand command = new SqlCommand(studentquery, con);
                            SqlDataReader reader= cmd.ExecuteReader();
                            
                            if (reader.Read()) // If there is data
                            {
                                BookId.Text = reader["Accession_No"].ToString();
                                BookName.Text = reader["BookName"].ToString();
                                AuthorName.Text = reader["AuthorName"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No data found.");
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
                                MessageBox.Show("No data found.");
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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string issueQuerry = "Insert into IssueBookList values('" + BookId.Text + "','" + BookName.Text + "','" + AuthorName.Text + "','" + EnrollBox.Text + "','" + StudentName.Text + "','" + Dep.Text + "','" + Semester.Text + "','" + Cont.Text + "','" + mail.Text + "','" + Addre.Text + "','" + issueDate.Text + "','" + ReturnDate.Text + "','No')";
            //string updateAvailable = "update Book set AvailableBook = AvailableBook - 1 Where id = '" + SNO + "'";
            try
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(issueQuerry, con);
                        //SqlCommand comm = new SqlCommand(updateAvailable, con);
                        cmd.ExecuteNonQuery(); con.Close();
                        MessageBox.Show("Book Issue successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

                BookId.Text = "";
                BookName.Text = "";
                AuthorName.Text = "";
                EnrollBox.Text = "";
                StudentName.Text = "";
                Semester.Text = "";
                mail.Text = "";
                Addre.Text = "";
                issueDate.Text = "";
                ReturnDate.Text = "";
                Dep.Text = "";
                Cont.Text = "";
        }

       

        
       
    }
}
