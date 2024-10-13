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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AboutDetail = new System.Windows.Forms.Label();
            this.AccountDetail = new System.Windows.Forms.Label();
            this.LibraryDetail = new System.Windows.Forms.Label();
            this.TransactionDetail = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Transaction = new System.Windows.Forms.Button();
            this.Library = new System.Windows.Forms.Button();
            this.Account = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.transaction1 = new Library.Management.Setting.Transaction();
            this.account1 = new Library.Management.Setting.Account();
            this.library1 = new Library.Management.Setting.Library();
            this.about1 = new Library.Management.Setting.About();
            this.roundPictureBox1 = new Library.Design.RoundPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Setting";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 37);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library.Properties.Resources.Settings1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Name";
            // 
            // AboutDetail
            // 
            this.AboutDetail.AutoSize = true;
            this.AboutDetail.BackColor = System.Drawing.Color.LightSlateGray;
            this.AboutDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutDetail.Location = new System.Drawing.Point(106, 313);
            this.AboutDetail.Name = "AboutDetail";
            this.AboutDetail.Size = new System.Drawing.Size(205, 17);
            this.AboutDetail.TabIndex = 4;
            this.AboutDetail.Text = "About this softwre, memory, etc";
            this.AboutDetail.Click += new System.EventHandler(this.AboutDetail_Click);
            // 
            // AccountDetail
            // 
            this.AccountDetail.AutoSize = true;
            this.AccountDetail.BackColor = System.Drawing.Color.LightSlateGray;
            this.AccountDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountDetail.Location = new System.Drawing.Point(488, 313);
            this.AccountDetail.Name = "AccountDetail";
            this.AccountDetail.Size = new System.Drawing.Size(281, 17);
            this.AccountDetail.TabIndex = 4;
            this.AccountDetail.Text = "Username, profile, Login /Logout Time, etc.";
            this.AccountDetail.Click += new System.EventHandler(this.AccountDetail_Click);
            // 
            // LibraryDetail
            // 
            this.LibraryDetail.AutoSize = true;
            this.LibraryDetail.BackColor = System.Drawing.Color.LightSlateGray;
            this.LibraryDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibraryDetail.Location = new System.Drawing.Point(98, 468);
            this.LibraryDetail.Name = "LibraryDetail";
            this.LibraryDetail.Size = new System.Drawing.Size(133, 17);
            this.LibraryDetail.TabIndex = 4;
            this.LibraryDetail.Text = "Logo, Library Name";
            this.LibraryDetail.Click += new System.EventHandler(this.LibraryDetail_Click);
            // 
            // TransactionDetail
            // 
            this.TransactionDetail.AutoSize = true;
            this.TransactionDetail.BackColor = System.Drawing.Color.LightSlateGray;
            this.TransactionDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionDetail.Location = new System.Drawing.Point(488, 468);
            this.TransactionDetail.Name = "TransactionDetail";
            this.TransactionDetail.Size = new System.Drawing.Size(220, 17);
            this.TransactionDetail.TabIndex = 4;
            this.TransactionDetail.Text = "Fine, Book Return, Student Issue.";
            this.TransactionDetail.Click += new System.EventHandler(this.TransactionDetail_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(177, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Email";
            // 
            // Transaction
            // 
            this.Transaction.BackColor = System.Drawing.Color.LightSlateGray;
            this.Transaction.FlatAppearance.BorderSize = 0;
            this.Transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transaction.Font = new System.Drawing.Font("Mongolian Baiti", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction.Image = global::Library.Properties.Resources.Bill;
            this.Transaction.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Transaction.Location = new System.Drawing.Point(430, 440);
            this.Transaction.Name = "Transaction";
            this.Transaction.Size = new System.Drawing.Size(351, 96);
            this.Transaction.TabIndex = 2;
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
            this.Library.Location = new System.Drawing.Point(44, 440);
            this.Library.Name = "Library";
            this.Library.Size = new System.Drawing.Size(351, 96);
            this.Library.TabIndex = 2;
            this.Library.Text = "Library";
            this.Library.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Library.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Library.UseMnemonic = false;
            this.Library.UseVisualStyleBackColor = false;
            this.Library.Click += new System.EventHandler(this.Library_Click);
            // 
            // Account
            // 
            this.Account.BackColor = System.Drawing.Color.LightSlateGray;
            this.Account.FlatAppearance.BorderSize = 0;
            this.Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Account.Font = new System.Drawing.Font("Mongolian Baiti", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account.Image = global::Library.Properties.Resources.User;
            this.Account.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Account.Location = new System.Drawing.Point(430, 285);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(351, 96);
            this.Account.TabIndex = 2;
            this.Account.Text = "Account";
            this.Account.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Account.UseMnemonic = false;
            this.Account.UseVisualStyleBackColor = false;
            this.Account.Click += new System.EventHandler(this.Account_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Mongolian Baiti", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.Image = global::Library.Properties.Resources.About1;
            this.AboutButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AboutButton.Location = new System.Drawing.Point(44, 285);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(351, 96);
            this.AboutButton.TabIndex = 2;
            this.AboutButton.Text = "About";
            this.AboutButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AboutButton.UseMnemonic = false;
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // transaction1
            // 
            this.transaction1.BackColor = System.Drawing.Color.LightGray;
            this.transaction1.Location = new System.Drawing.Point(758, 0);
            this.transaction1.Name = "transaction1";
            this.transaction1.Size = new System.Drawing.Size(551, 650);
            this.transaction1.TabIndex = 9;
            this.transaction1.Visible = false;
            // 
            // account1
            // 
            this.account1.Location = new System.Drawing.Point(491, 333);
            this.account1.Name = "account1";
            this.account1.Size = new System.Drawing.Size(278, 101);
            this.account1.TabIndex = 8;
            this.account1.Visible = false;
            // 
            // library1
            // 
            this.library1.Location = new System.Drawing.Point(619, 3);
            this.library1.Name = "library1";
            this.library1.Size = new System.Drawing.Size(150, 307);
            this.library1.TabIndex = 7;
            // 
            // about1
            // 
            this.about1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.about1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.about1.Location = new System.Drawing.Point(837, 2);
            this.about1.Name = "about1";
            this.about1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.about1.Size = new System.Drawing.Size(413, 653);
            this.about1.TabIndex = 6;
            this.about1.Visible = false;
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.roundPictureBox1.BackgroundImage = global::Library.Properties.Resources.User;
            this.roundPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundPictureBox1.Location = new System.Drawing.Point(44, 68);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(110, 108);
            this.roundPictureBox1.TabIndex = 5;
            this.roundPictureBox1.TabStop = false;
            // 
            // SettingBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.transaction1);
            this.Controls.Add(this.account1);
            this.Controls.Add(this.library1);
            this.Controls.Add(this.about1);
            this.Controls.Add(this.roundPictureBox1);
            this.Controls.Add(this.AccountDetail);
            this.Controls.Add(this.TransactionDetail);
            this.Controls.Add(this.LibraryDetail);
            this.Controls.Add(this.AboutDetail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Transaction);
            this.Controls.Add(this.Library);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.panel1);
            this.Name = "SettingBoard";
            this.Size = new System.Drawing.Size(1312, 651);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button Account;
        private System.Windows.Forms.Button Library;
        private System.Windows.Forms.Button Transaction;
        private System.Windows.Forms.Label label2;
        private Design.RoundPictureBox roundPictureBox1;
        private System.Windows.Forms.Label AboutDetail;
        private System.Windows.Forms.Label AccountDetail;
        private System.Windows.Forms.Label LibraryDetail;
        private System.Windows.Forms.Label TransactionDetail;
        private System.Windows.Forms.Label label7;
        private Management.Setting.About about1;
        private Management.Setting.Library library1;
        private Management.Setting.Account account1;
        private Management.Setting.Transaction transaction1;
    }
}
