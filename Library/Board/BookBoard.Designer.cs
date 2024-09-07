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
            this.addBook1 = new Library.BookManagement.AddBook();
            this.viewBook1 = new Library.BookManagement.ViewBook();
            this.update1 = new Library.BookManagement.update();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.update = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Add = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.view = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBook1
            // 
            this.addBook1.Location = new System.Drawing.Point(3, 3);
            this.addBook1.Name = "addBook1";
            this.addBook1.Size = new System.Drawing.Size(1228, 661);
            this.addBook1.TabIndex = 0;
            this.addBook1.Visible = false;
            // 
            // viewBook1
            // 
            this.viewBook1.Location = new System.Drawing.Point(3, 3);
            this.viewBook1.Name = "viewBook1";
            this.viewBook1.Size = new System.Drawing.Size(1231, 667);
            this.viewBook1.TabIndex = 1;
            this.viewBook1.Visible = false;
            // 
            // update1
            // 
            this.update1.Location = new System.Drawing.Point(3, 0);
            this.update1.Name = "update1";
            this.update1.Size = new System.Drawing.Size(1231, 667);
            this.update1.TabIndex = 2;
            this.update1.Visible = false;
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
            this.panel17.Controls.Add(this.update);
            this.panel17.Controls.Add(this.label12);
            this.panel17.Location = new System.Drawing.Point(838, 86);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(257, 237);
            this.panel17.TabIndex = 4;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update.Location = new System.Drawing.Point(78, 145);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(95, 38);
            this.update.TabIndex = 2;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(58, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Update Book";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.Add);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(76, 86);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(257, 237);
            this.panel7.TabIndex = 6;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add.Location = new System.Drawing.Point(73, 150);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(95, 38);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(68, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Add Book";
            // 
            // panel15
            // 
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.view);
            this.panel15.Controls.Add(this.label11);
            this.panel15.Location = new System.Drawing.Point(434, 86);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(257, 237);
            this.panel15.TabIndex = 5;
            // 
            // view
            // 
            this.view.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.view.Location = new System.Drawing.Point(75, 146);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(95, 38);
            this.view.TabIndex = 2;
            this.view.Text = "view\r\n";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(70, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "view Book";
            // 
            // BookBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.update1);
            this.Controls.Add(this.viewBook1);
            this.Controls.Add(this.addBook1);
            this.Name = "BookBoard";
            this.Size = new System.Drawing.Size(1231, 667);
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

        private BookManagement.AddBook addBook1;
        private BookManagement.ViewBook viewBook1;
        private BookManagement.update update1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Label label11;
    }
}
