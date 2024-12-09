using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        //show the data in grid view.
        public void LoadBooks()
        {
            booksTable.Clear();
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string viewdata = "SELECT ISBNNumber ,Accession_No,BookName,AuthorName,Publication,volume,pages,Language,BookDate,Price,Quantity,catagory  FROM ADDBOOKS where BookStatus = 'Retained'";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(viewdata, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        booksTable.Load(reader);
                        dataGridView1.DataSource = booksTable;
                        dataGridView1.Columns["ISBNNumber"].HeaderText = "ISBN Number";
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
        int getId = 0;
        //this code for retrive the data in the textBox from database for updation
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
                getId = Convert.ToInt32(selectedRow.Cells[0].Value);
                ISBNNum.Text = getId.ToString();
                AcccessionID.Text = selectedRow.Cells[1].Value.ToString();
                BookName.Text = selectedRow.Cells[2].Value.ToString();
                AuthorName.Text = selectedRow.Cells[3].Value.ToString();
                BookPublication.Text = selectedRow.Cells[4].Value.ToString();
                purchaseDate.Value = Convert.ToDateTime(selectedRow.Cells[8].Value.ToString());
                BookPrice.Text = selectedRow.Cells[9].Value.ToString();
                BookQuantity.Text = selectedRow.Cells[10].Value.ToString();
                Languages.Text = selectedRow.Cells[7].Value.ToString();
                BValume.Text = selectedRow.Cells[5].Value.ToString();
                catagory.Text = selectedRow.Cells["catagory"].Value.ToString();
                NumOfPages.Text = selectedRow.Cells[6].Value.ToString();

            }
        }
        private void ViewBook_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }
        //this  code for update the data in the database  in the  Book table.
        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0 && dataGridView1.SelectedCells[0].Value != null)
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string updateBookDetail = "UPDATE ADDBOOKS SET ISBNNumber = @isbn, ACCESSION_NO = @id, BOOKNAME = @name, AUTHORNAME = @author, PUBLICATION = @publication, VOLUME = @volume, PAGES = @pages, LANGUAGE = @language, BOOKDATE = @bookdate, PRICE = @price, QUANTITY = @quantity, Catagory=@catagory WHERE ISBNNumber =" +getId+ "";
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand(updateBookDetail, con);
                            cmd.Parameters.AddWithValue("@isbn", ISBNNum.Text);
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
                            cmd.Parameters.AddWithValue("@catagory", catagory.Text);

                            int i = cmd.ExecuteNonQuery();
                            if (i >= 1)
                            {
                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    if (Convert.ToInt32(row.Cells["ISBNNumber"].Value) == getId)
                                    {
                                        // Update the corresponding cells in the selected row
                                        row.Cells["ISBNNumber"].Value = ISBNNum.Text;
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
                                updateSection.Visible = false;
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
            DialogResult result = MessageBox.Show("Are you sure? Do you want to delete this record?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                // Assume that `ISBNNumber` is fetched from the selected cell in DataGridView
                int ISBNNumber = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ISBNNumber"].Value);

                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string updateBookStatus = "UPDATE ADDBOOKS SET BookStatus = @BookStatus WHERE ISBNNumber = @ISBNNumber";

                        using (SqlCommand cmd = new SqlCommand(updateBookStatus, con))
                        {
                            cmd.Parameters.AddWithValue("@BookStatus", "Deleted");
                            cmd.Parameters.AddWithValue("@ISBNNumber", ISBNNumber);

                            try
                            {
                                con.Open();
                                int updated = cmd.ExecuteNonQuery();
                                if (updated >= 1)
                                {
                                    LoadBooks();
                                    MessageBox.Show("Book deleted successfully.");

                                }
                                else
                                {
                                    MessageBox.Show("No record found with the specified ISBNNumber.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                    }
                }
            }
        }

    }
}
