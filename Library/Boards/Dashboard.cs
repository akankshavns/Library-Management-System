using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                    string TBook = "SELECT count(*)from AddBooks where BookStatus='Retained'";
                    string TStudent = "SELECT count(*)from StudentInformation where StudentStatus='Retained'";
                    string IssueBook = "Select count (*) from IssueBookDetail where issueDate = CAST(GETDATE() AS DATE) and isReturnBook=@status";
                    string ReturnBook = "Select count (*) from IssueBookDetail where ReturnDate = CAST(GETDATE() AS DATE) and isReturnBook=@status";
                    try
                    {
                        con.Open();
                        SqlCommand TotalBook = new SqlCommand(TBook, con);
                        int totalBook = (int)TotalBook.ExecuteScalar();
                        BookLabel.Text = totalBook.ToString();
                        SqlCommand TotalStudent = new SqlCommand(TStudent, con);
                        int totalStudent = (int)TotalStudent.ExecuteScalar();
                        Studentlabel.Text = totalStudent.ToString();
                        SqlCommand todayIssue = new SqlCommand(IssueBook, con);
                        todayIssue.Parameters.AddWithValue("@status", "Hold");
                        int issueBook = (int)todayIssue.ExecuteScalar();
                        issuedlabel.Text = issueBook.ToString();
                        SqlCommand todayReturn = new SqlCommand(ReturnBook, con);
                        todayReturn.Parameters.AddWithValue("@status", "Return");
                        int returnBook = (int)todayReturn.ExecuteScalar();
                        ReturnBooklabel.Text = returnBook.ToString();


                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }


    }
}
