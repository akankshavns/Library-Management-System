using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Design
{
    internal class RoundPictureBox : PictureBox
    {
        private Board.TransactionBoard transactionBoard1;

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath grpath = new GraphicsPath();
            grpath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grpath);
            base.OnPaint(e);
        }

        private void InitializeComponent()
        {
            this.transactionBoard1 = new Library.Board.TransactionBoard();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionBoard1
            // 
            this.transactionBoard1.Location = new System.Drawing.Point(0, 0);
            this.transactionBoard1.Name = "transactionBoard1";
            this.transactionBoard1.Size = new System.Drawing.Size(1231, 667);
            this.transactionBoard1.TabIndex = 0;
       
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

