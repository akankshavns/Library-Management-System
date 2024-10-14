using Library.TransactionManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Management.Setting
{
    public partial class Transaction : UserControl
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public Transaction()
        {
            InitializeComponent();
        }
        public void getValueFromDB()
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    String Fine, issuedBook, returnDays;
                    string setValue = "Select * from TransactionSetting";
                    try 
                    {
                        con.Open();
                        SqlCommand cmd =new SqlCommand(setValue, con);
                        SqlDataReader rdr = cmd.ExecuteReader();
                        if (rdr.Read()) 
                        {
                             Fine = rdr.GetValue(1).ToString();  
                             issuedBook = rdr.GetValue(2).ToString();
                            returnDays = rdr.GetValue(3).ToString();
                            EnterFine.Text = Fine;
                            IssuedBook.Text = issuedBook;
                            ReturnDays.Text = returnDays;
                        }
                        

                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            getValueFromDB();
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string changeSetting = "UPDATE TRANSACTIONSETTING SET FINE = @fine,NUMBEROFISSUEDBOOK =@issuedbook, RETURNDAYS = @returndays WHERE ID = "+1+"";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(changeSetting, con);
                        cmd.Parameters.AddWithValue("@fine", EnterFine.Text);
                        cmd.Parameters.AddWithValue("@issuedbook", IssuedBook.Text);
                        cmd.Parameters.AddWithValue("@returndays",ReturnDays.Text);
                        int i =cmd.ExecuteNonQuery();
                        if (i >= 1) { MessageBox.Show("successfull"); }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }
    }
}
