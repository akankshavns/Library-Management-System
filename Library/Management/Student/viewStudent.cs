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

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select*From StudentInformation where EnrollmentNumber like('%" + textBox1.Text + "%') and StudentName like('%" + textBox2.Text + "%')";
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Enroll.Text = dr["EnrollmentNumber"].ToString();
                    SName.Text = dr["StudentName"].ToString();
                    Rollno.Text = dr["RollNumber"].ToString();
                    Department.Text = dr["Department"].ToString();
                    semester.Text = dr["Semester"].ToString();
                    contact.Text = dr["Contact"].ToString();
                    mail.Text = dr["Email"].ToString();
                    Address.Text = dr["Address"].ToString();
                    string photoPath = dr["StudentPhoto"].ToString();
                    if (!string.IsNullOrEmpty(photoPath) && System.IO.File.Exists(photoPath))
                    {
                        image.Image = Image.FromFile(photoPath);
                        image.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        image.Image=null;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
    
}
