﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class opening : Form
    {
        bool drag = false;
        Point StartPoint = new Point(0, 0);
        public opening()
        {
            InitializeComponent();
        }

        private void open_Tick(object sender, EventArgs e)
        {
            load.Width += 6;
            if (load.Width >= 830)
            {
                open.Stop();
                LoginForm loginPage = new LoginForm();
                loginPage.Show();
                this.Hide();
            }
        }

        private void opening_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - StartPoint.X, p.Y - StartPoint.Y);
            }
        }

        private void opening_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void opening_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            StartPoint = new Point(e.X, e.Y);
        }
    }
}