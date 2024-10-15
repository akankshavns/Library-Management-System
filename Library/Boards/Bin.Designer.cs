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
            this.StudentDeletedItem = new System.Windows.Forms.CheckBox();
            this.BookDeletedItem = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentDeletedItem
            // 
            this.StudentDeletedItem.AutoSize = true;
            this.StudentDeletedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentDeletedItem.Location = new System.Drawing.Point(6, 183);
            this.StudentDeletedItem.Name = "StudentDeletedItem";
            this.StudentDeletedItem.Size = new System.Drawing.Size(238, 29);
            this.StudentDeletedItem.TabIndex = 7;
            this.StudentDeletedItem.Text = "Student Deleted Items...";
            this.StudentDeletedItem.UseVisualStyleBackColor = true;
            // 
            // BookDeletedItem
            // 
            this.BookDeletedItem.AutoSize = true;
            this.BookDeletedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookDeletedItem.Location = new System.Drawing.Point(6, 105);
            this.BookDeletedItem.Name = "BookDeletedItem";
            this.BookDeletedItem.Size = new System.Drawing.Size(215, 29);
            this.BookDeletedItem.TabIndex = 6;
            this.BookDeletedItem.Text = "Book Deleted Items...";
            this.BookDeletedItem.UseVisualStyleBackColor = true;
            this.BookDeletedItem.CheckedChanged += new System.EventHandler(this.BookDeletedItem_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(244, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(993, 454);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Deleted Items...";
            // 
            // Bin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StudentDeletedItem);
            this.Controls.Add(this.BookDeletedItem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Bin";
            this.Size = new System.Drawing.Size(1292, 537);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox StudentDeletedItem;
        private System.Windows.Forms.CheckBox BookDeletedItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}
