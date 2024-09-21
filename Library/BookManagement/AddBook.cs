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
        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }
        public void AddKitab()
        {
            try
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string addBook = "Insert into AddBooks values(@Id,@Name,@Author,@page,@Valume,@Language,@Publication,@BookDate,@Price,@quantity,@availableBook)";
                        SqlCommand cmd = new SqlCommand(addBook, con);
                        cmd.Parameters.AddWithValue("@Id", ID.Text);
                        cmd.Parameters.AddWithValue("@Name", BName.Text);
                        cmd.Parameters.AddWithValue("@Author", Author.Text);
                        cmd.Parameters.AddWithValue("@Publication", Publication.Text);
                        cmd.Parameters.AddWithValue("@Valume", volume.Text);
                        cmd.Parameters.AddWithValue("@Language", Language.Text);
                        cmd.Parameters.AddWithValue("@page", pages.Text);
                        cmd.Parameters.AddWithValue("@BookDate", BookDate.Text);
                        cmd.Parameters.AddWithValue("@Price", price.Text);
                        cmd.Parameters.AddWithValue("@quantity", Quantity.Text);
                        cmd.Parameters.AddWithValue("@availableBook", AvailableBook.Text);
                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i >= 1)
                        {
                            MessageBox.Show("Book added successfully");
                        }
                        else {
                            MessageBox.Show("Please fill the Information properly.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        bool hasErrors= false;
        private void AddButton_Click(object sender, EventArgs e)
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
            if (string.IsNullOrEmpty(Language.Text))
            {
                errorProviderLanguage.SetError(Language, "This Field is required.");
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
            if (hasErrors) 
            {
                AddKitab();
            }
        }

        private void AddBook_KeyDown(object sender, KeyEventArgs e)
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
            if (string.IsNullOrEmpty(Language.Text))
            {
                errorProviderLanguage.SetError(Language, "This Field is required.");
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
            if (!hasErrors)
            {
                AddKitab();
            }
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
            errorInID.SetError(ID, "");
        }

        private void BName_TextChanged(object sender, EventArgs e)
        {
            errorInName.SetError(BName, "");
        }

        private void Author_TextChanged(object sender, EventArgs e)
        {
            errorProviderAuthor.SetError(Author, "");
        }

        private void Publication_TextChanged(object sender, EventArgs e)
        {
            errorProviderPublicatioin.SetError(Publication, "");
        }

        private void volume_TextChanged(object sender, EventArgs e)
        {
            errorProviderVolume.SetError(volume, "");
        }

        private void pages_TextChanged(object sender, EventArgs e)
        {
            errorProviderPages.SetError(pages, "");

        }

        private void Language_TextChanged(object sender, EventArgs e)
        {
            errorProviderLanguage.SetError(Language, "");
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            errorProviderPrice.SetError(price, "");
        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {
            errorProviderQuantity.SetError(Quantity, "");
        }

        private void AvailableBook_TextChanged(object sender, EventArgs e)
        {
            errorProviderAvailableBook.SetError(AvailableBook, "");
        }
    }
}
