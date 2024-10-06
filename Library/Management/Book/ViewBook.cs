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

namespace Library.BookManagement
{
    public partial class ViewBook : UserControl
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public ViewBook()
        {
            InitializeComponent();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
            SearchBox.Clear();
            SearchBox.ForeColor = Color.Black;
        }

        DataTable booksTable = new DataTable();
        private void ViewBook_Load(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string viewdata = "SELECT * FROM ADDBOOKS";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(viewdata, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        booksTable.Load(reader);
                        dataGridView1.DataSource = booksTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void textBox1_KeyUp_1(object sender, KeyEventArgs e)
        {
            DataView dv = booksTable.DefaultView;
            dv.RowFilter = $"BookName LIKE '%{SearchBox.Text}%' OR AuthorName LIKE '%{SearchBox.Text}%'";
            dataGridView1.DataSource = dv.ToTable();
        }
    }

}
