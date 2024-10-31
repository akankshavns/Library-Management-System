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
                    string viewdata = "SELECT sno ,Accession_No,BookName,AuthorName,Publication,volume,pages,Language,BookDate,Price,Quantity,catagory  FROM ADDBOOKS";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(viewdata, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        booksTable.Load(reader);
                        dataGridView1.DataSource = booksTable;
                        dataGridView1.Columns["sno"].HeaderText = "Serial No";
                        dataGridView1.Columns["Accession_No"].HeaderText = "Accession Number";
                        dataGridView1.Columns["BookName"].HeaderText = "Book Title";
                        dataGridView1.Columns["AuthorName"].HeaderText = "Author";
                        dataGridView1.Columns["Publication"].HeaderText = "Publisher";
                        dataGridView1.Columns["volume"].HeaderText = "Volume";
                        dataGridView1.Columns["pages"].HeaderText = "Pages";
                        dataGridView1.Columns["Language"].HeaderText = "Language";
                        dataGridView1.Columns["BookDate"].HeaderText = "Date Added";
                        dataGridView1.Columns["Price"].HeaderText = "Price";
                        dataGridView1.Columns["Quantity"].HeaderText = "Quantity";
                        dataGridView1.Columns["catagory"].HeaderText = "Category";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        public string pages,AvailableBook, volume,Language, Quantity, price, dateBox, Publication, Author,BName, dbID,sno;

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                AcccessionID.Enabled = true;
                BookName.Enabled = true;
                BookPrice.Enabled = true;
                NumOfPages.Enabled = true;
                BookPublication.Enabled = true;
                BookQuantity.Enabled = true;
                BValume.Enabled = true;
                Languages.Enabled = true;
               
                AuthorName.Enabled = true;
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                AcccessionID.Text= selectedRow.Cells[1].Value.ToString();
                BookName.Text = selectedRow.Cells[2].Value.ToString();
                AuthorName.Text = selectedRow.Cells[3].Value.ToString();
                BookPublication.Text = selectedRow.Cells[4].Value.ToString();
                purchaseDate.Value = Convert.ToDateTime(selectedRow.Cells[8].Value.ToString());
                BookPrice.Text = selectedRow.Cells[9].Value.ToString();
                BookQuantity.Text = selectedRow.Cells[10].Value.ToString();
                Languages.Text = selectedRow.Cells[7].Value.ToString();
                BValume.Text = selectedRow.Cells[5].Value.ToString();
                catagory.Text= selectedRow.Cells["catagory"].Value.ToString();
                NumOfPages.Text = selectedRow.Cells[6].Value.ToString();

            }
        }
        private void ViewBook_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            int sno = 0;
            if (dataGridView1.SelectedCells.Count > 0 && dataGridView1.SelectedCells[0].Value != null)
            {
                sno = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string updateBookDetail = "UPDATE ADDBOOKS SET ACCESSION_NO = @id, BOOKNAME = @name, AUTHORNAME = @author, PUBLICATION = @publication, VOLUME = @volume, PAGES = @pages, LANGUAGE = @language, BOOKDATE = @bookdate, PRICE = @price, QUANTITY = @quantity, Catagory=@catagory WHERE SNO =" + sno + "";
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand(updateBookDetail, con);
                            cmd.Parameters.AddWithValue("@id", AcccessionID.Text);
                            cmd.Parameters.AddWithValue("@name", BookName.Text);
                            cmd.Parameters.AddWithValue("@author", AuthorName.Text);
                            cmd.Parameters.AddWithValue("@publication", BookPublication.Text);
                            cmd.Parameters.AddWithValue("@volume", BValume.Text);
                            cmd.Parameters.AddWithValue("@pages", NumOfPages.Text);
                            cmd.Parameters.AddWithValue("@language", Languages.Text);
                            cmd.Parameters.AddWithValue("@bookdate", purchaseDate.Value);
                            cmd.Parameters.AddWithValue("@price", BookPrice.Text);
                            cmd.Parameters.AddWithValue("@quantity", BookQuantity.Text);
                            cmd.Parameters.AddWithValue("@catagory",catagory.Text);
                           
                            int i = cmd.ExecuteNonQuery();
                            if (i >= 1)
                            {
                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    if (Convert.ToInt32(row.Cells["SNO"].Value) == sno)
                                    {
                                        // Update the corresponding cells in the selected row
                                        row.Cells["Accession_No"].Value = AcccessionID.Text;
                                        row.Cells["BookName"].Value = BookName.Text;
                                        row.Cells["AuthorName"].Value = AuthorName.Text;
                                        row.Cells["Publication"].Value = BookPublication.Text;
                                        row.Cells["volume"].Value = BValume.Text;
                                        row.Cells["pages"].Value = NumOfPages.Text;
                                        row.Cells["Language"].Value = Languages.Text;
                                        row.Cells["BookDate"].Value = purchaseDate.Text;
                                        row.Cells["Price"].Value = BookPrice.Text;
                                        row.Cells["Quantity"].Value = BookQuantity.Text;
                                        row.Cells["catagory"].Value = catagory.Text;
                                            
                                       
                                        break;
                                    }
                                }
                                MessageBox.Show("updated successfully");
                                updateSection.Visible= false;
                                dataGridView1.Width = 1075;
                            }
                            else
                            {
                                MessageBox.Show("something went wrong");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select any row.");
            }
        }
        private void updateSectionButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Width = 685;
            updateSection.Visible = true;
        }
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
                catagory.Text = selectedRow.Cells[11].Value.ToString();
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
