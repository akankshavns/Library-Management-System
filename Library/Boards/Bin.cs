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

        private void BookDeletedItem_CheckedChanged(object sender, EventArgs e)
        {
            if (BookDeletedItem.Checked)
            {

                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        //string viewdata = "SELECT * FROM ADDBOOKS";
                        //try
                        //{
                        //    con.Open();
                        //    SqlCommand cmd = new SqlCommand(viewdata, con);
                        //    SqlDataReader reader = cmd.ExecuteReader();
                        //    booksTable.Load(reader);
                        //    dataGridView1.DataSource = booksTable;
                        //}
                        //catch (Exception ex)
                        //{
                        //    MessageBox.Show(ex.Message);
                        //}
                    }
                }
            }
        }
    }
}
