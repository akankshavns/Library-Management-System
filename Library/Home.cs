using Library.Board;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{

    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
           
        }

        
        
        bool sidebarExpand = false;

      
        void slider()
        {
            close.Start();
        }
       
        

        private void MenuSlider_Tick_1(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                menuBar.Width -= 10;
                if (menuBar.Width <= 60)
                {
                    sidebarExpand = false;
                    MenuSlider.Stop();
                }
            }
            else
            {
                menuBar.Width += 10;
                if (menuBar.Width >= 192)
                {
                    sidebarExpand = true;
                    MenuSlider.Stop();
                }

            }
        }

        private void close_Tick_1(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                menuBar.Width -= 10;
                if (menuBar.Width <= 60)
                {
                    sidebarExpand = false;
                    close.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            MenuSlider.Start();
        }

        private void logOut_Click_1(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        

        

       

        private void Books_Click_1(object sender, EventArgs e)
        {
            bookBoard1.Show();
            bookBoard1.BringToFront();

        }


        private void Student_Click(object sender, EventArgs e)
        {
            studentBoard1.Show();
            studentBoard1.BringToFront();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            dashboard1.Show();
            dashboard1.BringToFront();
        }

        private void Trsnsaction_Click(object sender, EventArgs e)
        {
            transactionBoard1.Show();
            transactionBoard1.BringToFront();
        }

        
    }
}
