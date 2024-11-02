using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
        DataTable booksTable = new DataTable();

        private void viewStudent_Load(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string viewdata = "SELECT ID,EnrollmentNumber, StudentName, FatherName, MotherName, Department, Contact,Email, Address FROM STUDENTINFORMATION;";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(viewdata, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        booksTable.Load(reader);
                        StudentDetailView.DataSource = booksTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("2", ex.Message);
                    }
                }
            }
        }
       
        private void StudentDetailView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = StudentDetailView.Rows[e.RowIndex];
                Enroll.Text = selectedRow.Cells[1].Value.ToString();
                SName.Text = selectedRow.Cells[2].Value.ToString();
                FatherName.Text = selectedRow.Cells[3].Value.ToString();
                MotherName.Text = selectedRow.Cells[4].Value.ToString();
                Department.Text = selectedRow.Cells[5].Value.ToString();
                contact.Text = selectedRow.Cells[6].Value.ToString();
                mail.Text = selectedRow.Cells[7].Value.ToString();
                Address.Text = selectedRow.Cells[8].Value.ToString();
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string studentInfo = "select Studentphoto From StudentInformation where EnrollmentNumber = @Enrollment";
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand(studentInfo, con);
                            cmd.Parameters.AddWithValue("@Enrollment", Enroll.Text);
                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
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

        private void updateSectionButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to update this student's records?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
              

            if (result == DialogResult.Yes)
            {
                Enroll.Enabled = true;
                SName.Enabled = true;
                FatherName.Enabled = true;
                Department.Enabled = true;
                contact.Enabled = true;
                Address.Enabled = true;
                mail.Enabled = true;
                MotherName.Enabled = true;
                UpdateDetails.Visible= true;
                UpdateImage.Visible= true;
            }
            else
            {
                // Optional: Code if the update is canceled
                MessageBox.Show("Update canceled.");
            }
        }
       public void UpdateStudentRecords()
        {
            int sno = 0;
            sno = Convert.ToInt32(StudentDetailView.SelectedCells[0].Value.ToString());
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string updateStudentDetail = "UPDATE StudentInformation SET EnrollmentNumber = @Enrollment, StudentName = @name, FatherName = @Father, MotherName = @Mother, Department = @Department,Contact = @Contact, Email = @Email,Address = @Address Where Id = " + sno + " ";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(updateStudentDetail, con);
                        cmd.Parameters.AddWithValue("@Enrollment", Enroll.Text);
                        cmd.Parameters.AddWithValue("@name", SName.Text);
                        cmd.Parameters.AddWithValue("@Father", FatherName.Text);
                        cmd.Parameters.AddWithValue("@Mother", MotherName.Text);
                        cmd.Parameters.AddWithValue("@Department", Department.Text);
                        cmd.Parameters.AddWithValue("@Contact", contact.Text);
                        cmd.Parameters.AddWithValue("@Email", mail.Text);
                        cmd.Parameters.AddWithValue("@Address", Address.Text);

                        int i = cmd.ExecuteNonQuery();
                        if (i >= 1)
                        {
                            foreach (DataGridViewRow row in StudentDetailView.Rows)
                            {
                            if (Convert.ToInt32(row.Cells["Id"].Value) ==sno)
                                {
                                // Update the corresponding cells in the selected row
                                row.Cells["EnrollmentNumber"].Value = Enroll.Text;
                                    row.Cells["StudentName"].Value = SName.Text;
                                    row.Cells["FatherName"].Value = FatherName.Text;
                                    row.Cells["MotherName"].Value = MotherName.Text;
                                    row.Cells["Department"].Value = Department.Text;
                                    row.Cells["Contact"].Value = contact.Text;
                                    row.Cells["Email"].Value = mail.Text;
                                    row.Cells["Address"].Value = Address.Text;
                                    break;
                                }
                            }
                            MessageBox.Show("updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("something went wrong");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("1", ex.Message);
                    }
                }
            }
        }

        private void UpdateDetails_Click(object sender, EventArgs e)
        {
            UpdateStudentRecords();
        }

        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            DataView dv = booksTable.DefaultView;
            dv.RowFilter = $"EnrollmentNumber LIKE '%{SearchBox.Text}%' OR StudentName LIKE '%{SearchBox.Text}%'";
            StudentDetailView.DataSource = dv.ToTable();
        }

        private void mail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Regular expression pattern for a valid email address
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Check if the email matches the pattern
            if (!Regex.IsMatch(mail.Text, pattern))
            {
                MailCheck.SetError(mail, "Invalid email format");
                e.Cancel = true;
            }
            else
            {
                MailCheck.SetError(mail, "");
            }
        }
    }
}


