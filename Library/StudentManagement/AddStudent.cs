using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library.StudentManagement
{
    public partial class AddStudent : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;Pooling=False;");
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }

        private void upload_Click(object sender, EventArgs e)
        {
            String imagePath = "";
            try
            {
                OpenFileDialog fileDilog = new OpenFileDialog();
                fileDilog.Filter = "Image Files(*.jpg;*.png)|*.jpg;*.png";
                if (fileDilog.ShowDialog() == DialogResult.OK)
                {
                    imagePath =fileDilog.FileName;
                    AddBook_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string path = Path.Combine(@"C:\Users\HP\source\repos\Library\Library\BookDirectory\" + textBox1.Text+"_"+ textBox2.Text+"_"+".jpg");

                string directoryPath = Path.GetDirectoryName(path);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                File.Copy(AddBook_picture.ImageLocation,path,true);

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into StudentInformation values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + AddBook_picture.ImageLocation + "','" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "' )";
                cmd.ExecuteNonQuery();

                AddBook_picture.ImageLocation = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";

                MessageBox.Show("Student information added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
