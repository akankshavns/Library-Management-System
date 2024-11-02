using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library.Boards
{
    public partial class Bin : UserControl
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public Bin()
        {
            InitializeComponent();
        }
        DataTable BookTable = new DataTable();

        public void showBookRelatedDeletedItem()
        {

            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string viewdata = "SELECT * FROM BookDeletedItems";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(viewdata, con);
                        BookGridView1.DataSource = BookTable;
                        SqlDataReader reader = cmd.ExecuteReader();
                        BookTable.Load(reader);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }


        public void showStudentRelatedDeletedItem()
        {

            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string viewdata = "SELECT * FROM StudentDeletedItems";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(viewdata, con);
                        StudentGridView2.DataSource = BookTable;
                        SqlDataReader reader = cmd.ExecuteReader();
                        BookTable.Load(reader);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Bin_Load(object sender, EventArgs e)
        {
            showBookRelatedDeletedItem();
            showStudentRelatedDeletedItem();
        }
    }
}
