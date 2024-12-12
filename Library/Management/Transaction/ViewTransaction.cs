using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Library.TransactionManagement
{
    public partial class ViewTransaction : UserControl
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public ViewTransaction()
        {
            InitializeComponent();
        }

        private void ViewTransaction_Load(object sender, EventArgs e)
        {
            viewIssuedBook();
        }
        public void viewIssuedBook()
        {

            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string showReturnData = "SELECT i.ISBNNumber, b.BookName, b.AuthorName, b.Volume, b.Language, i.EnrollmentNumber, s.StudentName, s.Department, s.Email, i.IssueDate, i.DueDate, i.ReturnDate FROM IssueBookDetail i JOIN AddBooks b ON i.ISBNNumber = b.ISBNNumber JOIN StudentInformation s ON i.EnrollmentNumber = s.EnrollmentNumber WHERE i.isReturnBook = @status AND MONTH(i.ReturnDate) = MONTH(GETDATE()) AND YEAR(i.ReturnDate) = YEAR(GETDATE())";
                    string showHoldData = "SELECT i.ISBNNumber, b.BookName, b.AuthorName, b.Volume, b.Language, i.EnrollmentNumber, s.StudentName, s.Department, s.Email, i.IssueDate, i.DueDate, i.ReturnDate FROM IssueBookDetail i JOIN AddBooks b ON i.ISBNNumber = b.ISBNNumber JOIN StudentInformation s ON i.EnrollmentNumber = s.EnrollmentNumber WHERE i.isReturnBook = @status";

                    try
                    {

                        con.Open();
                        SqlCommand cmd = new SqlCommand(showHoldData, con);
                        cmd.Parameters.AddWithValue("@status", "Hold");
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable bookTable = new DataTable();
                        bookTable.Load(reader);
                        dataGridViewOfHoldBooks.DataSource = bookTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("I am from load Holdbook", ex.Message);
                    }
                    con.Close();
                    try
                    {
                        con.Open();
                        SqlCommand cmdreturn = new SqlCommand(showReturnData, con);
                        cmdreturn.Parameters.AddWithValue("@status", "Return");
                        SqlDataReader reader = cmdreturn.ExecuteReader();
                        DataTable booktable = new DataTable();
                        booktable.Load(reader);
                        dataGridViewOfReturnBooks.DataSource = booktable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("I am from load Returnbook", ex.Message);
                    }
                }
            }
        }
        public static string to;
        private void ReminderBtn_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT ibd.IssueId, ibd.ISBNNumber, ibd.EnrollmentNumber, ibd.IssueDate, ibd.DueDate, ibd.ReturnDate, si.StudentName, si.Email FROM IssueBookDetail ibd INNER JOIN StudentInformation si ON ibd.EnrollmentNumber = si.EnrollmentNumber WHERE ibd.DueDate = CAST(GETDATE() + 2 AS DATE);\r\n";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        con.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        int emailCount = 0; // Counter to track the number of emails sent

                        while (reader.Read())
                        {
                            int issueId = (int)reader["IssueId"];
                            string recipientEmail = reader["Email"].ToString();
                            string returnDate = reader["DueDate"].ToString();
                            string studentName = reader["StudentName"].ToString();

                            string From = "libraryemailProject@gmail.com";
                            string pass = "rrab risa fjcv reqh";
                            string MessageBody = $"Dear {studentName},\n\nPlease return your borrowed book by {returnDate} to avoid fines.\n\nThank you,\nLibrary Management System";

                            MailMessage message = new MailMessage
                            {
                                From = new MailAddress(From),
                                Subject = "Reminder",
                                Body = MessageBody,
                                IsBodyHtml = false
                            };

                            message.To.Add(recipientEmail);

                            SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                            {
                                EnableSsl = true,
                                Port = 587,
                                DeliveryMethod = SmtpDeliveryMethod.Network,
                                Credentials = new NetworkCredential(From, pass)
                            };

                            try
                            {
                                smtp.Send(message);
                                emailCount++;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Failed to send email to {recipientEmail}: {ex.Message}");
                            }
                        }

                        reader.Close();

                        // Show success message after all emails are sent
                        MessageBox.Show(emailCount > 0 ? $"Reminder sent successfully to {emailCount} students." : "No reminders to send.");
                        panel1.Visible = true;
                    }
                }
            }
        }
    }
}
