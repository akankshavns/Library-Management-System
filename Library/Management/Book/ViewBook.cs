using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
        private void BackButton_Click(object sender, EventArgs e)
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
       
        private void textBox1_KeyUp_1(object sender, KeyEventArgs e)
        {
            DataView dv = booksTable.DefaultView;
            dv.RowFilter = $"BookName LIKE '%{SearchBox.Text}%' OR AuthorName LIKE '%{SearchBox.Text}%'";
            dataGridView1.DataSource = dv.ToTable();
        }
        public void LoadBooks()
        {
            booksTable.Clear();

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
        public string pages,AvailableBook, volume,Language, Quantity, price, dateBox, Publication, Author,BName, dbID,sno;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                sno = selectedRow.Cells[0].Value.ToString();
                dbID = selectedRow.Cells[1].Value.ToString();
                BName = selectedRow.Cells[2].Value.ToString();
                Author = selectedRow.Cells[3].Value.ToString();
                Publication = selectedRow.Cells[4].Value.ToString();
                dateBox = selectedRow.Cells[8].Value.ToString();
                price = selectedRow.Cells[9].Value.ToString();
                Quantity = selectedRow.Cells[10].Value.ToString();
                Language = selectedRow.Cells[7].Value.ToString();
                volume = selectedRow.Cells[5].Value.ToString();
                AvailableBook = selectedRow.Cells[11].Value.ToString();
                pages = selectedRow.Cells[6].Value.ToString();

            }
            DialogResult result = MessageBox.Show("Are you sure?,Do you want to delete this record from Library Book  Recods", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {

                        string BookDeletedItem = "DELETE FROM AddBooks WHERE SNO = @sno";
                            string BookInBin= "INSERT INTO BOOKDELETEDITEMS VALUES(@id,@name,@author, @Publication,@volume,@pages,@language,@dateBox,@price, @quantity, @availableBook)";
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand(BookInBin, con);
                            cmd.Parameters.AddWithValue("@id", dbID);
                            cmd.Parameters.AddWithValue("@name", BName);
                            cmd.Parameters.AddWithValue("@author", Author);
                            cmd.Parameters.AddWithValue("@publication", Publication);
                            cmd.Parameters.AddWithValue("@volume", volume);
                            cmd.Parameters.AddWithValue("@pages", pages);
                            cmd.Parameters.AddWithValue("@language", Language);
                            cmd.Parameters.AddWithValue("@dateBox", dateBox);
                            cmd.Parameters.AddWithValue("@price", price);
                            cmd.Parameters.AddWithValue("@quantity", Quantity);
                            cmd.Parameters.AddWithValue("@availableBook", AvailableBook);
                            int i = cmd.ExecuteNonQuery();
                            if (i >= 1)
                            {
                               SqlCommand command = new SqlCommand(BookDeletedItem, con);
                                command.Parameters.AddWithValue("@sno",sno);
                                int deleted = command.ExecuteNonQuery();
                                if (deleted >= 1) 
                                {
                                    MessageBox.Show("This record deleted successfully");
                                }

                            }
                        }
                        catch (Exception ex){ MessageBox.Show(ex.Message); }
                    }
                }

            }
        }
    }
}
