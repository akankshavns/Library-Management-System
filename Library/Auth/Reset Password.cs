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
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;

namespace Library.Auth
{
    public partial class Reset_Password : Form
    {
        string RandomCode;
        public static string to;
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public Reset_Password()
        {
            InitializeComponent();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string SearchEmail = "SELECT COUNT(*) FROM AdminTable WHERE Email = @mail";
                    try
                    {
                        con.Open();
                        SqlCommand cmd= new SqlCommand(SearchEmail, con);
                        cmd.Parameters.AddWithValue("@mail",mailAddress.Text);
                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            string From, pass, MessageBody;
                            Random random = new Random();
                            RandomCode = (random.Next(999999).ToString());
                            MailMessage message = new MailMessage();
                            to=(mailAddress.Text).ToString();
                            From = "makanksha@gmail.com";
                            pass = "";
                            MessageBody = "your Reset OTP is " + RandomCode;
                            message.To.Add(to);
                            message.From = new MailAddress(From);
                            message.Body= MessageBody;
                            message.Subject = "Password Reseting Code";
                            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                            smtp.EnableSsl = true;
                            smtp.Port = 587;
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtp.Credentials = new NetworkCredential(From, pass);
                            try
                            {
                                smtp.Send(message);
                                MessageBox.Show("OTP send successfully");
                            }
                            catch (Exception ex) 
                            { 
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        { 
                            MessageBox.Show("no record found.");
                        }
                    }
                    catch (Exception ex)
                    { 
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
