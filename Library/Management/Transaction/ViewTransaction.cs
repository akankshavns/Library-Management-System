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
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string showData = "SELECT * FROM ISSUEBOOKLIST";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(showData, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        bookTable.Load(reader);
                        dataGridView1.DataSource= bookTable;
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show("I am from load page",ex.Message);
                    }
                }
            }
        }
    }
}
