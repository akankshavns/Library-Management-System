namespace Library.StudentManagement
{
    partial class viewStudent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.SName = new System.Windows.Forms.TextBox();
            this.Department = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpdateDetails = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MotherName = new System.Windows.Forms.TextBox();
            this.FatherName = new System.Windows.Forms.TextBox();
            this.Enroll = new System.Windows.Forms.TextBox();
            this.StudentDetailView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MailCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.UpdateImage = new System.Windows.Forms.Button();
            this.updateSectionButton = new Library.Design.RoundPictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDetailView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateSectionButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.updateSectionButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.SearchBox);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1231, 55);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(397, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 34);
            this.label1.TabIndex = 28;
            this.label1.Text = "Registered Student Details...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Library.Properties.Resources.Search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 27);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SearchBox.Location = new System.Drawing.Point(38, 16);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(207, 27);
            this.SearchBox.TabIndex = 26;
            this.SearchBox.Text = "Search.....";
            this.SearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyUp);
            // 
            // image
            // 
            this.image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Location = new System.Drawing.Point(813, 21);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(115, 130);
            this.image.TabIndex = 20;
            this.image.TabStop = false;
            // 
            // SName
            // 
            this.SName.Enabled = false;
            this.SName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SName.Location = new System.Drawing.Point(220, 56);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(187, 23);
            this.SName.TabIndex = 18;
            // 
            // Department
            // 
            this.Department.Enabled = false;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.Location = new System.Drawing.Point(603, 21);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(187, 23);
            this.Department.TabIndex = 16;
            // 
            // mail
            // 
            this.mail.Enabled = false;
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(603, 91);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(187, 23);
            this.mail.TabIndex = 15;
            this.mail.Validating += new System.ComponentModel.CancelEventHandler(this.mail_Validating);
            // 
            // contact
            // 
            this.contact.Enabled = false;
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(603, 55);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(187, 23);
            this.contact.TabIndex = 14;
            // 
            // Address
            // 
            this.Address.Enabled = false;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(603, 126);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(187, 23);
            this.Address.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enrollment No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Student Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(471, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 26);
            this.label11.TabIndex = 10;
            this.label11.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(476, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 26);
            this.label10.TabIndex = 9;
            this.label10.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Father\'s Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(476, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 26);
            this.label9.TabIndex = 8;
            this.label9.Text = "Contact";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.UpdateImage);
            this.panel1.Controls.Add(this.UpdateDetails);
            this.panel1.Controls.Add(this.image);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.SName);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.MotherName);
            this.panel1.Controls.Add(this.FatherName);
            this.panel1.Controls.Add(this.Enroll);
            this.panel1.Controls.Add(this.Department);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.mail);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Controls.Add(this.contact);
            this.panel1.Controls.Add(this.StudentDetailView);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(20, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 455);
            this.panel1.TabIndex = 14;
            // 
            // UpdateDetails
            // 
            this.UpdateDetails.BackColor = System.Drawing.Color.LimeGreen;
            this.UpdateDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDetails.Location = new System.Drawing.Point(934, 109);
            this.UpdateDetails.Name = "UpdateDetails";
            this.UpdateDetails.Size = new System.Drawing.Size(149, 42);
            this.UpdateDetails.TabIndex = 22;
            this.UpdateDetails.Text = "Update Details";
            this.UpdateDetails.UseVisualStyleBackColor = false;
            this.UpdateDetails.Visible = false;
            this.UpdateDetails.Click += new System.EventHandler(this.UpdateDetails_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(471, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mother\'s Name";
            // 
            // MotherName
            // 
            this.MotherName.Enabled = false;
            this.MotherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotherName.Location = new System.Drawing.Point(220, 128);
            this.MotherName.Name = "MotherName";
            this.MotherName.Size = new System.Drawing.Size(187, 23);
            this.MotherName.TabIndex = 16;
            // 
            // FatherName
            // 
            this.FatherName.Enabled = false;
            this.FatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatherName.Location = new System.Drawing.Point(220, 92);
            this.FatherName.Name = "FatherName";
            this.FatherName.Size = new System.Drawing.Size(187, 23);
            this.FatherName.TabIndex = 16;
            // 
            // Enroll
            // 
            this.Enroll.Enabled = false;
            this.Enroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enroll.Location = new System.Drawing.Point(220, 21);
            this.Enroll.Name = "Enroll";
            this.Enroll.Size = new System.Drawing.Size(187, 23);
            this.Enroll.TabIndex = 16;
            // 
            // StudentDetailView
            // 
            this.StudentDetailView.AllowUserToAddRows = false;
            this.StudentDetailView.AllowUserToOrderColumns = true;
            this.StudentDetailView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentDetailView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentDetailView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.StudentDetailView.CausesValidation = false;
            this.StudentDetailView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentDetailView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentDetailView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDetailView.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentDetailView.DefaultCellStyle = dataGridViewCellStyle2;
            this.StudentDetailView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StudentDetailView.Location = new System.Drawing.Point(18, 157);
            this.StudentDetailView.Name = "StudentDetailView";
            this.StudentDetailView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentDetailView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StudentDetailView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentDetailView.Size = new System.Drawing.Size(1142, 287);
            this.StudentDetailView.TabIndex = 21;
            this.StudentDetailView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDetailView_CellClick);
            this.StudentDetailView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDetailView_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Library.Properties.Resources.thisIsFinal;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 534);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1231, 133);
            this.panel3.TabIndex = 16;
            // 
            // MailCheck
            // 
            this.MailCheck.ContainerControl = this;
            // 
            // UpdateImage
            // 
            this.UpdateImage.BackColor = System.Drawing.Color.LimeGreen;
            this.UpdateImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateImage.Location = new System.Drawing.Point(934, 56);
            this.UpdateImage.Name = "UpdateImage";
            this.UpdateImage.Size = new System.Drawing.Size(149, 42);
            this.UpdateImage.TabIndex = 22;
            this.UpdateImage.Text = "change Image";
            this.UpdateImage.UseVisualStyleBackColor = false;
            this.UpdateImage.Visible = false;
            this.UpdateImage.Click += new System.EventHandler(this.UpdateDetails_Click);
            // 
            // updateSectionButton
            // 
            this.updateSectionButton.BackgroundImage = global::Library.Properties.Resources.updatebutton;
            this.updateSectionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateSectionButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateSectionButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.updateSectionButton.Location = new System.Drawing.Point(1133, 0);
            this.updateSectionButton.Name = "updateSectionButton";
            this.updateSectionButton.Size = new System.Drawing.Size(98, 55);
            this.updateSectionButton.TabIndex = 29;
            this.updateSectionButton.TabStop = false;
            this.updateSectionButton.Click += new System.EventHandler(this.updateSectionButton_Click);
            // 
            // viewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "viewStudent";
            this.Size = new System.Drawing.Size(1231, 667);
            this.Load += new System.EventHandler(this.viewStudent_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDetailView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateSectionButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.TextBox SName;
        private System.Windows.Forms.TextBox Department;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView StudentDetailView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SearchBox;
        private Design.RoundPictureBox updateSectionButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MotherName;
        private System.Windows.Forms.TextBox FatherName;
        private System.Windows.Forms.TextBox Enroll;
        private System.Windows.Forms.Button UpdateDetails;
        private System.Windows.Forms.ErrorProvider MailCheck;
        private System.Windows.Forms.Button UpdateImage;
    }
}
