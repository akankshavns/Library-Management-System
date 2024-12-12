using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Management.Student
{
    public partial class GoogleFormData : UserControl
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public GoogleFormData()
        {
            InitializeComponent();
        }

        private void ScannerSelection_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ScannerSelection.SelectedItem?.ToString() == "Student")
            {
                ScannerBox.BackgroundImage = Properties.Resources.StudentQR;
                GetData.Text = "Get Student Data";
                MessageBox.Show("Operation completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ScannerSelection.SelectedItem?.ToString() == "Staff")
            {
                ScannerBox.BackgroundImage = Properties.Resources.StaffQR;
                GetData.Text = "Get Staff Data";
                MessageBox.Show("Operation completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a valid option!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private async void GetData_Click(object sender, EventArgs e)
        {
            string googleSheetUrlForStudent = "https://docs.google.com/spreadsheets/d/1lOMJPIyExAI43576ybDJfqfAiplKsYzv3ZyCswkdYZs/export?format=csv";

            if (ScannerSelection.SelectedItem?.ToString() == "Student")
            {
                if (string.IsNullOrWhiteSpace(googleSheetUrlForStudent))
                {
                    MessageBox.Show("Please enter a valid Google Sheet URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response = await client.GetAsync(googleSheetUrlForStudent);
                        response.EnsureSuccessStatusCode();
                        string csvContent = await response.Content.ReadAsStringAsync();
                        List<string> csvRowList = csvContent.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

                        int loopNumber = 0;
                        foreach (string row in csvRowList)
                        {
                            if (loopNumber == 0)
                            {
                                loopNumber++;
                                continue;
                            }
                            List<string> dataList = row.Split(new[] { "," }, StringSplitOptions.None).ToList();
                            string EnrollmentNumber = dataList[1];
                            string Email = dataList[2];
                            string StudentName = dataList[3];
                            string FatherName = dataList[4];
                            string MotherName = dataList[5];
                            string Department = dataList[6];
                            string StudentImageDriveLink = dataList[7];

                            string fileId = StudentImageDriveLink.Split('=')[1];
                            string StudentImagePath = Path.Combine("Uploads", "Student", EnrollmentNumber + "_" + StudentName.Replace(" ", "_") + "_" + ".jpg");
                            await RetrieveImageFromGoogleDrive(fileId, StudentImagePath);
                            string ContactNumber = dataList[8];
                            string Address = dataList[9];

                            string connectionString = GetConnectionString();
                            if (connectionString != null)
                            {
                                using (SqlConnection con = new SqlConnection(connectionString))
                                {
                                    string CheckQuerry = "select count(*) from StudentInformation where EnrollmentNumber = @enroll";
                                    string AddStudentInfo = "INSERT INTO STUDENTINFORMATION(EnrollmentNumber,StudentName, FatherName, MotherName, StudentPhoto, Department, Contact, Email, Address, StudentStatus) VALUES(@Enrollment, @StudentName, @FatherName, @MotherName, @StudentImage, @Department, @Contact, @Email, @Address, @StudentStatus)";
                                    try
                                    {
                                        con.Open();
                                        SqlCommand check = new SqlCommand(CheckQuerry, con);
                                        check.Parameters.AddWithValue("@enroll", EnrollmentNumber);
                                        int Exist = (int)check.ExecuteScalar();
                                        con.Close();
                                        if (Exist > 0)
                                        {
                                            MessageBox.Show("In the if");
                                            loopNumber++;
                                            continue;
                                        }
                                        else
                                        {
                                            con.Open();
                                            SqlCommand cmd = new SqlCommand(AddStudentInfo, con);
                                            cmd.Parameters.AddWithValue("@Enrollment", EnrollmentNumber);
                                            cmd.Parameters.AddWithValue("@StudentName", StudentName);
                                            cmd.Parameters.AddWithValue("@FatherName", FatherName);
                                            cmd.Parameters.AddWithValue("@MotherName", MotherName);
                                            cmd.Parameters.AddWithValue("@StudentImage", StudentImagePath);
                                            cmd.Parameters.AddWithValue("@Department", Department);
                                            cmd.Parameters.AddWithValue("@Contact", ContactNumber);
                                            cmd.Parameters.AddWithValue("@Email", Email);
                                            cmd.Parameters.AddWithValue("@Address", Address);
                                            cmd.Parameters.AddWithValue("@StudentStatus", "Retained");
                                            int isValueInsert = cmd.ExecuteNonQuery();
                                            if (isValueInsert >= 1)
                                            {
                                                MessageBox.Show("Student information added successfully");

                                            }
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }

                            loopNumber++;
                        }

                        MessageBox.Show($"Google Sheet data downloaded successfully!\nSaved to: {csvContent}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task RetrieveImageFromGoogleDrive(string driveFileId, string localPath)
        {
            using (HttpClient client = new HttpClient())
            {
                string Url = $"https://drive.google.com/uc?export=download&id={driveFileId}";
                HttpResponseMessage response = await client.GetAsync(Url);
                response.EnsureSuccessStatusCode();
                Stream image = await response.Content.ReadAsStreamAsync();

                string directoryPath = Path.GetDirectoryName(localPath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Save the image to the specified path
                using (FileStream fs = new FileStream(localPath, FileMode.CreateNew))
                {
                    await image.CopyToAsync(fs);
                }
            }
        }
    }
    
}
