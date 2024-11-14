using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library.TransactionManagement
{
    public partial class ViewTransaction : UserControl
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public ViewTransaction()
        {
            InitializeComponent();
        }
        DataTable bookTable = new DataTable();
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }

        private void ViewTransaction_Load(object sender, EventArgs e)
        {
            viewIssuedBook();
        }
        public void viewIssuedBook()
        {
            bookTable.Clear();
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string showData = "SELECT * FROM ISSUEBOOKLIST where isReturnBook=@status";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(showData, con);
                        cmd.Parameters.AddWithValue("@status", "Hold");
                        SqlDataReader reader = cmd.ExecuteReader();
                        bookTable.Load(reader);
                        dataGridView1.DataSource = bookTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("I am from load page", ex.Message);
                    }
                }
            }
        }
    }
}
