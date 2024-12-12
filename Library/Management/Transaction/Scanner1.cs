using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.TransactionManagement;

namespace Library.Management.Transaction
{
    public partial class Scanner1 : UserControl
    {
        public Scanner1()
        {
            InitializeComponent();
        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            ReturnBook.Return.Enabled = true;
            //To-do : how to close this contener dialog box of this control form
            ((Form)ParentForm).Close();
        }

        private void Cancelbutton2_Click(object sender, EventArgs e)
        {
            ((Form)ParentForm).Close();
        }
    }
}
