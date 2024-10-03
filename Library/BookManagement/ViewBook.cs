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

        private void ViewBook_Load(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string viewBook = "select*From AddBooks";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(viewBook, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }


        

        private void label1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp_1(object sender, KeyEventArgs e)
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    int i = 0;
                    string search = "select*From AddBooks where BookName like('%" + textBox1.Text + "%') or AuthorName like ('%" + textBox1.Text + "%') ";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(search, con);
                        SqlDataReader reader =cmd.ExecuteReader();
                        if (!reader.Read())
                        {
                            MessageBox.Show("Book not found.");
                        }
                        else
                        {
                            DataTable dtable = new DataTable();
                            dtable.Load(reader);
                            dataGridView1.DataSource = dtable;
                        }
                        //con.Close();
                        //DataTable dt = new DataTable();
                        //SqlDataAdapter adapter = new SqlDataAdapter();
                        //adapter.SelectCommand = cmd;
                        //adapter.Fill(dt);
                        //i = Convert.ToInt32(dt.Rows.Count.ToString());
                        //dataGridView1.DataSource = dt;
                        //con.Close();

                        //if (i == 0)
                        //{
                        //    MessageBox.Show("Book not found.");
                        //}
                    }
                    catch (Exception ex)
                    { 
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
    
}
