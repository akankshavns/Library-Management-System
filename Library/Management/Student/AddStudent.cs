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
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;
using System.Xml.Linq;

namespace Library.StudentManagement
{
    public partial class AddStudent : UserControl
    {
        public string studentImgPath = string.Empty;
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public AddStudent()
        {
            InitializeComponent();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
            ClearErrorProviderAndTextBox();
        }
        private void upload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDilog = new OpenFileDialog();
                fileDilog.Filter = "Image Files(*.jpg;*.png)|*.jpg;*.png";
                if (fileDilog.ShowDialog() == DialogResult.OK)
                {
                    studentImgPath = fileDilog.FileName;
                    AddStudent_picture.ImageLocation = studentImgPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("1",ex.Message);
            }
        }

        private void AddStudentInDBO_Click(object sender, EventArgs e)
        {
            check();

            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string AddStudent = "INSERT INTO STUDENTINFORMATION VALUES(@Enrollment, @StudentName, @FatherName, @MotherName, @StudentImage, @Department, @Contact, @Email, @Address)";
                    try
                    {
                        con.Open();

                        //---/Uploads/Student/Enrollno_Ayush_Mishra.jpg
                        string path = Path.Combine("Uploads", "Student", EnrollmentNo.Text + "_" + StudentName.Text.Replace(" ", "_") + "_" + ".jpg");

                        string directoryPath = Path.GetDirectoryName(path);
                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }
                        File.Copy(studentImgPath, path, true);
                        SqlCommand cmd = new SqlCommand(AddStudent, con);
                        cmd.Parameters.AddWithValue("@Enrollment",EnrollmentNo.Text);
                        cmd.Parameters.AddWithValue("@StudentName",StudentName.Text);
                        cmd.Parameters.AddWithValue("@FatherName",FatherName.Text);
                        cmd.Parameters.AddWithValue("@MotherName",MotherName.Text);
                        cmd.Parameters.AddWithValue("@StudentImage", path);
                        cmd.Parameters.AddWithValue("@Department",Department.Text);
                        cmd.Parameters.AddWithValue("@Contact",Contact.Text);
                        cmd.Parameters.AddWithValue("@Email",Email.Text);
                        cmd.Parameters.AddWithValue("@Address",Address.Text);
                        int isValueInsert = cmd.ExecuteNonQuery();
                        if (isValueInsert >= 1)
                        {
                            MessageBox.Show("Student information added successfully");
                            AddStudent_picture.ImageLocation = "";
                            EnrollmentNo.Clear();
                            StudentName.Clear();
                            FatherName.Clear();
                            MotherName.Clear();
                            Department.Clear();
                            Contact.Text="+91";
                            Address.Clear();
                            Email.Clear();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please upload the image of student.");
                    }
                }
            }

        }
        private void Contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Contact_TextChanged(object sender, EventArgs e)
        {
           
            CheckContact.SetError(Contact, "");
            if (Contact.Text.Length != 10)
            {
                ContactNumbercheck.SetError(Contact, "Contact number must be exactly 10 digits.");
            }
            if (Contact.Text.Length > 13)
            {
                Contact.Text = Contact.Text.Substring(0, 10);
                Contact.SelectionStart = Contact.Text.Length; 
            }
            if(Contact.Text.Length == 13)
            {
                ContactNumbercheck.SetError(Contact, "");
            }
        }
        public void check()
        {
            
            if (Contact.Text=="+91")
            {
                CheckContact.SetError(Contact, "This field is required");
            }
            if (string.IsNullOrEmpty(EnrollmentNo.Text))
            {
                EnrollmentCheck .SetError(EnrollmentNo, "This field is required");
            }
            if (string.IsNullOrEmpty(StudentName.Text))
            {
                StudentCheck.SetError(StudentName, "This field is required");
            }
            if (string.IsNullOrEmpty(FatherName.Text))
            {
                FatherNameCheck.SetError(FatherName, "This field is required");
            }
            if (string.IsNullOrEmpty(MotherName.Text))
            {
                MotherNameCheck.SetError(MotherName, "This field is required");
            }
            if (string.IsNullOrEmpty(Department.Text))
            {
                DepartmentCheck.SetError(Department, "This field is required");
            }
            if (string.IsNullOrEmpty(Email.Text))
            {
                EmailCheck.SetError(Email, "This field is required");
            }
            if (string.IsNullOrEmpty(Address.Text))
            {
                AddressCheck.SetError(Address, "This field is required");
            }
            
        }
        public void ClearErrorProviderAndTextBox()
        {
            EnrollmentCheck.SetError(EnrollmentNo, "");
            StudentCheck.SetError(StudentName, "");
            FatherNameCheck.SetError(FatherName, "");
            MotherNameCheck.SetError(MotherName, "");
            AddressCheck.SetError(Address, "");
            EmailCheck.SetError(Email, "");
            DepartmentCheck.SetError(Department, "");

            AddStudent_picture.ImageLocation = "";
            EnrollmentNo.Clear();
            StudentName.Clear();
            FatherName.Clear();
            MotherName.Clear();
            Department.Clear();
            Contact.Text = "+91";
            Address.Clear();
            Email.Clear();


        }

        private void EnrollmentNo_TextChanged(object sender, EventArgs e)
        {
            EnrollmentCheck.SetError(EnrollmentNo, "");
        }

        private void StudentName_TextChanged(object sender, EventArgs e)
        {
            StudentCheck.SetError(StudentName, "");
        }

        private void FatherName_TextChanged(object sender, EventArgs e)
        {
            FatherNameCheck.SetError(FatherName, "");
        }

        private void MotherName_TextChanged(object sender, EventArgs e)
        {
            MotherNameCheck.SetError(MotherName, "");
        }

        private void Department_TextChanged(object sender, EventArgs e)
        {
            DepartmentCheck.SetError(Department, "");
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            EmailCheck.SetError(Email, "");
        }
        private void Address_TextChanged(object sender, EventArgs e)
        {
            AddressCheck.SetError(Address, "");
        }
    }
}
