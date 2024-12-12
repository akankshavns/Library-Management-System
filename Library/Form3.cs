using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form3 : Form
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public Form3()
        {
            InitializeComponent();
        }
       

        private async void btnDownload_Click_1(object sender, EventArgs e)
        {
            string googleSheetUrl = "https://docs.google.com/spreadsheets/d/1lOMJPIyExAI43576ybDJfqfAiplKsYzv3ZyCswkdYZs/export?format=csv";

            if (string.IsNullOrWhiteSpace(googleSheetUrl))
            {
                MessageBox.Show("Please enter a valid Google Sheet URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(googleSheetUrl);
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
                        List<string> dataList = row.Split(new[] {","}, StringSplitOptions.None).ToList();
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
                                string AddStudentInfo = "INSERT INTO STUDENTINFORMATION(EnrollmentNumber,StudentName, FatherName, MotherName, StudentPhoto, Department, Contact, Email, Address, StudentStatus) VALUES(@Enrollment, @StudentName, @FatherName, @MotherName, @StudentImage, @Department, @Contact, @Email, @Address, @StudentStatus)";
                                try
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