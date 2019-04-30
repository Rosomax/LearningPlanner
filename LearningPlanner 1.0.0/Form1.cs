﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningPlanner_1._0._0
{
    public partial class mainForm : Form
    {

        public mainForm()
        {

            InitializeComponent();
            zadaniaControl11.MouseEnter += ZadaniaControl11_MouseEnter;
        }

        private void ZadaniaControl11_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ActiveCaption;
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region PanelMove

        private bool mouseDown;
        private Point lastLocation;


        private void learningPlannerLabel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void learningPlannerLabel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void learningPlannerLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        #endregion








        private void pictureBox2_Click(object sender, EventArgs e)
        {

            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
        }

        #region top menu options
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Cursor = new Cursor("Resources\\Hand-kursor.cur");
            pictureBox2.Size = new Size(43, 44);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(41, 42);
        }

        private void closePictureBox_MouseEnter(object sender, EventArgs e)
        {
            closePictureBox.Cursor = new Cursor("Resources\\Hand-kursor.cur");
            closePictureBox.Size = new Size(39, 40);
        }

        private void closePictureBox_MouseLeave(object sender, EventArgs e)
        {
            closePictureBox.Size = new Size(41, 42);
        }
        #endregion

     
    }
}
