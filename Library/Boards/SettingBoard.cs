using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Board
{
    public partial class SettingBoard : UserControl
    {
       
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public SettingBoard()
        {
            InitializeComponent();
           
        }
        public void notshow()
        {
            library1.Visible = false;
            transaction1.Visible = false;
        }
       
        private void Transaction_Click(object sender, EventArgs e)
        {
            library1.Visible = false;
           transaction1.getValueFromDB();
            transaction1.Visible = true;
            transaction1.BringToFront();
        }

        private void TransactionDetail_Click(object sender, EventArgs e)
        {
            library1.Visible = false;
            transaction1.Visible = true;
            transaction1.BringToFront();
        }

        private void LibraryDetail_Click(object sender, EventArgs e)
        {
            transaction1.Visible=false;
            library1.Visible = true;
            library1.BringToFront();
        }

        private void Library_Click(object sender, EventArgs e)
        {
            transaction1.Visible = false;
            library1.Visible = true;
            library1.BringToFront();
        }
    }
}
