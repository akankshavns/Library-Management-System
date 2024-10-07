namespace Library.Board
{
    partial class BookBoard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.viewBook1 = new Library.BookManagement.ViewBook();
            this.update1 = new Library.BookManagement.update();
            this.addBook1 = new Library.BookManagement.AddBook();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.update);
            this.panel2.Controls.Add(this.Add);
            this.panel2.Controls.Add(this.view);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1384, 81);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Book Management";
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update.Location = new System.Drawing.Point(738, 15);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(125, 56);
            this.update.TabIndex = 7;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click_1);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add.Location = new System.Drawing.Point(381, 15);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(128, 56);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click_1);
            // 
            // view
            // 
            this.view.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.view.Location = new System.Drawing.Point(556, 15);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(133, 56);
            this.view.TabIndex = 6;
            this.view.Text = "view\r\n";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.viewBook1);
            this.panel1.Controls.Add(this.update1);
            this.panel1.Controls.Add(this.addBook1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 714);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Library.Properties.Resources.book;
            this.button1.Location = new System.Drawing.Point(355, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(398, 294);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // viewBook1
            // 
            this.viewBook1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewBook1.Location = new System.Drawing.Point(2, 0);
            this.viewBook1.Name = "viewBook1";
            this.viewBook1.Size = new System.Drawing.Size(1378, 634);
            this.viewBook1.TabIndex = 8;
            // 
            // update1
            // 
            this.update1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.update1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.update1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.update1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.update1.Location = new System.Drawing.Point(0, 0);
            this.update1.Name = "update1";
            this.update1.Size = new System.Drawing.Size(1384, 717);
            this.update1.TabIndex = 7;
            this.update1.Visible = false;
            // 
            // addBook1
            // 
            this.addBook1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBook1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBook1.Location = new System.Drawing.Point(3, 0);
            this.addBook1.Name = "addBook1";
            this.addBook1.Size = new System.Drawing.Size(1381, 714);
            this.addBook1.TabIndex = 9;
            this.addBook1.Visible = false;
            // 
            // BookBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "BookBoard";
            this.Size = new System.Drawing.Size(1384, 798);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private BookManagement.ViewBook viewBook1;
        private BookManagement.update update1;
        private BookManagement.AddBook addBook1;
    }
}
