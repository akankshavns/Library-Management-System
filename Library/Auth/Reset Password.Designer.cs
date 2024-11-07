namespace Library.Auth
{
    partial class Reset_Password
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.mailAddress = new System.Windows.Forms.TextBox();
            this.Continue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OTPcheck = new System.Windows.Forms.TextBox();
            this.OTPverifyButton = new System.Windows.Forms.Button();
            this.ResetPssword = new System.Windows.Forms.Panel();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.verifyNewPassword = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ResetPssword.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your email";
            // 
            // mailAddress
            // 
            this.mailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailAddress.Location = new System.Drawing.Point(235, 49);
            this.mailAddress.Name = "mailAddress";
            this.mailAddress.Size = new System.Drawing.Size(375, 30);
            this.mailAddress.TabIndex = 1;
            // 
            // Continue
            // 
            this.Continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.Location = new System.Drawing.Point(484, 85);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(116, 37);
            this.Continue.TabIndex = 2;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Verify OTP";
            // 
            // OTPcheck
            // 
            this.OTPcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPcheck.Location = new System.Drawing.Point(235, 163);
            this.OTPcheck.Name = "OTPcheck";
            this.OTPcheck.Size = new System.Drawing.Size(375, 30);
            this.OTPcheck.TabIndex = 1;
            // 
            // OTPverifyButton
            // 
            this.OTPverifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPverifyButton.Location = new System.Drawing.Point(484, 219);
            this.OTPverifyButton.Name = "OTPverifyButton";
            this.OTPverifyButton.Size = new System.Drawing.Size(116, 37);
            this.OTPverifyButton.TabIndex = 2;
            this.OTPverifyButton.Text = "verify";
            this.OTPverifyButton.UseVisualStyleBackColor = true;
            this.OTPverifyButton.Click += new System.EventHandler(this.OTPverifyButton_Click);
            // 
            // ResetPssword
            // 
            this.ResetPssword.Controls.Add(this.ResetButton);
            this.ResetPssword.Controls.Add(this.verifyNewPassword);
            this.ResetPssword.Controls.Add(this.NewPassword);
            this.ResetPssword.Location = new System.Drawing.Point(73, 293);
            this.ResetPssword.Name = "ResetPssword";
            this.ResetPssword.Size = new System.Drawing.Size(547, 190);
            this.ResetPssword.TabIndex = 4;
            this.ResetPssword.Visible = false;
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(142, 37);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(296, 20);
            this.NewPassword.TabIndex = 0;
            // 
            // verifyNewPassword
            // 
            this.verifyNewPassword.Location = new System.Drawing.Point(142, 95);
            this.verifyNewPassword.Name = "verifyNewPassword";
            this.verifyNewPassword.Size = new System.Drawing.Size(296, 20);
            this.verifyNewPassword.TabIndex = 0;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(354, 138);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Reset_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 554);
            this.Controls.Add(this.ResetPssword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OTPverifyButton);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.OTPcheck);
            this.Controls.Add(this.mailAddress);
            this.Controls.Add(this.label1);
            this.Name = "Reset_Password";
            this.Text = "Reset_Password";
            this.ResetPssword.ResumeLayout(false);
            this.ResetPssword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mailAddress;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OTPcheck;
        private System.Windows.Forms.Button OTPverifyButton;
        private System.Windows.Forms.Panel ResetPssword;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox verifyNewPassword;
        private System.Windows.Forms.TextBox NewPassword;
    }
}