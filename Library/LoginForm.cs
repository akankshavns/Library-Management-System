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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;Pooling=False;");

        int count = 0;
        private bool isPasswordVisible = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            loginpanel.BackColor = Color.FromArgb(60, 0, 0, 0);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        private void check()
        {
            if(Text_UserName.Text == String.Empty && text_password.Text == String.Empty)
            {
                MessageBox.Show("Please fill User Name and Password first");
            }
            else if (Text_UserName.Text == String.Empty)
            {
                errorProvider1.SetError(Text_UserName, "Please fill out this field");
            }
            else if (text_password.Text == String.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(text_password, "Please fill out this field");
            }
            else
            {


                try
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Librarian where UserName ='" + Text_UserName.Text + "' and Password = '" + text_password.Text + "'";
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    count = Convert.ToInt32(dt.Rows.Count.ToString());
                    if (count == 0)
                    {
                        Text_UserName.ForeColor = SystemColors.ControlLight;
                        text_password.ForeColor = SystemColors.ControlLight;
                        MessageBox.Show("Wrong userName and password.");
                        Text_UserName.Text = "User Name";
                        text_password.UseSystemPasswordChar = isPasswordVisible;
                        text_password.Text = "Password";




                    }
                    else
                    {
                        this.Hide();
                        Home hp = new Home();
                        hp.Show();
                    }
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            check();
        }

        private void Text_UserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (Text_UserName.Text == "User Name")
            {
                Text_UserName.Text = "";
                Text_UserName.ForeColor = Color.Black;
            }
        }

        private void text_password_MouseClick(object sender, MouseEventArgs e)
        {
            if (text_password.Text == "Password")
            {
                text_password.Text = "";
                text_password.ForeColor = Color.Black;
                text_password.UseSystemPasswordChar = !isPasswordVisible;

            }
        }

        private void text_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                check();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            text_password.UseSystemPasswordChar = !isPasswordVisible;
            if (isPasswordVisible)
            {
                pictureBox2.Text = "Show"; 
            }
            else
            {
                pictureBox2.Text = "Hide"; 
            }
        }
    }
}
