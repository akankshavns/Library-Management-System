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
    public partial class SearchBooks : UserControl
    {
        public string availableBookId_issueBook { get; set; }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public SearchBooks()
        {
            InitializeComponent();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }
        private void searchBox_Click_1(object sender, EventArgs e)
        {
            searchBox.Clear();
            searchBox.ForeColor = Color.Black;
        }
        DataTable booksTable = new DataTable();
        private void issueBook_Load(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string viewdata = "SELECT SNO, Accession_No, BookName, AUTHORNAME, VOLUME FROM AddBooks";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(viewdata, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        booksTable.Load(reader);
                        dataGridView.DataSource = booksTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }
        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            DataView dv = booksTable.DefaultView;
            dv.RowFilter = $"BookName LIKE '%{searchBox.Text}%' OR AuthorName LIKE '%{searchBox.Text}%'";
            dataGridView.DataSource = dv.ToTable();

        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
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
                    DialogResult result = MessageBox.Show("This Book is Available in the library,do you want to issue this book ? ", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        issueFormDetails1.availableBookId = availableBookId_issueBook;
                        issueFormDetails1.Show();
                        issueFormDetails1.BringToFront();
                    }
                }
            }
        }

       
    }

       
}

