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

namespace Library.Management.Staff
{
    public partial class AddStaff : UserControl
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public string staffImgPath = string.Empty;
        public AddStaff()
        {
            InitializeComponent();
        }
        private void uploadStaff_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDilog = new OpenFileDialog();
                fileDilog.Filter = "Image Files(*.jpg;*.png)|*.jpg;*.png";
                if (fileDilog.ShowDialog() == DialogResult.OK)
                {
                    staffImgPath = fileDilog.FileName;
                    AddStudent_picture.ImageLocation = staffImgPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("1", ex.Message);
            }
        }

        private void AddStaffInDBO_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string AddStaff = "INSERT INTO STAFFINFORMATION VALUES(@EmployeeId, @memberName,@Designation, @FatherName, @MotherName, @StudentImage, @Department, @Contact, @Email, @Address, @StaffStatus)";
                    try
                    {
                        con.Open();

                        //---/Uploads/Student/Enrollno_akanksha_Mishra.jpg
                        string path = Path.Combine("Uploads", "Staff", EmployeeId.Text + "_" + MemberName.Text.Replace(" ", "_") + "_" + ".jpg");

                        string directoryPath = Path.GetDirectoryName(path);
                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        if (staffImgPath != string.Empty)
                        {
                            File.Copy(staffImgPath, path, true);
                        }

                        SqlCommand cmd = new SqlCommand(AddStaff, con);
                        cmd.Parameters.AddWithValue("@EmployeeId", EmployeeId.Text);
                        cmd.Parameters.AddWithValue("@memberName", MemberName.Text);
                        cmd.Parameters.AddWithValue("@Designation", Designation.Text);
                        cmd.Parameters.AddWithValue("@FatherName", FatherName.Text);
                        cmd.Parameters.AddWithValue("@MotherName", MotherName.Text);
                        cmd.Parameters.AddWithValue("@StudentImage", path);
                        cmd.Parameters.AddWithValue("@Department", Department.Text);
                        cmd.Parameters.AddWithValue("@Contact", Contact.Text);
                        cmd.Parameters.AddWithValue("@Email", Email.Text);
                        cmd.Parameters.AddWithValue("@Address", Address.Text);
                        cmd.Parameters.AddWithValue("@StaffStatus", "Retained");
                        int isValueInsert = cmd.ExecuteNonQuery();
                        if (isValueInsert >= 1)
                        {
                            MessageBox.Show("Staff information added successfully");
                            AddStudent_picture.ImageLocation = "";
                            EmployeeId.Clear();
                            MemberName.Clear();
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
                        MessageBox.Show("Please upload the image of staff.", ex.Message);
                    }
                }
            }
        }
    }
}
