using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library.StudentManagement
{
    public partial class UpdateStudent : UserControl
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public UpdateStudent()
        {
            InitializeComponent();
        }
        public DataTable booksTable = new DataTable();
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            int sno = 0;
            sno = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string updateStudentDetail = "UPDATE StudentInformation SET EnrollmentNumber = @Enrollment, StudentName = @name, FatherName = @Father, MotherName = @Mother, Department = @Department,Contact = @Contact, Email = @Email,Address = @Address Where Id = "+sno+" " ;
                    MessageBox.Show(sno.ToString());
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(updateStudentDetail, con);
                        cmd.Parameters.AddWithValue("@Enrollment", EnrollBox.Text);
                        cmd.Parameters.AddWithValue("@name",StudentName.Text);
                        cmd.Parameters.AddWithValue("@Father", Father.Text);
                        cmd.Parameters.AddWithValue("@Mother", Mother.Text);
                        cmd.Parameters.AddWithValue("@Department", Department.Text);
                        cmd.Parameters.AddWithValue("@Contact",Contact.Text);
                        cmd.Parameters.AddWithValue("@Email", Email.Text);
                        cmd.Parameters.AddWithValue("@Address", Address.Text);
                        
                        int i = cmd.ExecuteNonQuery();
                        if (i >= 1)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (Convert.ToInt32(row.Cells["Id"].Value) == sno)
                                {
                                    // Update the corresponding cells in the selected row
                                    row.Cells["EnrollmentNumber"].Value = EnrollBox.Text;
                                    row.Cells["StudentName"].Value =StudentName.Text;
                                    row.Cells["FatherName"].Value = Father.Text;
                                    row.Cells["MotherName"].Value = Mother.Text;
                                    row.Cells["Department"].Value = Department.Text;
                                    row.Cells["Contact"].Value =Contact.Text;
                                    row.Cells["Email"].Value = Email.Text;
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
                        MessageBox.Show("1",ex.Message);
                    }
                }
            }
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            EnrollBox.Enabled = false;
            StudentName.Enabled = false;    
            Father.Enabled = false;
            Department.Enabled = false;
            Contact.Enabled = false;
            Address.Enabled = false;
            Email.Enabled = false;
            Mother.Enabled = false;

            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string viewdata = "SELECT Id, EnrollmentNumber, StudentName, FatherName, MotherName, Department, Contact,Email, Address FROM STUDENTINFORMATION;";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(viewdata, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        booksTable.Load(reader);
                        dataGridView1.DataSource = booksTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("2",ex.Message);
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EnrollBox.Enabled = true;
            StudentName.Enabled = true;
            Father.Enabled = true;
            Department.Enabled = true;
            Contact.Enabled = true;
            Address.Enabled = true;
            Email.Enabled = true;
            Mother.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                EnrollBox.Text = selectedRow.Cells[1].Value.ToString();
                StudentName.Text = selectedRow.Cells[2].Value.ToString();
                Father.Text = selectedRow.Cells[3].Value.ToString();
                Mother.Text = selectedRow.Cells[4].Value.ToString();
                Department.Text = selectedRow.Cells[5].Value.ToString();
                Contact.Text = selectedRow.Cells[6].Value.ToString();
                Email.Text = selectedRow.Cells[7].Value.ToString();
                Address.Text = selectedRow.Cells[8].Value.ToString();
            }

        }
    }
}
