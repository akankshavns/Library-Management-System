using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library.Boards
{
    public partial class Bin : UserControl
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public Bin()
        {
            InitializeComponent();
        }
       

        public void showBookRelatedDeletedItem()
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string viewdata = "SELECT * FROM AddBooks WHERE BookStatus = 'Deleted'";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(viewdata, con);
                        DataTable BookTable = new DataTable();
                        // Clear existing data in BookTable to avoid duplicates
                        BookTable.Clear();

                        SqlDataReader reader = cmd.ExecuteReader();
                        BookTable.Load(reader);
                        BookGridView1.DataSource = BookTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }



        public void showStudentRelatedDeletedItem()
        {

            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string viewdata = "SELECT * FROM StudentInformation where StudentStatus = 'Deleted'";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(viewdata, con);
                        DataTable studentTable = new DataTable();
                        studentTable.Clear();
                        
                        SqlDataReader reader = cmd.ExecuteReader();
                        studentTable.Load(reader);
                        StudentGridView2.DataSource = studentTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Bin_Load(object sender, EventArgs e)
        {
            showBookRelatedDeletedItem();
            showStudentRelatedDeletedItem();
        }

        private void BookGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure? Do you want restore this record?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                // Assume that `sno` is fetched from the selected cell in DataGridView
                int sno = Convert.ToInt32(BookGridView1.Rows[e.RowIndex].Cells["ISBNNumber"].Value);

                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string updateBookStatus = "UPDATE ADDBOOKS SET BookStatus = @BookStatus WHERE ISBNNumber = @SNO";

                        using (SqlCommand cmd = new SqlCommand(updateBookStatus, con))
                        {
                            cmd.Parameters.AddWithValue("@BookStatus", "Retained");
                            cmd.Parameters.AddWithValue("@SNO", sno);

                            try
                            {
                                con.Open();
                                int updated = cmd.ExecuteNonQuery();
                                if (updated >= 1)
                                {
                                    showBookRelatedDeletedItem();
                                    
                                    MessageBox.Show("Book restore successfully.");

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

        private void StudentGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure? Do you want restore this record?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                // Assume that `sno` is fetched from the selected cell in DataGridView
                int sno = Convert.ToInt32(StudentGridView2.Rows[e.RowIndex].Cells["ID"].Value);

                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string updateBookStatus = "UPDATE StudentInformation SET StudentStatus = @StudentStatus WHERE ID = @SNO";

                        using (SqlCommand cmd = new SqlCommand(updateBookStatus, con))
                        {
                            cmd.Parameters.AddWithValue("@StudentStatus", "Retained");
                            cmd.Parameters.AddWithValue("@SNO", sno);

                            try
                            {
                                con.Open();
                                int updated = cmd.ExecuteNonQuery();
                                if (updated >= 1)
                                {
                                    showStudentRelatedDeletedItem();
                                    MessageBox.Show("Book restore successfully.");

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

        private void BookGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
