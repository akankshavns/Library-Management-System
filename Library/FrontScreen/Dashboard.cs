using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library.FrontScreen
{
    public partial class Dashboard : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=True");
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {con.Open();
                SqlCommand cmd = new SqlCommand();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 

            }
        }
    }
}
