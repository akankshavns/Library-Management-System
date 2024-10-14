namespace Library.StudentManagement
{
    partial class AddStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Address = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Contact = new System.Windows.Forms.TextBox();
            this.upload = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.AddStudentInDBO = new System.Windows.Forms.Button();
            this.AddStudent_picture = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.TextBox();
            this.MotherName = new System.Windows.Forms.TextBox();
            this.FatherName = new System.Windows.Forms.TextBox();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EnrollmentNo = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.CheckContact = new System.Windows.Forms.ErrorProvider(this.components);
            this.ContactNumbercheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.FatherNameCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.StudentCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.MotherNameCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.DepartmentCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.AddressCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.EnrollmentCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.EmailCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderimageUpload = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddStudent_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactNumbercheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FatherNameCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotherNameCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnrollmentCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderimageUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Address);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.Contact);
            this.panel1.Controls.Add(this.upload);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.AddStudentInDBO);
            this.panel1.Controls.Add(this.AddStudent_picture);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Department);
            this.panel1.Controls.Add(this.MotherName);
            this.panel1.Controls.Add(this.FatherName);
            this.panel1.Controls.Add(this.StudentName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EnrollmentNo);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(63, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 416);
            this.panel1.TabIndex = 1;
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(297, 298);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(217, 23);
            this.Address.TabIndex = 17;
            this.Address.TextChanged += new System.EventHandler(this.Address_TextChanged);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(297, 260);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(217, 23);
            this.Email.TabIndex = 17;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // Contact
            // 
            this.Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Location = new System.Drawing.Point(297, 224);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(217, 23);
            this.Contact.TabIndex = 17;
            this.Contact.Text = "+91";
            this.Contact.TextChanged += new System.EventHandler(this.Contact_TextChanged);
            this.Contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Contact_KeyPress);
            // 
            // upload
            // 
            this.upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.Location = new System.Drawing.Point(639, 224);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(179, 39);
            this.upload.TabIndex = 16;
            this.upload.Text = "Upload Image";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "StudentName";
            // 
            // AddStudentInDBO
            // 
            this.AddStudentInDBO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentInDBO.Location = new System.Drawing.Point(231, 355);
            this.AddStudentInDBO.Name = "AddStudentInDBO";
            this.AddStudentInDBO.Size = new System.Drawing.Size(96, 46);
            this.AddStudentInDBO.TabIndex = 14;
            this.AddStudentInDBO.Text = "Add";
            this.AddStudentInDBO.UseVisualStyleBackColor = true;
            this.AddStudentInDBO.Click += new System.EventHandler(this.AddStudentInDBO_Click);
            // 
            // AddStudent_picture
            // 
            this.AddStudent_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddStudent_picture.Location = new System.Drawing.Point(648, 34);
            this.AddStudent_picture.Name = "AddStudent_picture";
            this.AddStudent_picture.Size = new System.Drawing.Size(159, 176);
            this.AddStudent_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddStudent_picture.TabIndex = 13;
            this.AddStudent_picture.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Department";
            // 
            // Department
            // 
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.Location = new System.Drawing.Point(297, 187);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(217, 23);
            this.Department.TabIndex = 12;
            this.Department.TextChanged += new System.EventHandler(this.Department_TextChanged);
            // 
            // MotherName
            // 
            this.MotherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotherName.Location = new System.Drawing.Point(297, 147);
            this.MotherName.Name = "MotherName";
            this.MotherName.Size = new System.Drawing.Size(217, 23);
            this.MotherName.TabIndex = 10;
            this.MotherName.TextChanged += new System.EventHandler(this.MotherName_TextChanged);
            // 
            // FatherName
            // 
            this.FatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatherName.Location = new System.Drawing.Point(297, 110);
            this.FatherName.Name = "FatherName";
            this.FatherName.Size = new System.Drawing.Size(217, 23);
            this.FatherName.TabIndex = 9;
            this.FatherName.TextChanged += new System.EventHandler(this.FatherName_TextChanged);
            // 
            // StudentName
            // 
            this.StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentName.Location = new System.Drawing.Point(297, 74);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(217, 23);
            this.StudentName.TabIndex = 8;
            this.StudentName.TextChanged += new System.EventHandler(this.StudentName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contact";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(60, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 26);
            this.label11.TabIndex = 2;
            this.label11.Text = "Mother Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Father Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "EnrollmentNumber";
            // 
            // EnrollmentNo
            // 
            this.EnrollmentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollmentNo.Location = new System.Drawing.Point(297, 35);
            this.EnrollmentNo.Name = "EnrollmentNo";
            this.EnrollmentNo.Size = new System.Drawing.Size(217, 23);
            this.EnrollmentNo.TabIndex = 0;
            this.EnrollmentNo.TextChanged += new System.EventHandler(this.EnrollmentNo_TextChanged);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Image = global::Library.Properties.Resources.Left_Arrow;
            this.BackButton.Location = new System.Drawing.Point(-2, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(41, 16);
            this.BackButton.TabIndex = 18;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CheckContact
            // 
            this.CheckContact.ContainerControl = this;
            // 
            // ContactNumbercheck
            // 
            this.ContactNumbercheck.ContainerControl = this;
            // 
            // FatherNameCheck
            // 
            this.FatherNameCheck.ContainerControl = this;
            // 
            // StudentCheck
            // 
            this.StudentCheck.ContainerControl = this;
            // 
            // MotherNameCheck
            // 
            this.MotherNameCheck.ContainerControl = this;
            // 
            // DepartmentCheck
            // 
            this.DepartmentCheck.ContainerControl = this;
            // 
            // AddressCheck
            // 
            this.AddressCheck.ContainerControl = this;
            // 
            // EnrollmentCheck
            // 
            this.EnrollmentCheck.ContainerControl = this;
            // 
            // EmailCheck
            // 
            this.EmailCheck.ContainerControl = this;
            // 
            // errorProviderimageUpload
            // 
            this.errorProviderimageUpload.ContainerControl = this;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.panel1);
            this.Name = "AddStudent";
            this.Size = new System.Drawing.Size(1231, 667);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddStudent_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactNumbercheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FatherNameCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotherNameCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnrollmentCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderimageUpload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Contact;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddStudentInDBO;
        private System.Windows.Forms.PictureBox AddStudent_picture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Department;
        private System.Windows.Forms.TextBox MotherName;
        private System.Windows.Forms.TextBox FatherName;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EnrollmentNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ErrorProvider CheckContact;
        private System.Windows.Forms.ErrorProvider ContactNumbercheck;
        private System.Windows.Forms.ErrorProvider FatherNameCheck;
        private System.Windows.Forms.ErrorProvider StudentCheck;
        private System.Windows.Forms.ErrorProvider MotherNameCheck;
        private System.Windows.Forms.ErrorProvider DepartmentCheck;
        private System.Windows.Forms.ErrorProvider AddressCheck;
        private System.Windows.Forms.ErrorProvider EnrollmentCheck;
        private System.Windows.Forms.ErrorProvider EmailCheck;
        private System.Windows.Forms.ErrorProvider errorProviderimageUpload;
    }
}
