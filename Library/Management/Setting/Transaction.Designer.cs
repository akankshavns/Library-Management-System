namespace Library.Management.Setting
{
    partial class Transaction
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
            this.EnterFine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SetButton = new System.Windows.Forms.Button();
            this.IssuedBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReturnDays = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterFine
            // 
            this.EnterFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterFine.Location = new System.Drawing.Point(318, 135);
            this.EnterFine.Name = "EnterFine";
            this.EnterFine.Size = new System.Drawing.Size(118, 26);
            this.EnterFine.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Per Day Library Fine\r\n";
            // 
            // SetButton
            // 
            this.SetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetButton.Location = new System.Drawing.Point(443, 431);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(94, 61);
            this.SetButton.TabIndex = 4;
            this.SetButton.Text = "Done";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // IssuedBook
            // 
            this.IssuedBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssuedBook.Location = new System.Drawing.Point(553, 225);
            this.IssuedBook.Name = "IssuedBook";
            this.IssuedBook.Size = new System.Drawing.Size(112, 26);
            this.IssuedBook.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Books that can be issued to a student at once.\r\n";
            // 
            // ReturnDays
            // 
            this.ReturnDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDays.Location = new System.Drawing.Point(318, 332);
            this.ReturnDays.Name = "ReturnDays";
            this.ReturnDays.Size = new System.Drawing.Size(118, 26);
            this.ReturnDays.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book return days.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Transaction Setting";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(553, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 61);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReturnDays);
            this.Controls.Add(this.IssuedBook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EnterFine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.label4);
            this.Name = "Transaction";
            this.Size = new System.Drawing.Size(1260, 620);
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EnterFine;
        private System.Windows.Forms.TextBox IssuedBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReturnDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Button button2;
        //    private Library.Design.circularButton FineSetButton;
        //    private Library.Design.circularButton circularButton1;
        //    private Library.Design.circularButton circularButton2;
        //    private Library.Design.circularButton circularButton3;
    }
}
