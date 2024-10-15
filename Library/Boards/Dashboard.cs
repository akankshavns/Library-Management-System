using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;

namespace Library.FrontScreen
{
    public partial class Dashboard : UserControl
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            countOfAllrecods();

           

        }

        public void countOfAllrecods()
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string TBook = "SELECT count(*)from AddBooks";
                    string TStudent = "SELECT count(*)from StudentInformation";
                    string IssueBook = "Select count (*) from IssueBookList where issueDate = CAST(GETDATE() AS DATE)";
                    string ReturnBook = "Select count (*) from IssueBookList where ReturnDate = CAST(GETDATE() AS DATE)";
                    try
                    {
                        con.Open();
                        SqlCommand TotalBook = new SqlCommand(TBook, con);
                        int totalBook = (int)TotalBook.ExecuteScalar();
                        TotalBookLabel.Text = totalBook.ToString();
                        SqlCommand TotalStudent = new SqlCommand(TStudent, con);
                        int totalStudent = (int)TotalStudent.ExecuteScalar();
                        TotalStudentLabel.Text = totalStudent.ToString();
                        SqlCommand todayIssue = new SqlCommand(IssueBook, con);
                        int issueBook = (int)todayIssue.ExecuteScalar();
                        TodayIssueBook.Text = issueBook.ToString();
                        SqlCommand todayReturn = new SqlCommand(ReturnBook, con);
                        int returnBook = (int)todayReturn.ExecuteScalar();
                        TodayReturnBooklabel.Text = issueBook.ToString();


                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }

        private void TotalBook_Click(object sender, EventArgs e)
        {

        }

       
    }
}
