using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace Library.Management.Setting
{
    public partial class Library : UserControl
    {
        public string studentImgPath = string.Empty;
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
        }
        public string LibraryName;
        public Library()
        {
            InitializeComponent();
            SetChanges.Enabled = false;
            changedLogoName.TextChanged += changedLogoName_TextChanged;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }

        private void UploadLogo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDilog = new OpenFileDialog();
                fileDilog.Filter = "Image Files(*.jpg;*.png)|*.jpg;*.png";
                if (fileDilog.ShowDialog() == DialogResult.OK)
                {
                    studentImgPath = fileDilog.FileName;
                    logoImage.ImageLocation = studentImgPath;
                    //SetChanges.Enabled = !string.IsNullOrEmpty(studentImgPath);
                    SetChanges.Enabled = !string.IsNullOrEmpty(studentImgPath) || !string.IsNullOrEmpty(changedLogoName.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("1", ex.Message);
            }
        }
  
        private void SetChanges_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    string LogoSet = "update LibrarySetting set logo = @logo,libraryName= @logoname where id = " + 2 + "";
                    try
                    {
                        con.Open();
                        string path = Path.Combine("uploads", "logo", "HomePageLogo.jpg");


                        string directoryPath = Path.GetDirectoryName(path);
                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }
                        if (File.Exists(path))
                        {
                            File.Delete(path);
                        }
                        File.Copy(studentImgPath, path, true);
                        SqlCommand cmd = new SqlCommand(LogoSet, con);
                        cmd.Parameters.AddWithValue("@logoname", changedLogoName.Text);
                        cmd.Parameters.AddWithValue("@logo", path);
                        int i = cmd.ExecuteNonQuery();
                        if (i >= 1)
                        {
                            MessageBox.Show("successfully");
                        }
                        if (!string.IsNullOrEmpty(path) && File.Exists(path))
                        {
                            byte[] imageBytes = File.ReadAllBytes(path);
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {

                                Home.HomeLogo.BackgroundImage = Image.FromStream(ms);
                                Home.HomeLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("2", ex.Message);
                    }
                    ImagePanel.Visible = false;
                }
            }
        }

        private void logoOption_CheckedChanged(object sender, EventArgs e)
        {
            if (logoOption.Checked)
            {
                ImagePanel.Visible = true;
            }
        }

        private void Library_Load(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            if (connectionString != null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string getlibraryName = "Select libraryName from LibrarySetting where id =" + 2 + " ";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(getlibraryName, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            LibraryName = reader.GetString(0);
                            changedLogoName.Text = LibraryName;
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("3",ex.Message); }
                }
            }
        }

        private void LibraryNameOption_CheckedChanged(object sender, EventArgs e)
        {
            if (LibraryNameOption.Checked) 
            {
                ChangedNamePanel.Visible = true;
            }
        }

        private void changedLogoName_TextChanged(object sender, EventArgs e)
        {
            SetChanges.Enabled = !string.IsNullOrEmpty(changedLogoName.Text) || !string.IsNullOrEmpty(studentImgPath);
        }
    }
}
