namespace Library.Board
{
    partial class TransactionBoard
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
            this.issueBook1 = new Library.TransactionManagement.issueBook();
            this.returnBook1 = new Library.TransactionManagement.ReturnBook();
            this.viewTransaction1 = new Library.TransactionManagement.viewTransaction();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.IssueList = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.issue = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.Return = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // issueBook1
            // 
            this.issueBook1.Location = new System.Drawing.Point(3, 3);
            this.issueBook1.Name = "issueBook1";
            this.issueBook1.Size = new System.Drawing.Size(1231, 664);
            this.issueBook1.TabIndex = 0;
            this.issueBook1.Visible = false;
            // 
            // returnBook1
            // 
            this.returnBook1.Location = new System.Drawing.Point(3, -1);
            this.returnBook1.Name = "returnBook1";
            this.returnBook1.Size = new System.Drawing.Size(1231, 667);
            this.returnBook1.TabIndex = 1;
            this.returnBook1.Visible = false;
            // 
            // viewTransaction1
            // 
            this.viewTransaction1.Location = new System.Drawing.Point(3, 1);
            this.viewTransaction1.Name = "viewTransaction1";
            this.viewTransaction1.Size = new System.Drawing.Size(1231, 667);
            this.viewTransaction1.TabIndex = 2;
            this.viewTransaction1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 667);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel17);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel15);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1231, 667);
            this.panel2.TabIndex = 4;
            // 
            // panel17
            // 
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Controls.Add(this.IssueList);
            this.panel17.Controls.Add(this.label12);
            this.panel17.Location = new System.Drawing.Point(727, 68);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(199, 167);
            this.panel17.TabIndex = 4;
            // 
            // IssueList
            // 
            this.IssueList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IssueList.Location = new System.Drawing.Point(42, 114);
            this.IssueList.Name = "IssueList";
            this.IssueList.Size = new System.Drawing.Size(95, 38);
            this.IssueList.TabIndex = 2;
            this.IssueList.Text = "Record";
            this.IssueList.UseVisualStyleBackColor = true;
            this.IssueList.Click += new System.EventHandler(this.IssueList_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(6, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Transaction Record";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.issue);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(69, 63);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(181, 167);
            this.panel7.TabIndex = 6;
            // 
            // issue
            // 
            this.issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.issue.Location = new System.Drawing.Point(45, 114);
            this.issue.Name = "issue";
            this.issue.Size = new System.Drawing.Size(95, 38);
            this.issue.TabIndex = 1;
            this.issue.Text = "Issue";
            this.issue.UseVisualStyleBackColor = true;
            this.issue.Click += new System.EventHandler(this.issue_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(45, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "issue Book";
            // 
            // panel15
            // 
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.Return);
            this.panel15.Controls.Add(this.label11);
            this.panel15.Location = new System.Drawing.Point(415, 67);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(181, 167);
            this.panel15.TabIndex = 5;
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Return.Location = new System.Drawing.Point(38, 106);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(95, 38);
            this.Return.TabIndex = 2;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(33, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "Return Book";
            // 
            // TransactionBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.viewTransaction1);
            this.Controls.Add(this.returnBook1);
            this.Controls.Add(this.issueBook1);
            this.Name = "TransactionBoard";
            this.Size = new System.Drawing.Size(1231, 667);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TransactionManagement.issueBook issueBook1;
        private TransactionManagement.ReturnBook returnBook1;
        private TransactionManagement.viewTransaction viewTransaction1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button IssueList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button issue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label label11;
    }
}
