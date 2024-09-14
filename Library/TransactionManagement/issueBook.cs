using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.TransactionManagement
{
    public partial class issueBook : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;Pooling=False;");
        public issueBook()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }

        private void yes_Click(object sender, EventArgs e)
        {
            issueFormDetails1.Show();
            issueFormDetails1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aivalableMessageBox.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            aivalableMessageBox.Visible = false;
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            gridpanel.Visible = true;
            if (searchBox.Text == "Search Book...")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }

        private void issueFormDetails1_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select sN0=id,BookId,BookName From Book";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close() ;
            }
        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int i = 0;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select id,BookId, BookName From Book where BookName like('%" + searchBox.Text + "%') or AuthorName like ('%" + searchBox.Text + "%') ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                con.Close();

                if (i == 0)
                {
                    MessageBox.Show("Book not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int SNO;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int Id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                SNO = Id;
                string query = "SELECT AvailableBook FROM Book WHERE id = '" + Id + "'";

                int num = 0;
                try
                {

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@BookId", Id);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Store the result in the variable `num`
                            num = reader.GetInt32(0);
                        }
                        else
                        {
                            MessageBox.Show("No record found.");
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return;
                }
                con.Close();
                if (num == 0)
                {
                    MessageBox.Show("Book is not available at present.");
                }
                else
                {
                    aivalableMessageBox.Visible = true;
                }

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
