namespace Library.Board
{
    partial class SettingBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingBoard));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TransactionDetail = new System.Windows.Forms.Label();
            this.LibraryDetail = new System.Windows.Forms.Label();
            this.Transaction = new System.Windows.Forms.Button();
            this.Library = new System.Windows.Forms.Button();
            this.transaction1 = new Library.Management.Setting.Transaction();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(39, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Setting";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 37);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TransactionDetail
            // 
            this.TransactionDetail.AutoSize = true;
            this.TransactionDetail.BackColor = System.Drawing.Color.LightSlateGray;
            this.TransactionDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionDetail.Location = new System.Drawing.Point(71, 256);
            this.TransactionDetail.Name = "TransactionDetail";
            this.TransactionDetail.Size = new System.Drawing.Size(220, 17);
            this.TransactionDetail.TabIndex = 11;
            this.TransactionDetail.Text = "Fine, Book Return, Student Issue.";
            this.TransactionDetail.Click += new System.EventHandler(this.TransactionDetail_Click);
            // 
            // LibraryDetail
            // 
            this.LibraryDetail.AutoSize = true;
            this.LibraryDetail.BackColor = System.Drawing.Color.LightSlateGray;
            this.LibraryDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibraryDetail.Location = new System.Drawing.Point(67, 136);
            this.LibraryDetail.Name = "LibraryDetail";
            this.LibraryDetail.Size = new System.Drawing.Size(133, 17);
            this.LibraryDetail.TabIndex = 12;
            this.LibraryDetail.Text = "Logo, Library Name";
            this.LibraryDetail.Click += new System.EventHandler(this.LibraryDetail_Click);
            // 
            // Transaction
            // 
            this.Transaction.BackColor = System.Drawing.Color.LightSlateGray;
            this.Transaction.FlatAppearance.BorderSize = 0;
            this.Transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transaction.Font = new System.Drawing.Font("Mongolian Baiti", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction.Image = global::Library.Properties.Resources.Bill;
            this.Transaction.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Transaction.Location = new System.Drawing.Point(13, 224);
            this.Transaction.Name = "Transaction";
            this.Transaction.Size = new System.Drawing.Size(287, 85);
            this.Transaction.TabIndex = 6;
            this.Transaction.Text = "Transaction";
            this.Transaction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Transaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Transaction.UseMnemonic = false;
            this.Transaction.UseVisualStyleBackColor = false;
            this.Transaction.Click += new System.EventHandler(this.Transaction_Click);
            // 
            // Library
            // 
            this.Library.BackColor = System.Drawing.Color.LightSlateGray;
            this.Library.FlatAppearance.BorderSize = 0;
            this.Library.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Library.Font = new System.Drawing.Font("Mongolian Baiti", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Library.Image = global::Library.Properties.Resources.Homework1;
            this.Library.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Library.Location = new System.Drawing.Point(13, 108);
            this.Library.Name = "Library";
            this.Library.Size = new System.Drawing.Size(287, 81);
            this.Library.TabIndex = 7;
            this.Library.Text = "Library";
            this.Library.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Library.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Library.UseMnemonic = false;
            this.Library.UseVisualStyleBackColor = false;
            this.Library.Click += new System.EventHandler(this.Library_Click);
            // 
            // transaction1
            // 
            this.transaction1.Dock = System.Windows.Forms.DockStyle.Right;
            this.transaction1.Location = new System.Drawing.Point(474, 0);
            this.transaction1.Name = "transaction1";
            this.transaction1.Size = new System.Drawing.Size(838, 651);
            this.transaction1.TabIndex = 13;
            // 
            // SettingBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.transaction1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TransactionDetail);
            this.Controls.Add(this.LibraryDetail);
            this.Controls.Add(this.Library);
            this.Controls.Add(this.Transaction);
            this.Name = "SettingBoard";
            this.Size = new System.Drawing.Size(1312, 651);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TransactionDetail;
        private System.Windows.Forms.Label LibraryDetail;
        private System.Windows.Forms.Button Transaction;
        private System.Windows.Forms.Button Library;
        private Management.Setting.Transaction transaction1;
    }
}
