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
    public partial class BookBoard : UserControl
    {
        public BookBoard()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            addBook1.Show();
            addBook1.BringToFront();
        }

        private void view_Click(object sender, EventArgs e)
        {
            viewBook1.Show();
            viewBook1.BringToFront();
        }

        private void update_Click(object sender, EventArgs e)
        {
            update1.Show();
            update1.BringToFront();
        }
    }
}
