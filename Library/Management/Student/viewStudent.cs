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

        DataTable StudentTable = new DataTable();
        private void viewStudent_Load(object sender, EventArgs e)
        {
            viewStudentDetail();
        }
       //logic of showing database data in the dataGridview.
        public void viewStudentDetail()
        {
            StudentTable.Clear();
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string viewdata = "SELECT ID,EnrollmentNumber, StudentName, FatherName, MotherName, Department, Contact,Email, Address FROM STUDENTINFORMATION where StudentStatus = 'Retained'";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(viewdata, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        StudentTable.Load(reader);
                        StudentDetailView.DataSource = StudentTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        //This piece of code help in showing the selected student detail in the text field with Student image.
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
        // This  piece of code Enable all the textBoxes for update the student data,when user click the 'yes' button of dialogBox.
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
                MessageBox.Show("Update canceled.");
            }
        }
        //This function is used to update the reords in the database.
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
                            // this is used for update only selected cell of the datagridview.
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
        // search the data according to Enrollment number and student name.
        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable booksTable = new DataTable();
            DataView dv = booksTable.DefaultView;
            dv.RowFilter = $"EnrollmentNumber LIKE '%{SearchBox.Text}%' OR StudentName LIKE '%{SearchBox.Text}%'";
            StudentDetailView.DataSource = dv.ToTable();
        }
        //check condition for Email inputBox
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
        // This is used to delete the single row  data from data Base.
        private void StudentDetailView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure? Do you want to delete this record?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                // Assume that `sno` is fetched from the selected cell in DataGridView
                int sno = Convert.ToInt32(StudentDetailView.Rows[e.RowIndex].Cells["ID"].Value);

                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string updateBookStatus = "UPDATE StudentInformation SET StudentStatus = @StudentStatus WHERE ID = @SNO";

                        using (SqlCommand cmd = new SqlCommand(updateBookStatus, con))
                        {
                            cmd.Parameters.AddWithValue("@StudentStatus", "Deleted");
                            cmd.Parameters.AddWithValue("@SNO", sno);

                            try
                            {
                                con.Open();
                                int updated = cmd.ExecuteNonQuery();
                                if (updated >= 1)
                                {
                                    viewStudentDetail();
                                    MessageBox.Show("Book deleted successfully.");

                                }
                                else
                                {
                                    MessageBox.Show("No record found with the specified SNO.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                    }
                }
            }
        }
    }
}


