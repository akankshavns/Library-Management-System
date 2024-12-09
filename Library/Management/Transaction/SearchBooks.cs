using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

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
    
        private void searchBox_Click_1(object sender, EventArgs e)
        {
            searchBox.Clear();
            searchBox.ForeColor = Color.Black;
        }
        DataTable booksTable = new DataTable();
        private void issueBook_Load(object sender, EventArgs e)
        {
            viewfunction();
        }
        public void viewfunction()
        {
            booksTable.Clear();
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string viewdata = "SELECT ISBNnumber, BookName, AUTHORNAME, VOLUME FROM AddBooks where BookStatus = 'Retained'";
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
        public static int num = 0;
        public static int sno;
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                sno = Convert.ToInt32(dataGridView.SelectedCells[0].Value.ToString());
                //string id = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                string query = "SELECT AvailableBook FROM AddBooks WHERE ISBNNumber = @BookId";
                
                try
                {
                    string connectionString = GetConnectionString();
                    if (connectionString != null)
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@BookId",sno);
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
                    availableBookId_issueBook = sno.ToString();
                    DialogResult result = MessageBox.Show("This Book is Available in the library,do you want to issue this book ? ", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        showBookDetail1.newupdatedreturndays();
                        ShowBookDetail bookDetail = new ShowBookDetail();
                        bookDetail .getNoOfIssueBookPerStudent();
                        showBookDetail1.availableBookId =Convert.ToInt32( availableBookId_issueBook);
                        showBookDetail1.Show();
                        showBookDetail1.BringToFront();
                    }
                }
            }
        }
    }

}

