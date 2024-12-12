using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library.Management.AddNewResources.AddNewsPaper
{
    
    public partial class AddNewspaper : UserControl
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public AddNewspaper()
        {
            InitializeComponent();
        }

        private void AddNewsPaperBtn_Click(object sender, EventArgs e)
        {
            string query = @"
        INSERT INTO Newspaper (Name, publishedon, purchasedOn, language, quantity, NewsPaperStatus)
        VALUES (@Name, @PublishedOn, @PurchasedOn, @Language, @Quantity, @NewsPaperStatus)";
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Add parameters to prevent SQL injection
                            command.Parameters.AddWithValue("@Name", NewspaperName.Text);
                            command.Parameters.AddWithValue("@PublishedOn", Publishdate.Text);
                            command.Parameters.AddWithValue("@PurchasedOn", PurchsedDate.Text);
                            command.Parameters.AddWithValue("@Language", Language.Text);
                            command.Parameters.AddWithValue("@Quantity", Quantity.Text);
                            command.Parameters.AddWithValue("@NewsPaperStatus", "Retained");

                            //            // Execute the query
                            int rowsAffected = command.ExecuteNonQuery();
                            MessageBox.Show($" inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}