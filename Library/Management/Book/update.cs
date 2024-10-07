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
using System.Xml.Linq;

namespace Library.BookManagement
{
    public partial class update : UserControl
    {
        private string dbID { get; set; }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        AddBook addBookForm = new AddBook();
        public update()
        {
            InitializeComponent();
        }
        public int i;
        DataTable booksTable = new DataTable();
        private void label7_Click(object sender, EventArgs e)
        {
            //bool hasUnsavedChanges = IsFormChanged();
            //if (hasUnsavedChanges)
            //{
            //    DialogResult result = MessageBox.Show("You have unsaved changes. Do you want to save them ? ", "Confirmation", MessageBoxButtons.YesNoCancel);
            //    if (result == DialogResult.Yes)
            //    {
            //        Updatebutton_Click(sender, e);
            //        dbID = ID.Text;
            //    }
            //    else if (result == DialogResult.No)
            //    {
            //        ID.Text = dbID;
            //    }
            //    else
            //    {
            //        //DialogResult.Cancel = true;
            //    }
            //}
            this.Hide();
            this.Visible = false;
            ID.Clear();
            Language.Clear();
            addBookForm.clearText(BName, Author, Publication, pages, volume, Quantity, price, AvailableBook);
        }

        private void update_Load(object sender, EventArgs e)
        {
            addBookForm.Enable(BName,Author,Publication,pages,volume,Quantity,price,AvailableBook);
            ID.Enabled = false;
            Selectbook();
        }
        public void Selectbook()
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
                        ViewDetail.DataSource = booksTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void ViewDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Enabled=true;
            addBookForm.disable(BName, Author, Publication, pages, volume, Quantity, price, AvailableBook);
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ViewDetail.Rows[e.RowIndex];
                dbID = selectedRow.Cells[1].Value.ToString();
                ID.Text = dbID;

                BName.Text = selectedRow.Cells[2].Value.ToString();
                Author.Text = selectedRow.Cells[3].Value.ToString();
                Publication.Text = selectedRow.Cells[4].Value.ToString();
                dateBox.Value = Convert.ToDateTime(selectedRow.Cells[8].Value.ToString());
                price.Text = selectedRow.Cells[9].Value.ToString();
                Quantity.Text = selectedRow.Cells[10].Value.ToString();
                Language.Text = selectedRow.Cells[7].Value.ToString();
                volume.Text = selectedRow.Cells[5].Value.ToString();
                AvailableBook.Text = selectedRow.Cells[11].Value.ToString();
                pages.Text = selectedRow.Cells[6].Value.ToString();

            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            int sno = 0;
            sno = Convert.ToInt32(ViewDetail.SelectedCells[0].Value.ToString());
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string updateBookDetail = "UPDATE ADDBOOKS SET ACCESSION_NO = @id, BOOKNAME = @name, AUTHORNAME = @author, PUBLICATION = @publication, VOLUME = @volume, PAGES = @pages, LANGUAGE = @language, BOOKDATE = @bookdate, PRICE = @price, QUANTITY = @quantity, AVAILABLEBOOK = @availableBook WHERE SNO =" + sno+ "";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(updateBookDetail, con);
                        cmd.Parameters.AddWithValue("@id", ID.Text); 
                        cmd.Parameters.AddWithValue("@name", BName.Text); 
                        cmd.Parameters.AddWithValue("@author", Author.Text);
                        cmd.Parameters.AddWithValue("@publication", Publication.Text);
                        cmd.Parameters.AddWithValue("@volume", volume.Text); 
                        cmd.Parameters.AddWithValue("@pages", pages.Text);
                        cmd.Parameters.AddWithValue("@language", Language.Text);
                        cmd.Parameters.AddWithValue("@bookdate", dateBox.Value); 
                        cmd.Parameters.AddWithValue("@price", price.Text);
                        cmd.Parameters.AddWithValue("@quantity", Quantity.Text);
                        cmd.Parameters.AddWithValue("@availableBook", AvailableBook.Text);
                         i = cmd.ExecuteNonQuery();
                        if (i >= 1)
                        {
                            foreach (DataGridViewRow row in ViewDetail.Rows)
                            {
                                if (Convert.ToInt32(row.Cells["SNO"].Value) == sno)
                                {
                                    // Update the corresponding cells in the selected row
                                    row.Cells["Accession_No"].Value = ID.Text;
                                    row.Cells["BookName"].Value = BName.Text;
                                    row.Cells["AuthorName"].Value = Author.Text;
                                    row.Cells["Publication"].Value = Publication.Text;
                                    row.Cells["volume"].Value = volume.Text;
                                    row.Cells["pages"].Value = pages.Text;
                                    row.Cells["Language"].Value = Language.Text;
                                    row.Cells["BookDate"].Value = dateBox.Text;
                                    row.Cells["Price"].Value = price.Text;
                                    row.Cells["Quantity"].Value = Quantity.Text;
                                    row.Cells["AvailableBook"].Value = AvailableBook.Text;
                                    break;
                                }
                            }
                            MessageBox.Show("updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("something went wrong");
                        }
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message); 
                    }
                }
            } 
        }

        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            DataView dv = booksTable.DefaultView;
            dv.RowFilter = $"BookName LIKE '%{SearchBox.Text}%' OR AuthorName LIKE '%{SearchBox.Text}%'";
            ViewDetail.DataSource = dv.ToTable();

        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
            SearchBox.Clear();
            SearchBox.ForeColor = Color.Black;
        }

        //private bool IsFormChanged()
        //{
        //    return dbID != ID.Text;
        //}
    }
}
    

