using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.BookManagement
{
    public partial class update : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;Pooling=False;");
        public update()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = Convert.ToInt32(dataGridView1.SelectedCells[5].Value.ToString());
            MessageBox.Show(i.ToString());
            try
            {


                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update AddBooks set BookName = '" + textBox1.Text + "',AuthorName = '" + textBox2.Text + "', publicationName = '" + textBox3.Text + "',  purchaseDate = '" + dateTimePicker1.Text + "', price = '" + textBox4.Text + "', quantity = '" + textBox5.Text + "' where id = " + i + "";
                cmd.ExecuteNonQuery();
                con.Close();
                dispBook();
                MessageBox.Show("Book updated succesfully.");
                panel1.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_Load(object sender, EventArgs e)
        {
            dispBook();
        }
        public void dispBook()
        {
            try
            {


                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select*From AddBooks";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;
            int i = 0;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            try
            {


                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select*From AddBooks where id = '" + i + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    textBox1.Text = dr["BookName"].ToString();
                    textBox2.Text = dr["AuthorName"].ToString();
                    textBox3.Text = dr["publicationName"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dr["purchaseDate"].ToString());
                    textBox4.Text = dr["price"].ToString();
                    textBox5.Text = dr["quantity"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
