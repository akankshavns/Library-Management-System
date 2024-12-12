using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Reporting.WinForms;

namespace Library.Management.Report
{
    public partial class ReportShow : UserControl
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public ReportShow()
        {
            InitializeComponent();
        }

        private void SelectReportdropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectReportdropdown.SelectedItem.ToString() == "Book Report")
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    string query = "SELECT * FROM AddBooks Where  BookStatus=@BookStatus";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@BookStatus", "Retained");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        reportViewer1.LocalReport.DataSources.Clear();
                        ReportDataSource sources = new ReportDataSource("DataSet1", dt);
                        reportViewer1.LocalReport.ReportPath = @"C:\Users\makan\Desktop\MiniProject\Library\ReportViewer\BookReport.rdlc";
                        reportViewer1.LocalReport.DataSources.Add(sources);
                        reportViewer1.RefreshReport();
                    }
                }
            }

            if (SelectReportdropdown.SelectedItem.ToString() == "News paper Report")
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    string query = "SELECT * FROM Newspaper Where NewsPaperStatus=@Status";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Status", "Retained");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        reportViewer1.LocalReport.DataSources.Clear();
                        ReportDataSource sources = new ReportDataSource("DataSet1", dt);
                        reportViewer1.LocalReport.ReportPath = @"C:\Users\makan\Desktop\MiniProject\Library\ReportViewer\NewspaperReport.rdlc";
                        reportViewer1.LocalReport.DataSources.Add(sources);
                        reportViewer1.RefreshReport();
                    }
                }
            }
            if (SelectReportdropdown.SelectedItem.ToString() == "Student Report")
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    string query = "SELECT * FROM StudentInformation Where StudentStatus=@Status";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Status", "Retained");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        reportViewer1.LocalReport.DataSources.Clear();
                        ReportDataSource sources = new ReportDataSource("DataSet1", dt);
                        reportViewer1.LocalReport.ReportPath = @"C:\Users\makan\Desktop\MiniProject\Library\ReportViewer\StudentReport.rdlc";
                        reportViewer1.LocalReport.DataSources.Add(sources);
                        reportViewer1.RefreshReport();
                    }
                }
                dateTimePickerEnd.Enabled = false;
                dateTimePickerStart.Enabled = false;
                FilterButton.Enabled = false;
            }
            if (SelectReportdropdown.SelectedItem.ToString() == "Magazine Report")
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    string query = "SELECT * FROM Magazine Where  MagazineStatus=@Status";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Status", "Retained");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        reportViewer1.LocalReport.DataSources.Clear();
                        ReportDataSource sources = new ReportDataSource("DataSet1", dt);
                        reportViewer1.LocalReport.ReportPath = @"C:\Users\makan\Desktop\MiniProject\Library\ReportViewer\MagazineReport.rdlc";
                        reportViewer1.LocalReport.DataSources.Add(sources);
                        reportViewer1.RefreshReport();
                    }
                }
            }
            if (SelectReportdropdown.SelectedItem.ToString() == "Staff Report")
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    string query = "SELECT * FROM StaffInformation Where StaffStatus=@Status";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Status", "Retained");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        reportViewer1.LocalReport.DataSources.Clear();
                        ReportDataSource sources = new ReportDataSource("DataSet1", dt);
                        reportViewer1.LocalReport.ReportPath = @"C:\Users\makan\Desktop\MiniProject\Library\ReportViewer\StaffReport.rdlc";
                        reportViewer1.LocalReport.DataSources.Add(sources);
                        reportViewer1.RefreshReport();
                    }
                }
                dateTimePickerEnd.Enabled= false;
                dateTimePickerStart.Enabled= false;
                FilterButton.Enabled= false;

            }
            if (SelectReportdropdown.SelectedItem.ToString() == "IssueBooks Report")
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    string query = "SELECT * FROM IssueBookDetail";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        reportViewer1.LocalReport.DataSources.Clear();
                        ReportDataSource sources = new ReportDataSource("DataSet1", dt);
                        reportViewer1.LocalReport.ReportPath = @"C:\Users\makan\Desktop\MiniProject\Library\ReportViewer\IssueBook.rdlc";
                        reportViewer1.LocalReport.DataSources.Add(sources);
                        reportViewer1.RefreshReport();
                    }
                }
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (SelectReportdropdown.SelectedItem.ToString() == "Book Report") 
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    // Fetch updated values from DateTimePickers
                    DateTime startDate = dateTimePickerStart.Value.Date;
                    DateTime endDate = dateTimePickerEnd.Value.Date;

                    string query = "SELECT * FROM Addbooks WHERE CAST(BookDate AS DATE) BETWEEN @StartDate AND @EndDate And BookStatus=@status";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Status", "Retained");
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)  // Check if any records were returned
                        {
                            reportViewer1.LocalReport.DataSources.Clear();
                            ReportDataSource sources = new ReportDataSource("DataSet1", dt);
                            reportViewer1.LocalReport.ReportPath = @"C:\Users\makan\Desktop\MiniProject\Library\ReportViewer\BookReport.rdlc";

                            reportViewer1.LocalReport.DataSources.Add(sources);
                            reportViewer1.RefreshReport();
                        }
                        else
                        {
                            MessageBox.Show("No records found for the selected date range.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            if (SelectReportdropdown.SelectedItem.ToString() == "News paper Report")
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    // Fetch updated values from DateTimePickers
                    DateTime startDate = dateTimePickerStart.Value.Date;
                    DateTime endDate = dateTimePickerEnd.Value.Date;

                    string query = "SELECT * FROM Newspaper WHERE CAST(Purchasedon AS DATE) BETWEEN @StartDate AND @EndDate AND  NewsPaperStatus=@Status";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Status", "Retained");
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)  // Check if any records were returned
                        {
                            reportViewer1.LocalReport.DataSources.Clear();
                            ReportDataSource sources = new ReportDataSource("DataSet1", dt);
                            reportViewer1.LocalReport.ReportPath = @"C:\Users\makan\Desktop\MiniProject\Library\ReportViewer\NewsPaperReport.rdlc";

                            reportViewer1.LocalReport.DataSources.Add(sources);
                            reportViewer1.RefreshReport();
                        }
                        else
                        {
                            MessageBox.Show("No records found for the selected date range.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            if (SelectReportdropdown.SelectedItem.ToString() == "Magazine Report")
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    // Fetch updated values from DateTimePickers
                    DateTime startDate = dateTimePickerStart.Value.Date;
                    DateTime endDate = dateTimePickerEnd.Value.Date;

                    string query = "SELECT * FROM Magazine WHERE CAST(Purchasedon AS DATE) BETWEEN @StartDate AND @EndDate AND MagazineStatus =@Status";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Status", "Retained");
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)  // Check if any records were returned
                        {
                            reportViewer1.LocalReport.DataSources.Clear();
                            ReportDataSource sources = new ReportDataSource("DataSet1", dt);
                            reportViewer1.LocalReport.ReportPath = @"C:\Users\makan\Desktop\MiniProject\Library\ReportViewer\MagazineReport.rdlc";

                            reportViewer1.LocalReport.DataSources.Add(sources);
                            reportViewer1.RefreshReport();
                        }
                        else
                        {
                            MessageBox.Show("No records found for the selected date range.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

            }
            if (SelectReportdropdown.SelectedItem.ToString() == "IssueBooks Report")
            {
                string connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    // Fetch updated values from DateTimePickers
                    DateTime startDate = dateTimePickerStart.Value.Date;
                    DateTime endDate = dateTimePickerEnd.Value.Date;

                    string query = "SELECT * FROM IssueBookDetail WHERE CAST(IssueDate AS DATE) BETWEEN @StartDate AND @EndDate";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)  // Check if any records were returned
                        {
                            reportViewer1.LocalReport.DataSources.Clear();
                            ReportDataSource sources = new ReportDataSource("DataSet1", dt);
                            reportViewer1.LocalReport.ReportPath = @"C:\Users\makan\Desktop\MiniProject\Library\ReportViewer\IssueBook.rdlc";

                            reportViewer1.LocalReport.DataSources.Add(sources);
                            reportViewer1.RefreshReport();
                        }
                        else
                        {
                            MessageBox.Show("No records found for the selected date range.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}
