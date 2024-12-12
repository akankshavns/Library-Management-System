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
            this.ResetPsswordpanel = new System.Windows.Forms.Panel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.verifyNewPassword = new System.Windows.Forms.TextBox();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ResetPsswordpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your email";
            // 
            // mailAddress
            // 
            this.mailAddress.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailAddress.Location = new System.Drawing.Point(235, 49);
            this.mailAddress.Name = "mailAddress";
            this.mailAddress.Size = new System.Drawing.Size(375, 30);
            this.mailAddress.TabIndex = 1;
            // 
            // Continue
            // 
            this.Continue.BackColor = System.Drawing.Color.Teal;
            this.Continue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.ForeColor = System.Drawing.Color.White;
            this.Continue.Location = new System.Drawing.Point(484, 85);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(116, 37);
            this.Continue.TabIndex = 2;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Verify OTP";
            // 
            // OTPcheck
            // 
            this.OTPcheck.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPcheck.Location = new System.Drawing.Point(180, 39);
            this.OTPcheck.Name = "OTPcheck";
            this.OTPcheck.Size = new System.Drawing.Size(375, 30);
            this.OTPcheck.TabIndex = 1;
            // 
            // OTPverifyButton
            // 
            this.OTPverifyButton.BackColor = System.Drawing.Color.Teal;
            this.OTPverifyButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPverifyButton.ForeColor = System.Drawing.Color.White;
            this.OTPverifyButton.Location = new System.Drawing.Point(476, 87);
            this.OTPverifyButton.Name = "OTPverifyButton";
            this.OTPverifyButton.Size = new System.Drawing.Size(98, 37);
            this.OTPverifyButton.TabIndex = 2;
            this.OTPverifyButton.Text = "Verify";
            this.OTPverifyButton.UseVisualStyleBackColor = false;
            this.OTPverifyButton.Click += new System.EventHandler(this.OTPverifyButton_Click);
            // 
            // ResetPsswordpanel
            // 
            this.ResetPsswordpanel.Controls.Add(this.ResetButton);
            this.ResetPsswordpanel.Controls.Add(this.label4);
            this.ResetPsswordpanel.Controls.Add(this.label3);
            this.ResetPsswordpanel.Controls.Add(this.verifyNewPassword);
            this.ResetPsswordpanel.Controls.Add(this.NewPassword);
            this.ResetPsswordpanel.Location = new System.Drawing.Point(73, 293);
            this.ResetPsswordpanel.Name = "ResetPsswordpanel";
            this.ResetPsswordpanel.Size = new System.Drawing.Size(547, 190);
            this.ResetPsswordpanel.TabIndex = 4;
            this.ResetPsswordpanel.Visible = false;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Teal;
            this.ResetButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(422, 131);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(95, 43);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "confirm your password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter your password";
            // 
            // verifyNewPassword
            // 
            this.verifyNewPassword.Location = new System.Drawing.Point(240, 95);
            this.verifyNewPassword.Name = "verifyNewPassword";
            this.verifyNewPassword.Size = new System.Drawing.Size(296, 20);
            this.verifyNewPassword.TabIndex = 0;
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(241, 38);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(296, 20);
            this.NewPassword.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OTPcheck);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.OTPverifyButton);
            this.panel1.Location = new System.Drawing.Point(35, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 140);
            this.panel1.TabIndex = 5;
            // 
            // Reset_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ResetPsswordpanel);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.mailAddress);
            this.Controls.Add(this.label1);
            this.Name = "Reset_Password";
            this.Text = "Reset_Password";
            this.ResetPsswordpanel.ResumeLayout(false);
            this.ResetPsswordpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel ResetPsswordpanel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox verifyNewPassword;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}