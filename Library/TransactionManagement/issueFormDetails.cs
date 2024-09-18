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
    public partial class issueFormDetails : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;");
        public issueFormDetails()
        {
            InitializeComponent();
        }

        private void EnrollBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InfoPanel.Visible = true;
                string query = "SELECT StudentName,Department,Contact,Email,Address FROM Student WHERE EnrollmentNumber = '" + EnrollBox.Text + "'";
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        StudentName.Text = reader["StudentName"].ToString();
                        Cont.Text = reader["Contact"].ToString();
                        Dep.Text = reader["Department"].ToString();
                        mail.Text = reader["Email"].ToString();
                        Addre.Text = reader["Address"].ToString();
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
                con.Close();

            }
        }

        private void issueDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime newdate=issueDate.Value.AddDays(7);
            ReturnDate.Value = newdate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into IssueBookList values('" + BookId.Text + "','" + BookName.Text + "','" + AuthorName.Text + "','" + EnrollBox.Text + "','" + StudentName.Text + "','" + Dep.Text + "','" + Semester.Text + "','" + Cont.Text + "','" + mail.Text + "','" + Addre.Text + "','" + issueDate.Text + "','" + ReturnDate.Text + "','No')";
                cmd.ExecuteNonQuery();


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
                cmd.CommandText = "update Book set AvailableBook = AvailableBook - 1 Where id = '" + SNO + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Book Issue successfully");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
