using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library.BookManagement
{
    public partial class AddBook : UserControl
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public AddBook()
        {
            InitializeComponent();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
            clearText(BName, Author, Publication, pages, volume, Quantity, price, AvailableBook);
            ClearErrorProvider();
        }
        
        bool hasErrors = false;
        string Language;
        private void AddButton_Click(object sender, EventArgs e)
        {
            Error();
            if (hasErrors == false)
            {
                AddBookDetailInDB();
            }
        }
        public void AddBookDetailInDB()
        {
            if (English.Checked)
            {
                Language = "English";
            }
            if (Hindi.Checked)
            {
                Language = "Hindi";
            }
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string addBook = "Insert into AddBooks values(@Id,@Name,@Author,@Publication,@Valume,@page,@Language,@BookDate,@Price,@quantity,@availableBook)";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(addBook, con);
                        cmd.Parameters.AddWithValue("@Id", ID.Text);
                        cmd.Parameters.AddWithValue("@Name", BName.Text);
                        cmd.Parameters.AddWithValue("@Author", Author.Text);
                        cmd.Parameters.AddWithValue("@Publication", Publication.Text);
                        cmd.Parameters.AddWithValue("@Valume", volume.Text);
                        cmd.Parameters.AddWithValue("@Language", Language);
                        cmd.Parameters.AddWithValue("@page", pages.Text);
                        cmd.Parameters.AddWithValue("@BookDate", BookDate.Text);
                        cmd.Parameters.AddWithValue("@Price", price.Text);
                        cmd.Parameters.AddWithValue("@quantity", Quantity.Text);
                        cmd.Parameters.AddWithValue("@availableBook", AvailableBook.Text);
                        int i = cmd.ExecuteNonQuery();
                        if (i >= 1)
                        {
                            MessageBox.Show("Book added successfully");
                            clearText(BName, Author, Publication, pages, volume, Quantity, price, AvailableBook);
                        }
                        else
                        {
                            MessageBox.Show("Please fill the Information properly.");
                        }
                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("1.Please fill the Information properly.");
                        //MessageBox.Show(ex.Message);
                    }
                }
            }

        }
        void Error()
        {
            if (string.IsNullOrEmpty(ID.Text))
            {
                errorInID.SetError(ID, "This Field is required.");
                hasErrors = true;
            }
            if (string.IsNullOrEmpty(BName.Text))
            {
                errorInName.SetError(BName, "This Field is required.");
                hasErrors = true;
            }
            if (string.IsNullOrEmpty(Author.Text))
            {
                errorProviderAuthor.SetError(Author, "This Field is required.");
                hasErrors = true;
            }
            if (string.IsNullOrEmpty(volume.Text))
            {
                errorProviderVolume.SetError(volume, "This Field is required.");
                hasErrors = true;
            }
            if (string.IsNullOrEmpty(Publication.Text))
            {
                errorProviderPublicatioin.SetError(Publication, "This Field is required.");
                hasErrors = true;
            }
            if (string.IsNullOrEmpty(AvailableBook.Text))
            {
                errorProviderAvailableBook.SetError(AvailableBook, "This Field is required.");
                hasErrors = true;
            }
            if (string.IsNullOrEmpty(pages.Text))
            {
                errorProviderPages.SetError(pages, "This Field is required.");
                hasErrors = true;
            }
            if (string.IsNullOrEmpty(Quantity.Text))
            {
                errorProviderQuantity.SetError(Quantity, "This Field is required.");
                hasErrors = true;
            }
            if (string.IsNullOrEmpty(price.Text))
            {
                errorProviderPrice.SetError(price, "This Field is required.");
                hasErrors = true;
            }

        }
        private void ID_TextChanged(object sender, EventArgs e)
        {
            errorInID.SetError(ID, "");
            hasErrors = false;

        }

        private void BName_TextChanged(object sender, EventArgs e)
        {
            errorInName.SetError(BName, "");
            hasErrors = false;
        }

        private void Author_TextChanged(object sender, EventArgs e)
        {
            errorProviderAuthor.SetError(Author, "");
            hasErrors = false;
        }

        private void Publication_TextChanged(object sender, EventArgs e)
        {
            errorProviderPublicatioin.SetError(Publication, "");
            hasErrors = false;
        }

        private void volume_TextChanged(object sender, EventArgs e)
        {
            errorProviderVolume.SetError(volume, "");
            hasErrors = false;
        }

        private void pages_TextChanged(object sender, EventArgs e)
        {
            errorProviderPages.SetError(pages, "");
            hasErrors = false;

        }
        private void price_TextChanged(object sender, EventArgs e)
        {
            errorProviderPrice.SetError(price, "");
            hasErrors = false;
        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {
            errorProviderQuantity.SetError(Quantity, "");
            hasErrors = false;
        }

        private void AvailableBook_TextChanged(object sender, EventArgs e)
        {
            errorProviderAvailableBook.SetError(AvailableBook, "");
            hasErrors = false;
        }
        
        private void OtherLanguage_Click(object sender, EventArgs e)
        {
            OtherLanguage.Clear();
            OtherLanguage.ForeColor = Color.Black;
        }

        private void other_CheckedChanged_1(object sender, EventArgs e)
        {
            OPTION.Hide();
            OtherLanguage.BringToFront();
            OtherLanguage.Visible = true;
            Language = OtherLanguage.Text;

        }

        private void Return_Click(object sender, EventArgs e)
        {
            OPTION.Show();
            OtherLanguage.SendToBack();
            OtherLanguage.Visible = false;
            other.Checked = false;
        }
        public void clearText(System.Windows.Forms.TextBox BName, System.Windows.Forms.TextBox Author, System.Windows.Forms.TextBox Publication, System.Windows.Forms.TextBox pages, System.Windows.Forms.TextBox volume, System.Windows.Forms.TextBox Quantity, System.Windows.Forms.TextBox price, System.Windows.Forms.TextBox AvailableBook)
        {
            ID.Clear();
            BName.Clear();
            Author.Clear();
            Publication.Clear();
            pages.Clear();
            volume.Clear();
            Quantity.Clear();
            price.Clear();
            AvailableBook.Clear();
        }
        public void Enable(System.Windows.Forms.TextBox BName, System.Windows.Forms.TextBox Author, System.Windows.Forms.TextBox Publication, System.Windows.Forms.TextBox pages, System.Windows.Forms.TextBox volume, System.Windows.Forms.TextBox Quantity, System.Windows.Forms.TextBox price, System.Windows.Forms.TextBox AvailableBook
            )
        {
            BName.Enabled = false;
            Author.Enabled = false;
            Publication.Enabled = false;
            pages.Enabled = false;
            volume.Enabled = false;
            Quantity.Enabled = false;
            price.Enabled = false;
            AvailableBook.Enabled = false;
        }
        public void disable(System.Windows.Forms.TextBox BName, System.Windows.Forms.TextBox Author, System.Windows.Forms.TextBox Publication, System.Windows.Forms.TextBox pages, System.Windows.Forms.TextBox volume, System.Windows.Forms.TextBox Quantity, System.Windows.Forms.TextBox price, System.Windows.Forms.TextBox AvailableBook)
        {
            BName.Enabled = true;
            Author.Enabled = true;
            Publication.Enabled =true;
            pages.Enabled = true;
            volume.Enabled = true;
            Quantity.Enabled = true;
            price.Enabled = true;
            AvailableBook.Enabled = true;
        }
        private void ID_KeyUp(object sender, KeyEventArgs e)
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string idExist = "select Accession_No from AddBooks where Accession_No like @Id";
                    try
                    {
                        con.Open();
                        SqlCommand comm = new SqlCommand(idExist, con);
                        comm.Parameters.AddWithValue("@Id", ID.Text);
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.Read())
                        {
                            Enable(BName, Author, Publication, pages, volume, Quantity, price, AvailableBook);
                            block.SetError(ID, "This book is already exist in the library.");
                        }
                        else
                        {
                            block.SetError(ID, "");
                            disable(BName, Author, Publication, pages, volume, Quantity, price, AvailableBook);
                        }
                    }
                    catch (Exception )
                    {
                        MessageBox.Show("2.Please fill the Information properly.");
                    }
                    
                }
            }
        }

        private void volume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProviderVolume.SetError(volume, "This text box only accepts numeric characters.");
            }
            else
            {
                errorProviderVolume.SetError(volume, "");
            }
        }


        private void pages_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProviderPages.SetError(pages, "This text box only accepts numeric characters.");
            }
            else
            {
                errorProviderVolume.SetError(volume, "");
            }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && !char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
              errorProviderPrice.SetError(price, "This text box only accepts numeric characters.");
            }
            else
            {
                errorProviderVolume.SetError(volume, "");
            }
        }

        private void Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProviderQuantity.SetError(Quantity, "This text box only accepts numeric characters.");
            }
            else
            {
                errorProviderVolume.SetError(volume, "");
            }
        }

        private void AvailableBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProviderAvailableBook.SetError(AvailableBook, "This text box only accepts numeric characters.");
            }
            else
            {
                errorProviderVolume.SetError(volume, "");
            }
        }
        void ClearErrorProvider()
        {
            errorProviderAuthor.Clear();
            errorProviderAvailableBook.Clear();
            errorProviderPages.Clear();
            errorProviderPrice.Clear();
            errorProviderVolume.Clear();
            errorInID.Clear();
            errorInName.Clear();
            errorProviderPublicatioin.Clear();
            errorProviderQuantity.Clear();
        }

   
    }

}
