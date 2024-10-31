namespace Library.Auth
{
    partial class Authentication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Admin = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.White;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.DarkRed;
            this.Admin.Image = global::Library.Properties.Resources.Crown;
            this.Admin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Admin.Location = new System.Drawing.Point(2, 3);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(168, 39);
            this.Admin.TabIndex = 3;
            this.Admin.Text = "Admin";
            this.Admin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Admin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Admin.UseVisualStyleBackColor = false;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.White;
            this.user.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.DarkRed;
            this.user.Image = global::Library.Properties.Resources.User1;
            this.user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user.Location = new System.Drawing.Point(244, 2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(178, 40);
            this.user.TabIndex = 3;
            this.user.Text = "User";
            this.user.UseVisualStyleBackColor = false;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Library.Properties.Resources.image1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 510);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;

            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Admin);
            this.panel1.Controls.Add(this.user);
            this.panel1.Location = new System.Drawing.Point(186, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 45);
            this.panel1.TabIndex = 6;
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(806, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}