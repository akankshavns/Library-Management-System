using System;
using System.Windows.Forms;

namespace Library.Auth
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            LoginForm loginPage = new LoginForm();
            loginPage.ForgotPassword.Visible = true;
            loginPage.CreateNewAccount.Visible = true;
            loginPage.Show();

        }

        private void user_Click(object sender, EventArgs e)
        {
            LoginForm loginPage = new LoginForm();
            loginPage.Show();

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
