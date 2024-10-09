namespace Library.TransactionManagement
{
    partial class ReturnBook
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
            this.issuePage = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.issueDate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ActualReturnDate = new System.Windows.Forms.DateTimePicker();
            this.Return = new System.Windows.Forms.Button();
            this.mail = new System.Windows.Forms.TextBox();
            this.Dep = new System.Windows.Forms.TextBox();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Depart = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AuthorName = new System.Windows.Forms.TextBox();
            this.BookName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Search = new System.Windows.Forms.Button();
            this.BookID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EnrollBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.issuePage.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // issuePage
            // 
            this.issuePage.BackColor = System.Drawing.Color.White;
            this.issuePage.Controls.Add(this.BackButton);
            this.issuePage.Controls.Add(this.InfoPanel);
            this.issuePage.Controls.Add(this.panel5);
            this.issuePage.Location = new System.Drawing.Point(45, 41);
            this.issuePage.Name = "issuePage";
            this.issuePage.Size = new System.Drawing.Size(1186, 626);
            this.issuePage.TabIndex = 16;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Image = global::Library.Properties.Resources.Left_Arrow;
            this.BackButton.Location = new System.Drawing.Point(0, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(41, 16);
            this.BackButton.TabIndex = 6;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.issueDate);
            this.InfoPanel.Controls.Add(this.label14);
            this.InfoPanel.Controls.Add(this.label13);
            this.InfoPanel.Controls.Add(this.ActualReturnDate);
            this.InfoPanel.Controls.Add(this.Return);
            this.InfoPanel.Controls.Add(this.mail);
            this.InfoPanel.Controls.Add(this.Dep);
            this.InfoPanel.Controls.Add(this.StudentName);
            this.InfoPanel.Controls.Add(this.Email);
            this.InfoPanel.Controls.Add(this.Depart);
            this.InfoPanel.Controls.Add(this.label12);
            this.InfoPanel.Controls.Add(this.AuthorName);
            this.InfoPanel.Controls.Add(this.BookName);
            this.InfoPanel.Controls.Add(this.label11);
            this.InfoPanel.Controls.Add(this.label10);
            this.InfoPanel.Controls.Add(this.label7);
            this.InfoPanel.Controls.Add(this.label6);
            this.InfoPanel.Location = new System.Drawing.Point(487, 67);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(492, 499);
            this.InfoPanel.TabIndex = 1;
            this.InfoPanel.Visible = false;
            // 
            // issueDate
            // 
            this.issueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueDate.Location = new System.Drawing.Point(161, 296);
            this.issueDate.Name = "issueDate";
            this.issueDate.Size = new System.Drawing.Size(224, 23);
            this.issueDate.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(31, 297);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 22);
            this.label14.TabIndex = 25;
            this.label14.Text = "Issue Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(31, 349);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 22);
            this.label13.TabIndex = 24;
            this.label13.Text = "Return Date";
            // 
            // ActualReturnDate
            // 
            this.ActualReturnDate.Checked = false;
            this.ActualReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualReturnDate.Location = new System.Drawing.Point(161, 349);
            this.ActualReturnDate.MinDate = new System.DateTime(2024, 10, 9, 0, 0, 0, 0);
            this.ActualReturnDate.Name = "ActualReturnDate";
            this.ActualReturnDate.Size = new System.Drawing.Size(224, 23);
            this.ActualReturnDate.TabIndex = 23;
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Location = new System.Drawing.Point(151, 426);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(113, 46);
            this.Return.TabIndex = 21;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // mail
            // 
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(161, 245);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(224, 23);
            this.mail.TabIndex = 19;
            // 
            // Dep
            // 
            this.Dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dep.Location = new System.Drawing.Point(161, 200);
            this.Dep.Name = "Dep";
            this.Dep.Size = new System.Drawing.Size(224, 23);
            this.Dep.TabIndex = 17;
            // 
            // StudentName
            // 
            this.StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentName.Location = new System.Drawing.Point(161, 154);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(224, 23);
            this.StudentName.TabIndex = 16;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.Black;
            this.Email.Location = new System.Drawing.Point(31, 245);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(54, 22);
            this.Email.TabIndex = 14;
            this.Email.Text = "Email";
            // 
            // Depart
            // 
            this.Depart.AutoSize = true;
            this.Depart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Depart.ForeColor = System.Drawing.Color.Black;
            this.Depart.Location = new System.Drawing.Point(31, 201);
            this.Depart.Name = "Depart";
            this.Depart.Size = new System.Drawing.Size(103, 22);
            this.Depart.TabIndex = 12;
            this.Depart.Text = "Department";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(31, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 22);
            this.label12.TabIndex = 11;
            this.label12.Text = "Student Name";
            // 
            // AuthorName
            // 
            this.AuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorName.Location = new System.Drawing.Point(161, 77);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(224, 23);
            this.AuthorName.TabIndex = 10;
            // 
            // BookName
            // 
            this.BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookName.Location = new System.Drawing.Point(161, 39);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(224, 23);
            this.BookName.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(31, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 22);
            this.label11.TabIndex = 7;
            this.label11.Text = "Author Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(31, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 22);
            this.label10.TabIndex = 6;
            this.label10.Text = "Book Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(3, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Student info...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Book info...";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Search);
            this.panel5.Controls.Add(this.BookID);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.EnrollBox);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(153, 67);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(297, 257);
            this.panel5.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(75, 201);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(128, 43);
            this.Search.TabIndex = 22;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // BookID
            // 
            this.BookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookID.Location = new System.Drawing.Point(18, 49);
            this.BookID.Name = "BookID";
            this.BookID.Size = new System.Drawing.Size(254, 23);
            this.BookID.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Enter book Id";
            // 
            // EnrollBox
            // 
            this.EnrollBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollBox.ForeColor = System.Drawing.Color.Silver;
            this.EnrollBox.Location = new System.Drawing.Point(18, 142);
            this.EnrollBox.Name = "EnrollBox";
            this.EnrollBox.Size = new System.Drawing.Size(254, 23);
            this.EnrollBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter Student Enrollmentno.";
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.issuePage);
            this.Name = "ReturnBook";
            this.Size = new System.Drawing.Size(1231, 667);
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.issuePage.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel issuePage;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.TextBox issueDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker ActualReturnDate;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox Dep;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Depart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox AuthorName;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox BookID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EnrollBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BackButton;
    }
}
