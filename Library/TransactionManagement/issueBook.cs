using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Library.TransactionManagement
{
    public partial class issueBook : UserControl
    {
        public string availableBookId_issueBook { get; set; }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public issueBook()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }
        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            string searchQuery = "SELECT Accession_No, BookName FROM AddBooks WHERE BookName LIKE @searchText OR AuthorName LIKE @searchText";
            try
            {
                string connectionString = GetConnectionString();
                if (connectionString != null) 
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(searchQuery, con);
                        cmd.Parameters.AddWithValue("@searchText", "%" + searchBox.Text + "%");
                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "key up");
            }
        }

        private void yes_Click(object sender, EventArgs e)
        {
            issueFormDetails1.availableBookId = availableBookId_issueBook;
            issueFormDetails1.Show();
            issueFormDetails1.BringToFront();
        }
        private void No_button_Click(object sender, EventArgs e)
        {
            aivalableMessageBox.Visible = false;
        }
        private void Close_Click(object sender, EventArgs e)
        {
            aivalableMessageBox.Visible = false;
        }
        private void searchBox_Click_1(object sender, EventArgs e)
        {
            gridpanel.Visible = true;
            if (searchBox.Text == "Search Book...")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }
        private void issueBook_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string querry = "select Accession_No,BookName From AddBooks";
                        SqlCommand cmd = new SqlCommand(querry, con);
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "issuealosd");
            }
            }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string query = "SELECT AvailableBook FROM AddBooks WHERE Accession_No = @BookId";
                int num = 0;
                try
                {
                    string connectionString = GetConnectionString();
                    if (connectionString != null)
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@BookId", id);
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        
                            if (reader.Read())
                            {
                                num = reader.GetInt32(0);
                            }
                            else
                            {
                                MessageBox.Show("No record found.");
                                return;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error cell click " + ex.Message);
                    return;
                }
                if (num == 0)
                {
                    MessageBox.Show("Book is not available at present.");
                }
                else
                {
                    availableBookId_issueBook = id;
                    aivalableMessageBox.Visible = true;
                }
            }
        }
    }
}
