namespace Library.Board
{
    partial class StudentBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.viewStudentbutton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.updateStudentbutton = new System.Windows.Forms.Button();
            this.updateStudent1 = new Library.StudentManagement.UpdateStudent();
            this.viewStudent1 = new Library.StudentManagement.viewStudent();
            this.addStudent1 = new Library.StudentManagement.AddStudent();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 667);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library.Properties.Resources.image_processing20220207_786_j68tnb;
            this.pictureBox1.Location = new System.Drawing.Point(203, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 578);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.viewStudentbutton);
            this.panel2.Controls.Add(this.AddStudentButton);
            this.panel2.Controls.Add(this.updateStudentbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1231, 78);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Management";
            // 
            // viewStudentbutton
            // 
            this.viewStudentbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStudentbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewStudentbutton.Location = new System.Drawing.Point(559, 15);
            this.viewStudentbutton.Name = "viewStudentbutton";
            this.viewStudentbutton.Size = new System.Drawing.Size(95, 54);
            this.viewStudentbutton.TabIndex = 2;
            this.viewStudentbutton.Text = "view\r\n";
            this.viewStudentbutton.UseVisualStyleBackColor = true;
            this.viewStudentbutton.Click += new System.EventHandler(this.viewStudentbutton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddStudentButton.Location = new System.Drawing.Point(423, 15);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(95, 54);
            this.AddStudentButton.TabIndex = 1;
            this.AddStudentButton.Text = "Add";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // updateStudentbutton
            // 
            this.updateStudentbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStudentbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateStudentbutton.Location = new System.Drawing.Point(676, 15);
            this.updateStudentbutton.Name = "updateStudentbutton";
            this.updateStudentbutton.Size = new System.Drawing.Size(95, 54);
            this.updateStudentbutton.TabIndex = 2;
            this.updateStudentbutton.Text = "update";
            this.updateStudentbutton.UseVisualStyleBackColor = true;
            this.updateStudentbutton.Click += new System.EventHandler(this.updateStudentbutton_Click);
            // 
            // updateStudent1
            // 
            this.updateStudent1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateStudent1.BackColor = System.Drawing.Color.Gainsboro;
            this.updateStudent1.Location = new System.Drawing.Point(0, 3);
            this.updateStudent1.Name = "updateStudent1";
            this.updateStudent1.Size = new System.Drawing.Size(1231, 667);
            this.updateStudent1.TabIndex = 2;
            this.updateStudent1.Visible = false;
            // 
            // viewStudent1
            // 
            this.viewStudent1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewStudent1.Location = new System.Drawing.Point(0, 0);
            this.viewStudent1.Name = "viewStudent1";
            this.viewStudent1.Size = new System.Drawing.Size(1231, 667);
            this.viewStudent1.TabIndex = 1;
            this.viewStudent1.Visible = false;
            // 
            // addStudent1
            // 
            this.addStudent1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addStudent1.Location = new System.Drawing.Point(3, 3);
            this.addStudent1.Name = "addStudent1";
            this.addStudent1.Size = new System.Drawing.Size(1231, 667);
            this.addStudent1.TabIndex = 0;
            this.addStudent1.Visible = false;
            // 
            // StudentBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updateStudent1);
            this.Controls.Add(this.viewStudent1);
            this.Controls.Add(this.addStudent1);
            this.Name = "StudentBoard";
            this.Size = new System.Drawing.Size(1231, 667);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private StudentManagement.AddStudent addStudent1;
        private StudentManagement.viewStudent viewStudent1;
        private StudentManagement.UpdateStudent updateStudent1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateStudentbutton;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button viewStudentbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
