using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Library
{
    public partial class Home : Form
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public Home()
        {
            InitializeComponent();
        }

        bool sidebarExpand = true;
        void slider()
        {
            close.Start();
        }
        private void MenuSlider_Tick_1(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                menuBar.Width -= 10;
                if (menuBar.Width <= 60)
                {
                    sidebarExpand = false;
                    MenuSlider.Stop();
                }
            }
            else
            {
                menuBar.Width += 10;
                if (menuBar.Width >= 165)
                {
                    sidebarExpand = true;
                    MenuSlider.Stop();
                }
            }
        }
        private void close_Tick_1(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                menuBar.Width -= 10;
                if (menuBar.Width <= 60)
                {
                    sidebarExpand = false;
                    close.Stop();
                }
            }
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            MenuSlider.Start();
        }
        private void logOut_Click_1(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
        private void Books_Click_1(object sender, EventArgs e)
        {
            bookBoard1.Show();
            bookBoard1.BringToFront();

        }
        private void Student_Click(object sender, EventArgs e)
        {
            studentBoard1.Show();
            studentBoard1.BringToFront();
        }
        private void Dashboard_Click(object sender, EventArgs e)
        {
            dashboard1.Show();
            dashboard1.BringToFront();
        }
        private void Trsnsaction_Click(object sender, EventArgs e)
        {
            transactionBoard1.Show();
            transactionBoard1.BringToFront();
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }
        private void Setting_Click(object sender, EventArgs e)
        {
            settingBoard1.Show();
            settingBoard1.BringToFront();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string Homepagelogo = "select logo from librarysetting where  id="+2+"";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(Homepagelogo, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string photoPath = reader["logo"].ToString();
                            
                            if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
                            {
                                byte[] imageBytes = File.ReadAllBytes(photoPath);
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    HomeLogo.BackgroundImage = Image.FromStream(ms);
                                    HomeLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                            }
                            else
                            {
                                HomeLogo.BackgroundImage = null;
                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
                
            }
        }
    }
}
