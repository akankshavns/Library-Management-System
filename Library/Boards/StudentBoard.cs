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
    public partial class StudentBoard : UserControl
    {
        public StudentBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            addStudent1.Show();
            addStudent1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewStudent1.Show();
            viewStudent1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateStudent1.Show();
            updateStudent1.BringToFront();
        }
    }
}
