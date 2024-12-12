using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Library.Management.Student;


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
                MessageBox.Show("1", ex.Message);
            }
        }
        public bool hasErrors = false;

        private void AddStudentInDBO_Click(object sender, EventArgs e)
        {
            check();
            if (hasErrors == false)
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string AddStudent = "INSERT INTO STUDENTINFORMATION VALUES(@Enrollment, @StudentName, @FatherName, @MotherName, @StudentImage, @Department, @Contact, @Email, @Address, @StudentStatus)";
                        try
                        {
                            con.Open();

                            //---/Uploads/Student/Enrollno_akanksha_Mishra.jpg
                            string path = Path.Combine("Uploads", "Student", EnrollmentNo.Text + "_" + StudentName.Text.Replace(" ", "_") + "_" + ".jpg");

                            string directoryPath = Path.GetDirectoryName(path);
                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            if (studentImgPath != string.Empty)
                            {
                                File.Copy(studentImgPath, path, true);
                            }

                            SqlCommand cmd = new SqlCommand(AddStudent, con);
                            cmd.Parameters.AddWithValue("@Enrollment", EnrollmentNo.Text);
                            cmd.Parameters.AddWithValue("@StudentName", StudentName.Text);
                            cmd.Parameters.AddWithValue("@FatherName", FatherName.Text);
                            cmd.Parameters.AddWithValue("@MotherName", MotherName.Text);
                            cmd.Parameters.AddWithValue("@StudentImage", path);
                            cmd.Parameters.AddWithValue("@Department", Department.Text);
                            cmd.Parameters.AddWithValue("@Contact", Contact.Text);
                            cmd.Parameters.AddWithValue("@Email", Email.Text);
                            cmd.Parameters.AddWithValue("@Address", Address.Text);
                            cmd.Parameters.AddWithValue("@StudentStatus", "Retained");
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
                                Contact.Clear();
                                Address.Clear();
                                Email.Clear();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Please upload the image of student.", ex.Message);
                        }
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

            if (Contact.Text.Length > 10)
            {
                Contact.Text = Contact.Text.Substring(0, 10);
                Contact.SelectionStart = Contact.Text.Length;
            }
            if (Contact.Text.Length == 10)
            {
                ContactNumbercheck.SetError(Contact, "");
            }
        }
        public void check()
        {

            if (string.IsNullOrEmpty(Contact.Text))
            {
                CheckContact.SetError(Contact, "This field is required");
                hasErrors = true;
            }
            if (string.IsNullOrEmpty(EnrollmentNo.Text))
            {
                EnrollmentCheck.SetError(EnrollmentNo, "This field is required");
                hasErrors = true;
            }
            if (string.IsNullOrEmpty(StudentName.Text))
            {
                StudentCheck.SetError(StudentName, "This field is required");
                hasErrors = true;
            }
            if (string.IsNullOrEmpty(FatherName.Text))
            {
                FatherNameCheck.SetError(FatherName, "This field is required");
                hasErrors = true;
            }
            if (string.IsNullOrEmpty(MotherName.Text))
            {
                MotherNameCheck.SetError(MotherName, "This field is required");
                hasErrors = true;
            }
            if (string.IsNullOrEmpty(Department.Text))
            {
                DepartmentCheck.SetError(Department, "This field is required");
                hasErrors = true;
            }
            if (string.IsNullOrEmpty(Email.Text))
            {
                EmailCheck.SetError(Email, "This field is required");
                hasErrors = true;
            }
            if (string.IsNullOrEmpty(Address.Text))
            {
                AddressCheck.SetError(Address, "This field is required");
                hasErrors = true;
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
            Contact.Clear();
            Address.Clear();
            Email.Clear();
        }

        private void EnrollmentNo_TextChanged(object sender, EventArgs e)
        {
            EnrollmentCheck.SetError(EnrollmentNo, "");
            hasErrors = false;
        }

        private void StudentName_TextChanged(object sender, EventArgs e)
        {
            StudentCheck.SetError(StudentName, "");
            hasErrors = false;
        }

        private void FatherName_TextChanged(object sender, EventArgs e)
        {
            FatherNameCheck.SetError(FatherName, "");
            hasErrors = false;
        }

        private void MotherName_TextChanged(object sender, EventArgs e)
        {
            MotherNameCheck.SetError(MotherName, "");
            hasErrors = false;
        }

        private void Department_TextChanged(object sender, EventArgs e)
        {
            DepartmentCheck.SetError(Department, "");
            hasErrors = false;
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            EmailCheck.SetError(Email, "");
            hasErrors = false;
        }
        private void Address_TextChanged(object sender, EventArgs e)
        {
            AddressCheck.SetError(Address, "");
            hasErrors = false;
        }

        private void Email_Validating(object sender, CancelEventArgs e)
        {
            // Regular expression pattern for a valid email address
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Check if the email matches the pattern
            if (!Regex.IsMatch(Email.Text, pattern))
            {
                EmailCheck.SetError(Email, "Invalid email format");
                e.Cancel = true;
            }
            else
            {
                EmailCheck.SetError(Email, "");
            }
        }

        private void DataFromGooleForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form dialogForm = new Form
            {
                Text = "Scan me!",
                Size = new Size(695, 500), // Adjust the size to fit your UserControl
                StartPosition = FormStartPosition.CenterParent, // Center the dialog on the parent form
                FormBorderStyle = FormBorderStyle.FixedDialog, // Prevent resizing
                MaximizeBox = false,
                MinimizeBox = false
            };
            GoogleFormData googleFormData = new GoogleFormData
            {
                Dock = DockStyle.Fill 
            };
            dialogForm.Controls.Add(googleFormData);

            dialogForm.ShowDialog();


        }
    }
}

