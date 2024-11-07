using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Library.Auth
{
    public partial class CreateAnAccount : Form
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public CreateAnAccount()
        {
            InitializeComponent();
        }
        bool isUserAccount = false;
        private void CreateUserAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmpId.Clear();
            FirstName.Clear();
            lastName.Clear();
            Adhar.Clear();
            FName.Clear();
            Email.Clear();
            MobileNumber.Clear();
            UserName.Clear();
            Password.Clear();
            heading.Text = "Create User Account";
            isUserAccount = true;
        }

        private void CreateAdminAccount_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string AdminDetail = "Insert into AdminTable(EmployeeId, Name, LastName, fatherName, Email, Phone, AdharNo, UserName, Password,DateOfJoining)values(@id, @Name, @LastName, @fatherName, @Email, @phone, @Adhar, @userName, @password, @joinDate)";
                    string UserDetail = "Insert into Librarian(EmployeeId, Name, LastName, fatherName, Email, Phone, AdharNo, UserName, Password,DateOfJoining)values(@id, @Name, @LastName, @fatherName, @Email, @phone, @Adhar, @userName, @password, @joinDate)";
                    try
                    {
                        con.Open();
                        if (isUserAccount == false)
                        {
                            SqlCommand cmd = new SqlCommand(AdminDetail, con);
                            cmd.Parameters.AddWithValue("@id", EmpId.Text);
                            cmd.Parameters.AddWithValue("@Name", FirstName.Text);
                            cmd.Parameters.AddWithValue("@LastName", lastName.Text);
                            cmd.Parameters.AddWithValue("@fatherName", FName.Text);
                            cmd.Parameters.AddWithValue("@Email", Email.Text);
                            cmd.Parameters.AddWithValue("@Phone", MobileNumber.Text);
                            cmd.Parameters.AddWithValue("@Adhar", Adhar.Text);
                            cmd.Parameters.AddWithValue("@userName", UserName.Text);
                            cmd.Parameters.AddWithValue("@password", Password.Text);
                            cmd.Parameters.AddWithValue("@joinDate", DateOfJoining.Value);
                            
                            int isInsert = cmd.ExecuteNonQuery();
                            if (isInsert >= 1)
                            {
                                MessageBox.Show("Account Created Successfully");
                            }
                            con.Close();
                        }
                        if (isUserAccount == true)
                        {
                            con.Close();

                            SqlCommand cmd = new SqlCommand(UserDetail, con);
                            cmd.Parameters.AddWithValue("@id", EmpId.Text);
                            cmd.Parameters.AddWithValue("@Name", FirstName.Text);
                            cmd.Parameters.AddWithValue("@LastName", lastName.Text);
                            cmd.Parameters.AddWithValue("@fatherName", FName.Text);
                            cmd.Parameters.AddWithValue("@Email", Email.Text);
                            cmd.Parameters.AddWithValue("@Phone", MobileNumber.Text);
                            cmd.Parameters.AddWithValue("@Adhar", Adhar.Text);
                            cmd.Parameters.AddWithValue("@userName", UserName.Text);
                            cmd.Parameters.AddWithValue("@password", Password.Text);
                            cmd.Parameters.AddWithValue("@joinDate", DateOfJoining.Value);
                            con.Open();
                            int isInsert = cmd.ExecuteNonQuery();
                            if (isInsert >= 1)
                            {
                                MessageBox.Show("Account Created Successfully");
                            }
                            con.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Check if the email matches the pattern
            if (!Regex.IsMatch(Email.Text, pattern))
            {
                emailCheck.SetError(Email, "Invalid email format");
                e.Cancel = true;
            }
            else
            {
                emailCheck.SetError(Email, "");
            }
        }
    }
}
