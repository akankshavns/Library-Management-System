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

namespace Library.FrontScreen
{
    public partial class Dashboard : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;");
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
            
            try
            {
                using (con)
                {
                    string TBook = "SELECT count(*)from AddBooks";
                    string TStudent = "SELECT count(*)from StudentInformation";
                    string IssueBook = "Select count (*) from IssueBookList where issueDate = CAST(GETDATE() AS DATE)";
                    SqlCommand cmd = new SqlCommand(TBook, con);
                    SqlCommand cmm = new SqlCommand(TStudent, con);
                    SqlCommand sqlCommand = new SqlCommand(IssueBook, con);
                    con.Open();
                    int totalBook = (int)cmd.ExecuteScalar();
                    TotalBook.Text = totalBook.ToString();
                    int totalStudent = (int)cmm.ExecuteScalar();
                    TotalStudent.Text = totalStudent.ToString();
                    int issueBook = (int)sqlCommand.ExecuteScalar();
                    TodayIssueBook.Text = issueBook.ToString();



                }
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

        private void TotalBook_Click(object sender, EventArgs e)
        {

        }
    }
}
