﻿namespace Library.Management.Setting
{
    partial class Library
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
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.SetChanges = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.changeLogoName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logoOption = new System.Windows.Forms.CheckBox();
            this.LibraryNameOption = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UploadLogo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoImage
            // 
            this.logoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoImage.Location = new System.Drawing.Point(456, 41);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(159, 146);
            this.logoImage.TabIndex = 0;
            this.logoImage.TabStop = false;
            // 
            // SetChanges
            // 
            this.SetChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetChanges.Location = new System.Drawing.Point(680, 450);
            this.SetChanges.Name = "SetChanges";
            this.SetChanges.Size = new System.Drawing.Size(100, 52);
            this.SetChanges.TabIndex = 1;
            this.SetChanges.Text = "Done";
            this.SetChanges.UseVisualStyleBackColor = true;
            this.SetChanges.Click += new System.EventHandler(this.SetChanges_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(795, 450);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 52);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // changeLogoName
            // 
            this.changeLogoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLogoName.Location = new System.Drawing.Point(258, 263);
            this.changeLogoName.Name = "changeLogoName";
            this.changeLogoName.Size = new System.Drawing.Size(273, 24);
            this.changeLogoName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Library Name";
            // 
            // logoOption
            // 
            this.logoOption.AutoSize = true;
            this.logoOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoOption.Location = new System.Drawing.Point(98, 97);
            this.logoOption.Name = "logoOption";
            this.logoOption.Size = new System.Drawing.Size(208, 24);
            this.logoOption.TabIndex = 5;
            this.logoOption.Text = "Change the logo of library";
            this.logoOption.UseVisualStyleBackColor = true;
            // 
            // LibraryNameOption
            // 
            this.LibraryNameOption.AutoSize = true;
            this.LibraryNameOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibraryNameOption.Location = new System.Drawing.Point(98, 221);
            this.LibraryNameOption.Name = "LibraryNameOption";
            this.LibraryNameOption.Size = new System.Drawing.Size(222, 24);
            this.LibraryNameOption.TabIndex = 6;
            this.LibraryNameOption.Text = "Change the name of library.";
            this.LibraryNameOption.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UploadLogo);
            this.panel1.Controls.Add(this.SetChanges);
            this.panel1.Controls.Add(this.LibraryNameOption);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logoOption);
            this.panel1.Controls.Add(this.logoImage);
            this.panel1.Controls.Add(this.changeLogoName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 561);
            this.panel1.TabIndex = 7;
            // 
            // UploadLogo
            // 
            this.UploadLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadLogo.Location = new System.Drawing.Point(470, 193);
            this.UploadLogo.Name = "UploadLogo";
            this.UploadLogo.Size = new System.Drawing.Size(135, 39);
            this.UploadLogo.TabIndex = 1;
            this.UploadLogo.Text = "Upload logo";
            this.UploadLogo.UseVisualStyleBackColor = true;
            this.UploadLogo.Click += new System.EventHandler(this.UploadLogo_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Library";
            this.Size = new System.Drawing.Size(1101, 561);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Button SetChanges;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox changeLogoName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox logoOption;
        private System.Windows.Forms.CheckBox LibraryNameOption;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UploadLogo;
    }
}
