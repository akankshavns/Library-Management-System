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
        //string cs = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;");
        public AddBook()
        {
            InitializeComponent();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (con )
                {
                    string addBook = "Insert into AddBooks values(@Id,@Name,@Author,@Publication,@Valume,@Language,@page,@source,@BillNo,@Place,@BookDate,@Price,@quantity,@availableBook)";
                    SqlCommand cmd = new SqlCommand(addBook, con);
                    cmd.Parameters.AddWithValue("@Id", ID.Text);
                    cmd.Parameters.AddWithValue("@Name", BName.Text);
                    cmd.Parameters.AddWithValue("@Author", Author.Text);
                    cmd.Parameters.AddWithValue("@Publication", Publication.Text);
                    cmd.Parameters.AddWithValue("@Valume", volume.Text);
                    cmd.Parameters.AddWithValue("@Language", Language.Text);
                    cmd.Parameters.AddWithValue("@page", pages.Text);
                    cmd.Parameters.AddWithValue("@source", Source.Text);
                    cmd.Parameters.AddWithValue("@BillNo", BillNo.Text);
                    cmd.Parameters.AddWithValue("@Place", Place.Text);
                    cmd.Parameters.AddWithValue("@BookDate", BookDate.Text);
                    cmd.Parameters.AddWithValue("@Price", price.Text);
                    cmd.Parameters.AddWithValue("@quantity", Quantity.Text);
                    cmd.Parameters.AddWithValue("@availableBook", AvailableBook.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book added successfully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
