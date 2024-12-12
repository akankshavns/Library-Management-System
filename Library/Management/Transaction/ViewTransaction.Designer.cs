namespace Library.TransactionManagement
{
    partial class ViewTransaction
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
            this.dataGridViewOfHoldBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewOfReturnBooks = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReminderBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfHoldBooks)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfReturnBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOfHoldBooks
            // 
            this.dataGridViewOfHoldBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOfHoldBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOfHoldBooks.Location = new System.Drawing.Point(17, 87);
            this.dataGridViewOfHoldBooks.Name = "dataGridViewOfHoldBooks";
            this.dataGridViewOfHoldBooks.Size = new System.Drawing.Size(1192, 214);
            this.dataGridViewOfHoldBooks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Issue Book Details...";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Library.Properties.Resources.thisIsFinal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 534);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 133);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ReminderBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1231, 48);
            this.panel2.TabIndex = 3;
            // 
            // dataGridViewOfReturnBooks
            // 
            this.dataGridViewOfReturnBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOfReturnBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOfReturnBooks.Location = new System.Drawing.Point(17, 327);
            this.dataGridViewOfReturnBooks.Name = "dataGridViewOfReturnBooks";
            this.dataGridViewOfReturnBooks.Size = new System.Drawing.Size(1190, 201);
            this.dataGridViewOfReturnBooks.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hold Books Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(11, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Returned Books Details..";
            // 
            // ReminderBtn
            // 
            this.ReminderBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ReminderBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ReminderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReminderBtn.Location = new System.Drawing.Point(1095, 0);
            this.ReminderBtn.Name = "ReminderBtn";
            this.ReminderBtn.Size = new System.Drawing.Size(136, 48);
            this.ReminderBtn.TabIndex = 5;
            this.ReminderBtn.Text = "Send Reminder";
            this.ReminderBtn.UseVisualStyleBackColor = false;
            this.ReminderBtn.Click += new System.EventHandler(this.ReminderBtn_Click);
            // 
            // ViewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewOfReturnBooks);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewOfHoldBooks);
            this.Controls.Add(this.panel2);
            this.Name = "ViewTransaction";
            this.Size = new System.Drawing.Size(1231, 667);
            this.Load += new System.EventHandler(this.ViewTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfHoldBooks)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfReturnBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOfHoldBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewOfReturnBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReminderBtn;
    }
}
