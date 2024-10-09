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
using System.Xml.Linq;

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
                ReturnDate.Value = issueDate.Value.AddDays(7);
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
            string issueQuerry = "Insert into IssueBookList values(@BookId, @BookName,  @AuthorName, @EnrollBox, @StudentName, @Dep, @Semester, @Cont,@mail, @Addre, @issueDate, @ReturnDate,'No')";
           
            try
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(issueQuerry, con);
                        cmd.Parameters.AddWithValue("@BookId", BookId.Text);
                        cmd.Parameters.AddWithValue("BookName", BookName.Text);
                        cmd.Parameters.AddWithValue("@AuthorName", AuthorName.Text);
                        cmd.Parameters.AddWithValue("@EnrollBox", EnrollBox.Text);
                        cmd.Parameters.AddWithValue("@StudentName",StudentName.Text);
                        cmd.Parameters.AddWithValue("@Dep", Dep.Text);
                        cmd.Parameters.AddWithValue("@Semester", Semester.Text);
                        cmd.Parameters.AddWithValue("@Cont", Cont.Text);
                        cmd.Parameters.AddWithValue("@ReturnDate", ReturnDate.Text);
                        cmd.Parameters.AddWithValue("@issueDate", issueDate.Text);
                        cmd.Parameters.AddWithValue("@mail",mail.Text);
                        cmd.Parameters.AddWithValue("@Addre", Addre.Text);
                        int isInsert = cmd.ExecuteNonQuery();
                        if (isInsert >= 1)
                        {
                            MessageBox.Show("Book Issue successfully");
                        }
                        else { MessageBox.Show("Something went wrong."); }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
    }
}
