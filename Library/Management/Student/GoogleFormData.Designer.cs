namespace Library.Management.Student
{
    partial class GoogleFormData
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
            this.label1 = new System.Windows.Forms.Label();
            this.ScannerSelection = new System.Windows.Forms.ComboBox();
            this.GetData = new System.Windows.Forms.Button();
            this.ScannerBox = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ScannerSelection);
            this.panel1.Controls.Add(this.GetData);
            this.panel1.Controls.Add(this.ScannerBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 485);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Scanner For";
            // 
            // ScannerSelection
            // 
            this.ScannerSelection.FormattingEnabled = true;
            this.ScannerSelection.Items.AddRange(new object[] {
            "Student",
            "Staff"});
            this.ScannerSelection.Location = new System.Drawing.Point(128, 23);
            this.ScannerSelection.Name = "ScannerSelection";
            this.ScannerSelection.Size = new System.Drawing.Size(121, 21);
            this.ScannerSelection.TabIndex = 6;
            this.ScannerSelection.SelectedIndexChanged += new System.EventHandler(this.ScannerSelection_SelectedIndexChanged_1);
            // 
            // GetData
            // 
            this.GetData.BackColor = System.Drawing.Color.Teal;
            this.GetData.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetData.ForeColor = System.Drawing.Color.White;
            this.GetData.Location = new System.Drawing.Point(279, 391);
            this.GetData.Name = "GetData";
            this.GetData.Size = new System.Drawing.Size(150, 44);
            this.GetData.TabIndex = 5;
            this.GetData.Text = "Get Student Data";
            this.GetData.UseVisualStyleBackColor = false;
            this.GetData.Click += new System.EventHandler(this.GetData_Click);
            // 
            // ScannerBox
            // 
            this.ScannerBox.BackgroundImage = global::Library.Properties.Resources.studentQRCode;
            this.ScannerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ScannerBox.Location = new System.Drawing.Point(205, 71);
            this.ScannerBox.Name = "ScannerBox";
            this.ScannerBox.Size = new System.Drawing.Size(307, 296);
            this.ScannerBox.TabIndex = 4;
            // 
            // GoogleFormData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "GoogleFormData";
            this.Size = new System.Drawing.Size(688, 485);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ScannerSelection;
        private System.Windows.Forms.Button GetData;
        private System.Windows.Forms.Panel ScannerBox;
    }
}
