namespace Library.Boards
{
    partial class Bin
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
            this.BookGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BookGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BookGridView1
            // 
            this.BookGridView1.AllowUserToAddRows = false;
            this.BookGridView1.AllowUserToDeleteRows = false;
            this.BookGridView1.AllowUserToOrderColumns = true;
            this.BookGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.BookGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookGridView1.Location = new System.Drawing.Point(61, 54);
            this.BookGridView1.Name = "BookGridView1";
            this.BookGridView1.Size = new System.Drawing.Size(993, 276);
            this.BookGridView1.TabIndex = 5;
            this.BookGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Deleted Items...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Book Deleted Items...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student Deleted Items...";
            // 
            // StudentGridView2
            // 
            this.StudentGridView2.AllowUserToAddRows = false;
            this.StudentGridView2.AllowUserToDeleteRows = false;
            this.StudentGridView2.AllowUserToOrderColumns = true;
            this.StudentGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.StudentGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView2.Location = new System.Drawing.Point(61, 408);
            this.StudentGridView2.Name = "StudentGridView2";
            this.StudentGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentGridView2.Size = new System.Drawing.Size(993, 276);
            this.StudentGridView2.TabIndex = 5;
            this.StudentGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGridView2_CellDoubleClick);
            // 
            // Bin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StudentGridView2);
            this.Controls.Add(this.BookGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bin";
            this.Size = new System.Drawing.Size(1122, 702);
            this.Load += new System.EventHandler(this.Bin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView BookGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView StudentGridView2;
    }
}
