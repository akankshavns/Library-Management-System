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
            BookManagementMenuSlider.Start();
            //bookBoard1.notshow();
            //bookBoard1.Show();
            //bookBoard1.BringToFront();

        }
        private void Student_Click(object sender, EventArgs e)
        {
            StudentManagementMenuSlider.Start();
            //studentBoard1.notshow();
            //studentBoard1.Show();
            //studentBoard1.BringToFront();
        }
        private void Dashboard_Click(object sender, EventArgs e)
        {
            //dashboard1.countOfAllrecods();
            //dashboard1.Show();
            //dashboard1.BringToFront();
        }
        private void Trsnsaction_Click(object sender, EventArgs e)
        {
            TransactionManagementMenuSlider.Start();
            //transactionBoard1.notshow();
            //transactionBoard1.Show();
            //transactionBoard1.BringToFront();
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }
        private void Setting_Click(object sender, EventArgs e)
        {
            //settingBoard1.notshow();
            //settingBoard1.Show();
            //settingBoard1.BringToFront();
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

        private void Bin_Click(object sender, EventArgs e)
        {
            //bin1.Show();
            //bin1.BringToFront();
        }
        bool MenuButtonExpand=false;
     

        private void BookManagementMenuSlider_Tick_1(object sender, EventArgs e)
        {
            if (MenuButtonExpand == false)
            {
                Abc.Height += 10;
                if (Abc.Height >= 219)
                {
                    TransactionManagementMenuSlider.Enabled = true;
                    StudentManagementMenuSlider.Enabled = true;
                    BookManagementMenuSlider.Stop();
                    MenuButtonExpand = true;
                }
            }
            else
            {
                Abc.Height -= 10;
                if (Abc.Height <= 65)
                {
                    //TransactionManagementMenuSlider.Enabled = true;
                    //StudentManagementMenuSlider.Enabled = true;
                    BookManagementMenuSlider.Stop();
                    MenuButtonExpand = false;
                }
            }
        }

        private void StudentManagementMenuSlider_Tick(object sender, EventArgs e)
        {
            if (MenuButtonExpand == false)
            {
                StudentMenuPanel.Height += 10;
                if (StudentMenuPanel.Height >= 219)
                {
                    BookManagementMenuSlider.Enabled= true;
                    TransactionManagementMenuSlider.Enabled = true;
                    StudentManagementMenuSlider.Stop();
                    MenuButtonExpand = true;
                }
            }
            else
            {
                StudentMenuPanel.Height -= 10;
                if (StudentMenuPanel.Height <= 65)
                {
                    //BookManagementMenuSlider.Enabled = true;
                    //TransactionManagementMenuSlider.Enabled = true;
                    StudentManagementMenuSlider.Stop();
                    MenuButtonExpand = false;
                }
            }
        }

        private void TransactionManagementMenuSlider_Tick(object sender, EventArgs e)
        {
            if (MenuButtonExpand == false)
            {
                BookManagementMenuSlider.Enabled = true;
                StudentManagementMenuSlider.Enabled = true;
                TransactionMenuePanel.Height += 10;
                if (TransactionMenuePanel.Height >= 219)
                {
                   
                    TransactionManagementMenuSlider.Stop();
                    MenuButtonExpand = true;
                }
            }
            else
            {
               TransactionMenuePanel.Height -= 10;
                if (TransactionMenuePanel.Height <= 65)
                {
                    //BookManagementMenuSlider.Enabled = true;
                    //StudentManagementMenuSlider.Enabled = true;
                    TransactionManagementMenuSlider.Stop();
                    MenuButtonExpand = false;
                }
            }
        }
    }
}
