using Library.BookManagement;
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
    public partial class TransactionBoard : UserControl
    {
        
        public TransactionBoard()
        {
            InitializeComponent();
        }
        public void notshow()
        {
            issueBook1.Visible = false;
            returnBook1.Visible = false;
            viewTransaction1.Visible = false;
        }

        private void issue_Click_1(object sender, EventArgs e)
        {
            issueBook1.Show();
            issueBook1.BringToFront();
        }

        private void Return_Click_1(object sender, EventArgs e)
        {
            returnBook1.Show();
            returnBook1.BringToFront();
        }

        private void IssueList_Click_1(object sender, EventArgs e)
        {
            viewTransaction1.Show();
            viewTransaction1.BringToFront();
        }
    }
}
