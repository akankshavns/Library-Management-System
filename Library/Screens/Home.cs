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

        //bool sidebarExpand = true;
        void slider()
        {
            close.Start();
        }
        //private void MenuSlider_Tick_1(object sender, EventArgs e)
        //{
        //    if (sidebarExpand)
        //    {
        //        menuBar.Width -= 10;
        //        if (menuBar.Width <= 60)
        //        {
        //            sidebarExpand = false;
        //            MenuSlider.Stop();
        //        }
        //    }
        //    else
        //    {
        //        menuBar.Width += 10;
        //        if (menuBar.Width >= 229)
        //        {
        //            sidebarExpand = true;
        //            MenuSlider.Stop();
        //        }
        //    }
        //}
        //private void close_Tick_1(object sender, EventArgs e)
        //{
        //    if (sidebarExpand)
        //    {
        //        menuBar.Width -= 10;
        //        if (menuBar.Width <= 60)
        //        {
        //            sidebarExpand = false;
        //            close.Stop();
        //        }
        //    }
        //}
        private void menuButton_Click(object sender, EventArgs e)
        {
            //MenuSlider.Start();
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
            Books.FlatAppearance.BorderColor = Color.Red;

        }
        private void Student_Click(object sender, EventArgs e)
        {

            StudentManagementMenuSlider.Start();
            Student.FlatAppearance.BorderColor = Color.Red;
        }
        private void Dashboard_Click(object sender, EventArgs e)
        {
            dashboard1.countOfAllrecods();
            dashboard1.Show();
            dashboard1.BringToFront();
        }
        private void Trsnsaction_Click(object sender, EventArgs e)
        {

            TransactionManagementMenuSlider.Start();
            Transaction.FlatAppearance.BorderColor = Color.Red;

        }

        private void Setting_Click(object sender, EventArgs e)
        {

            settingBoard1.notshow();
            settingBoard1.Show();
            settingBoard1.BringToFront();
        }

        //private void Home_Load(object sender, EventArgs e)
        //{
        //    string connectionString = GetConnectionString();
        //    if (connectionString != null)
        //    {
        //        using (SqlConnection con = new SqlConnection(connectionString))
        //        {
        //            string Homepagelogo = "select logo from librarysetting where  id=" + 2 + "";
        //            try
        //            {
        //                con.Open();
        //                SqlCommand cmd = new SqlCommand(Homepagelogo, con);
        //                SqlDataReader reader = cmd.ExecuteReader();
        //                if (reader.Read())
        //                {
        //                    string photoPath = reader["logo"].ToString();

        //                    if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
        //                    {
        //                        byte[] imageBytes = File.ReadAllBytes(photoPath);
        //                        using (MemoryStream ms = new MemoryStream(imageBytes))
        //                        {
        //                            HomeLogo.BackgroundImage = Image.FromStream(ms);
        //                            HomeLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        HomeLogo.BackgroundImage = null;
        //                    }
        //                }


        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);

        //            }
        //        }

        //    }
        //}

        bool subMenuButtonExpand = false;

        private void BookManagementMenuSlider_Tick_1(object sender, EventArgs e)
        {
            if (subMenuButtonExpand == false)
            {
                Abc.Height += 10;
                if (Abc.Height >= 165)
                {
                    StudentMenuPanel.Height = 65;
                    TransactionMenuePanel.Height = 65;
                    BookManagementMenuSlider.Stop();
                    subMenuButtonExpand = true;
                }
            }
            else
            {
                Books.FlatAppearance.BorderColor = Color.Black;
                Abc.Height -= 10;
                if (Abc.Height <= 65)
                {
                    BookManagementMenuSlider.Stop();
                    subMenuButtonExpand = false;
                }
            }
        }

        private void StudentManagementMenuSlider_Tick(object sender, EventArgs e)
        {
            if (subMenuButtonExpand == false)
            {
                StudentMenuPanel.Height += 10;
                if (StudentMenuPanel.Height >= 165)
                {
                    Abc.Height = 65;
                    TransactionMenuePanel.Height = 65;
                    StudentManagementMenuSlider.Stop();
                    subMenuButtonExpand = true;
                }
            }
            else
            {
                Student.FlatAppearance.BorderColor = Color.Black;
                StudentMenuPanel.Height -= 10;
                if (StudentMenuPanel.Height <= 65)
                {
                    StudentManagementMenuSlider.Stop();
                    subMenuButtonExpand = false;
                }
            }
        }

        private void TransactionManagementMenuSlider_Tick(object sender, EventArgs e)
        {
            if (subMenuButtonExpand == false)
            {

                TransactionMenuePanel.Height += 10;
                if (TransactionMenuePanel.Height >= 219)
                {
                    Abc.Height = 65;
                    StudentMenuPanel.Height = 65;
                    TransactionManagementMenuSlider.Stop();
                    subMenuButtonExpand = true;
                }
            }
            else
            {
                Transaction.FlatAppearance.BorderColor = Color.Black;
                TransactionMenuePanel.Height -= 10;
                if (TransactionMenuePanel.Height <= 65)
                {

                    TransactionManagementMenuSlider.Stop();
                    subMenuButtonExpand = false;
                }
            }
        }

        private void AddBookPageOpen_Click(object sender, EventArgs e)
        {
            addBook1.Show();
            addBook1.BringToFront();

        }

        private void ViewBookPageOpen_Click(object sender, EventArgs e)
        {
            viewBook1.LoadBooks();
            viewBook1.Show();
            viewBook1.BringToFront();
        }

        private void AddStudentPageOpen_Click(object sender, EventArgs e)
        {
            addStudent1.Show();
            addStudent1.BringToFront();
        }

        private void ViewStudentPageOpen_Click(object sender, EventArgs e)
        {
            viewStudent1.viewStudentDetail();
            viewStudent1.Show();
            viewStudent1.BringToFront();

        }


        private void ViewIssuedPageOpen_Click(object sender, EventArgs e)
        {
            viewTransaction1.viewIssuedBook();
            viewTransaction1.Show();
            viewTransaction1.BringToFront();
        }

        private void ReturnPageOpen_Click(object sender, EventArgs e)
        {
            returnBook1.Show();
            returnBook1.BringToFront();
        }

        private void issuePageopen_Click(object sender, EventArgs e)
        {
            searchBooks1.viewfunction();
            searchBooks1.showBookDetail1.Hide();
            searchBooks1.Show();
            searchBooks1.BringToFront();
        }

        private void Setting_MouseHover(object sender, EventArgs e)
        {
            Setting.Text = "  Setting";
        }

        private void Setting_MouseLeave(object sender, EventArgs e)
        {
            Setting.Text = "";
        }

        private void Logout_MouseHover(object sender, EventArgs e)
        {
            Logout.Text = "Logout";
        }

        private void Logout_MouseLeave(object sender, EventArgs e)
        {
            Logout.Text = "";
        }

        private void Bin_MouseHover(object sender, EventArgs e)
        {
            Bin.Text = " Bin";
        }

        private void Bin_MouseLeave(object sender, EventArgs e)
        {
            Bin.Text = "";
        }

        private void Bin_Click_1(object sender, EventArgs e)
        {
            bin1.showBookRelatedDeletedItem();
            bin1.showStudentRelatedDeletedItem();
            bin1.Show();
            bin1.BringToFront();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            if (LoginForm.Names == "Userlogin")
            {
                login.Show();
            }
            else
            {

                login.ForgotPassword.Visible = true;
                login.CreateNewAccount.Visible = true;
                login.Show();
            }
           
        }

        private void close_Tick(object sender, EventArgs e)
        {
            if (Abc.Height==219 || StudentMenuPanel.Height==219 || TransactionMenuePanel.Height==219)
            {

            }
        }
    }
}
