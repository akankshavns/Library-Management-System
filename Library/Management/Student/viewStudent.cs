using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.StudentManagement
{
    public partial class viewStudent : UserControl
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public viewStudent()
        {
            InitializeComponent();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string studentInfo = "select*From StudentInformation where EnrollmentNumber = @Enrollment";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(studentInfo,con);
                        cmd.Parameters.AddWithValue("@Enrollment", Enrollment.Text);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Enroll.Text = dr["EnrollmentNumber"].ToString();
                            SName.Text = dr["StudentName"].ToString();
                            Department.Text = dr["Department"].ToString();
                            contact.Text = dr["Contact"].ToString();
                            mail.Text = dr["Email"].ToString();
                            Address.Text = dr["Address"].ToString();
                            string photoPath = dr["StudentPhoto"].ToString();
                            string absPath = Path.GetFullPath(photoPath);
                            if (!string.IsNullOrEmpty(photoPath) && System.IO.File.Exists(photoPath))
                            {
                                image.Image = Image.FromFile(photoPath);
                                image.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                            else
                            {
                                image.Image = null;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Records are not found");
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
