namespace Library.BookManagement
{
    partial class ViewBook
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updateSectionButton = new Library.Design.RoundPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.updateSection = new System.Windows.Forms.Panel();
            this.catagory = new System.Windows.Forms.ComboBox();
            this.purchaseDate = new System.Windows.Forms.DateTimePicker();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.BookQuantity = new System.Windows.Forms.TextBox();
            this.BookPrice = new System.Windows.Forms.TextBox();
            this.Languages = new System.Windows.Forms.TextBox();
            this.NumOfPages = new System.Windows.Forms.TextBox();
            this.BValume = new System.Windows.Forms.TextBox();
            this.BookPublication = new System.Windows.Forms.TextBox();
            this.AuthorName = new System.Windows.Forms.TextBox();
            this.BookName = new System.Windows.Forms.TextBox();
            this.AcccessionID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateSectionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.updateSection.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 381);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SearchBox.Location = new System.Drawing.Point(35, 19);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(207, 27);
            this.SearchBox.TabIndex = 24;
            this.SearchBox.Text = "Search.....";
            this.SearchBox.Click += new System.EventHandler(this.SearchBox_Click);
         
            this.SearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.updateSectionButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.SearchBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1236, 68);
            this.panel2.TabIndex = 23;
            // 
            // updateSectionButton
            // 
            this.updateSectionButton.BackgroundImage = global::Library.Properties.Resources.updatebutton;
            this.updateSectionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateSectionButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateSectionButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.updateSectionButton.Location = new System.Drawing.Point(1117, 0);
            this.updateSectionButton.Name = "updateSectionButton";
            this.updateSectionButton.Size = new System.Drawing.Size(117, 66);
            this.updateSectionButton.TabIndex = 28;
            this.updateSectionButton.TabStop = false;
            this.updateSectionButton.Click += new System.EventHandler(this.updateSectionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(420, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 35);
            this.label1.TabIndex = 27;
            this.label1.Text = "Library Books Recods...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Library.Properties.Resources.Search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(10, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 27);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // updateSection
            // 
            this.updateSection.Controls.Add(this.catagory);
            this.updateSection.Controls.Add(this.purchaseDate);
            this.updateSection.Controls.Add(this.Updatebutton);
            this.updateSection.Controls.Add(this.BookQuantity);
            this.updateSection.Controls.Add(this.BookPrice);
            this.updateSection.Controls.Add(this.Languages);
            this.updateSection.Controls.Add(this.NumOfPages);
            this.updateSection.Controls.Add(this.BValume);
            this.updateSection.Controls.Add(this.BookPublication);
            this.updateSection.Controls.Add(this.AuthorName);
            this.updateSection.Controls.Add(this.BookName);
            this.updateSection.Controls.Add(this.AcccessionID);
            this.updateSection.Controls.Add(this.label15);
            this.updateSection.Controls.Add(this.label6);
            this.updateSection.Controls.Add(this.label7);
            this.updateSection.Controls.Add(this.label14);
            this.updateSection.Controls.Add(this.label5);
            this.updateSection.Controls.Add(this.label10);
            this.updateSection.Controls.Add(this.label9);
            this.updateSection.Controls.Add(this.label3);
            this.updateSection.Controls.Add(this.label2);
            this.updateSection.Controls.Add(this.label4);
            this.updateSection.Controls.Add(this.label8);
            this.updateSection.Dock = System.Windows.Forms.DockStyle.Right;
            this.updateSection.Location = new System.Drawing.Point(814, 0);
            this.updateSection.Name = "updateSection";
            this.updateSection.Size = new System.Drawing.Size(422, 393);
            this.updateSection.TabIndex = 24;
            this.updateSection.Visible = false;
            // 
            // catagory
            // 
            this.catagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagory.FormattingEnabled = true;
            this.catagory.Items.AddRange(new object[] {
            "Subjective/Acadmic Book",
            "Magagin",
            "News Paper",
            "Non-Fiction",
            "Fiction",
            "Comics",
            "Children’s Books",
            "Comics and Graphic Novels",
            "Technology and Computers",
            "Hobbies and Interests",
            "Health and Wellness",
            "Business and Economics",
            "Religious/Spiritual",
            "",
            "",
            "",
            ""});
            this.catagory.Location = new System.Drawing.Point(232, 327);
            this.catagory.Name = "catagory";
            this.catagory.Size = new System.Drawing.Size(171, 28);
            this.catagory.TabIndex = 84;
            // 
            // purchaseDate
            // 
            this.purchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDate.Location = new System.Drawing.Point(232, 231);
            this.purchaseDate.Name = "purchaseDate";
            this.purchaseDate.Size = new System.Drawing.Size(171, 26);
            this.purchaseDate.TabIndex = 57;
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.Color.Teal;
            this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.ForeColor = System.Drawing.Color.White;
            this.Updatebutton.Location = new System.Drawing.Point(128, 368);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(131, 44);
            this.Updatebutton.TabIndex = 56;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // BookQuantity
            // 
            this.BookQuantity.Enabled = false;
            this.BookQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookQuantity.Location = new System.Drawing.Point(232, 295);
            this.BookQuantity.Name = "BookQuantity";
            this.BookQuantity.Size = new System.Drawing.Size(171, 26);
            this.BookQuantity.TabIndex = 55;
            // 
            // BookPrice
            // 
            this.BookPrice.Enabled = false;
            this.BookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookPrice.Location = new System.Drawing.Point(232, 264);
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.Size = new System.Drawing.Size(171, 26);
            this.BookPrice.TabIndex = 55;
            // 
            // Languages
            // 
            this.Languages.Enabled = false;
            this.Languages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Languages.Location = new System.Drawing.Point(232, 199);
            this.Languages.Name = "Languages";
            this.Languages.Size = new System.Drawing.Size(171, 26);
            this.Languages.TabIndex = 55;
            // 
            // NumOfPages
            // 
            this.NumOfPages.Enabled = false;
            this.NumOfPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfPages.Location = new System.Drawing.Point(232, 170);
            this.NumOfPages.Name = "NumOfPages";
            this.NumOfPages.Size = new System.Drawing.Size(171, 26);
            this.NumOfPages.TabIndex = 55;
            // 
            // BValume
            // 
            this.BValume.Enabled = false;
            this.BValume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BValume.Location = new System.Drawing.Point(232, 140);
            this.BValume.Name = "BValume";
            this.BValume.Size = new System.Drawing.Size(171, 26);
            this.BValume.TabIndex = 55;
            // 
            // BookPublication
            // 
            this.BookPublication.Enabled = false;
            this.BookPublication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookPublication.Location = new System.Drawing.Point(232, 109);
            this.BookPublication.Name = "BookPublication";
            this.BookPublication.Size = new System.Drawing.Size(171, 26);
            this.BookPublication.TabIndex = 55;
            // 
            // AuthorName
            // 
            this.AuthorName.Enabled = false;
            this.AuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorName.Location = new System.Drawing.Point(232, 77);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(171, 26);
            this.AuthorName.TabIndex = 55;
            // 
            // BookName
            // 
            this.BookName.Enabled = false;
            this.BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookName.Location = new System.Drawing.Point(232, 45);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(171, 26);
            this.BookName.TabIndex = 55;
            // 
            // AcccessionID
            // 
            this.AcccessionID.Enabled = false;
            this.AcccessionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcccessionID.Location = new System.Drawing.Point(232, 13);
            this.AcccessionID.Name = "AcccessionID";
            this.AcccessionID.Size = new System.Drawing.Size(171, 26);
            this.AcccessionID.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label15.Location = new System.Drawing.Point(16, 322);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 25);
            this.label15.TabIndex = 54;
            this.label15.Text = "Catogory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(15, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 53;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label7.Location = new System.Drawing.Point(16, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 52;
            this.label7.Text = "Price";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label14.Location = new System.Drawing.Point(15, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 25);
            this.label14.TabIndex = 51;
            this.label14.Text = "Language";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(15, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 48;
            this.label5.Text = "Buy Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label10.Location = new System.Drawing.Point(16, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 25);
            this.label10.TabIndex = 50;
            this.label10.Text = "Pages";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label9.Location = new System.Drawing.Point(15, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 49;
            this.label9.Text = "Volume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Publication";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Author Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(16, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Book Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label8.Location = new System.Drawing.Point(16, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 25);
            this.label8.TabIndex = 45;
            this.label8.Text = "Accession Number(ID)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BackgroundImage = global::Library.Properties.Resources.thisIsFinal;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 99);
            this.panel1.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.updateSection);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1236, 393);
            this.panel3.TabIndex = 26;
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ViewBook";
            this.Size = new System.Drawing.Size(1236, 560);
            this.Load += new System.EventHandler(this.ViewBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateSectionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.updateSection.ResumeLayout(false);
            this.updateSection.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Design.RoundPictureBox updateSectionButton;
        private System.Windows.Forms.Panel updateSection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BookQuantity;
        private System.Windows.Forms.TextBox BookPrice;
        private System.Windows.Forms.TextBox Languages;
        private System.Windows.Forms.TextBox NumOfPages;
        private System.Windows.Forms.TextBox BValume;
        private System.Windows.Forms.TextBox BookPublication;
        private System.Windows.Forms.TextBox AuthorName;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.TextBox AcccessionID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.DateTimePicker purchaseDate;
        private System.Windows.Forms.ComboBox catagory;
    }
}
