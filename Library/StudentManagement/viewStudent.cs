using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.StudentManagement
{
    public partial class viewStudent : UserControl
    {
        public viewStudent()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }
    }
}
