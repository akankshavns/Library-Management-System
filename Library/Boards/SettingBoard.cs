using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Board
{
    public partial class SettingBoard : UserControl
    {
        public SettingBoard()
        {
            InitializeComponent();
        }
        private void AboutButton_Click(object sender, EventArgs e)
        {
            about1.Visible = true;
            about1.BringToFront();
        }

        private void AboutDetail_Click(object sender, EventArgs e)
        {
            about1.Visible = true;
            about1.BringToFront();
        }

        private void Account_Click(object sender, EventArgs e)
        {
           account1.Visible = true;
           account1.BringToFront();
        }

        private void AccountDetail_Click(object sender, EventArgs e)
        {
          account1.Visible = true;
           account1.BringToFront();
        }

        private void Library_Click(object sender, EventArgs e)
        {
            library1.Visible = true;
           library1.BringToFront();
        }

        private void LibraryDetail_Click(object sender, EventArgs e)
        {
           library1.Visible = true;
           library1.BringToFront();
        }

        private void Transaction_Click(object sender, EventArgs e)
        {
           transaction1.Visible = true;
           transaction1.BringToFront();
        }

        private void TransactionDetail_Click(object sender, EventArgs e)
        {
           transaction1.Visible = true;
           transaction1.BringToFront();
        }
    }
}
