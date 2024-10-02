using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

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
            clearText();
            errorProviderAuthor.Clear();
            errorProviderAvailableBook.Clear();
            errorProviderLanguage.Clear();
            errorProviderPages.Clear();
            errorProviderPrice.Clear();
            errorProviderVolume.Clear();
            errorInID.Clear();
            errorInName.Clear();
            errorProviderPublicatioin.Clear();
            errorProviderQuantity.Clear();
            
        }
        string Language;
        public void AddKitab()
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
                    string idExist = "select Accession_No from AddBooks where Accession_No=@Id";
                    string addBook = "Insert into AddBooks values(@Id,@Name,@Author,@page,@Valume,@Language,@Publication,@BookDate,@Price,@quantity,@availableBook)";
                    try
                    {
                        con.Open();
                        SqlCommand comm = new SqlCommand(idExist, con);
                        comm.Parameters.AddWithValue("@Id", ID.Text);                       
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("This book is already exist in the library.");
                        }
                        else
                        {
                            reader.Close();
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
                                clearText();
                            }
                            else
                            {
                                MessageBox.Show("Please fill the Information properly.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show( ex.Message);
                    }
                }
            }
            
        }
        bool hasErrors= false;
        private void AddButton_Click(object sender, EventArgs e)
        {
            Error();
            if (hasErrors == false)
            {
                AddKitab();
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

        private void AddBook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Error();
                if (hasErrors == false)
                { 
                    AddKitab(); 
                }
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

        private void Language_TextChanged(object sender, EventArgs e)
        {
            //errorProviderLanguage.SetError(Language, "");
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
        public void clearText()
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

        

      
    }

}
