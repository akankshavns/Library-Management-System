using Library.BookManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        public void notshow()
        {
            addStudent1.Visible = false;
            viewStudent1.Visible = false;
            updateStudent1.Visible = false;
        }
        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            addStudent1.Show();
            addStudent1.BringToFront();
        }
        private void viewStudentbutton_Click(object sender, EventArgs e)
        {
            viewStudent1.Show();
            viewStudent1.BringToFront();
        }
        private void updateStudentbutton_Click(object sender, EventArgs e)
        {
            updateStudent1.Show();
            updateStudent1.BringToFront();
        }
    }
}
