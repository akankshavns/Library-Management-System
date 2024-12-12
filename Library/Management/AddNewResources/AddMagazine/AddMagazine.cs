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

namespace Library.Management.AddNewResources.AddNewMagazine
{
    public partial class AddMagazine : UserControl
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public AddMagazine()
        {
            InitializeComponent();
        }

        private void AddMagazineBtn_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string insertQuery = @"
                        INSERT INTO [dbo].[Magazine]
                        (MagazineName, Frequency, Catagory, volume, Language, cost, Quantity, ArticlesList, PurchasedOn, MagazineStatus, AvailableMagazine)
                        VALUES
                        (@MagazineName, @Frequency, @Catagory, @volume, @Language, @cost, @Quantity, @ArticlesList, @PurchasedOn, @MagazineStatus, @AvailableMagazine)";

                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@MagazineName", MagVolume.Text);
                            command.Parameters.AddWithValue("@Frequency", Quantity.Text);
                            command.Parameters.AddWithValue("@Catagory", MagazineCatagory.Text);
                            command.Parameters.AddWithValue("@volume", MagVolume.Text);
                            command.Parameters.AddWithValue("@Language", Language.Text);
                            command.Parameters.AddWithValue("@cost", Cost.Text);
                            command.Parameters.AddWithValue("@Quantity", Quantity.Text);
                            command.Parameters.AddWithValue("@ArticalList", ArticalList.Text);
                            command.Parameters.AddWithValue("@PurchasedOn", PurchsedDate.Text);
                            command.Parameters.AddWithValue("@MagazineStatus", "Available");
                            command.Parameters.AddWithValue("@AvailableMagazine", Quantity.Text);


                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data inserted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to insert data.");
                            }

                        }
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show("this error shown in  the magazine" + ex.Message);
                    }
                }
            }
        }
    }
                
}