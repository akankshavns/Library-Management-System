using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.BookManagement
{
    public partial class AddBook : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;Pooling=False;");
        public AddBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into AddBooks values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "'," + textBox5.Text + "," + textBox6.Text + ")";
                cmd.ExecuteNonQuery();
                con.Close();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";

                MessageBox.Show("Book added successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("AN Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }
    }
    
}
