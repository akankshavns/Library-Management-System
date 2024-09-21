using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class LoginForm : Form
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        private bool isPasswordVisible = false;
        public LoginForm()
        {
            InitializeComponent();
            errorProvider1 = new ErrorProvider();
            errorProvider2 = new ErrorProvider();
            Text_UserName.TextChanged += new EventHandler(Text_UserName_TextChanged);
            text_password.TextChanged += new EventHandler(text_password_TextChanged);
           
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            loginpanel.BackColor = Color.FromArgb(60, 0, 0, 0);
        }
        private void LoginLogic()
        {
            try
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string login = "Select * From Librarian where UserName=@username and Password = @password";
                        SqlCommand cmd = new SqlCommand(login, con);
                        cmd.Parameters.AddWithValue("@username", Text_UserName.Text);
                        cmd.Parameters.AddWithValue("@password", text_password.Text);
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            this.Hide();
                            Home hp = new Home();
                            hp.Show();
                        }
                        else
                        {
                            Text_UserName.ForeColor = SystemColors.ControlLight;
                            text_password.ForeColor = SystemColors.ControlLight;
                            MessageBox.Show("Incorrect user name and password");
                            Text_UserName.Text = "User Name";
                            text_password.UseSystemPasswordChar = isPasswordVisible;
                            text_password.Text = "Password";
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool hasErrors = false;         
            if (string.IsNullOrEmpty(Text_UserName.Text)|| Text_UserName.Text == "User Name")
            {
                errorProvider1.SetError(Text_UserName, "Field 1 is required.");
                hasErrors = true;
            }
            if (string.IsNullOrEmpty(text_password.Text) || text_password.Text == "Password")
            {
                errorProvider2.SetError(text_password, "Field 2 is required.");
                hasErrors = true;
            }
            if (!hasErrors)
            {
                LoginLogic();
            }
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
                bool hasErrors = false;
                if (string.IsNullOrEmpty(Text_UserName.Text) || Text_UserName.Text == "User Name")
                {
                    errorProvider1.SetError(Text_UserName, "Field 1 is required.");
                    hasErrors = true;
                }
                if (string.IsNullOrEmpty(text_password.Text) || text_password.Text == "Password")
                {
                    errorProvider2.SetError(text_password, "Field 2 is required.");
                    hasErrors = true;
                }
                if (!hasErrors)
                {
                    LoginLogic();
                }
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

        private void Text_UserName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(Text_UserName, "");
        }

        private void text_password_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.SetError(text_password, "");
        }
    }
}
