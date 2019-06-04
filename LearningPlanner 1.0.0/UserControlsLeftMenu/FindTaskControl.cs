﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningPlanner_1._0._0
{
    public partial class FindTaskControl4 : UserControl
    {
        public FindTaskControl4()
        {
            InitializeComponent();
        }
        public void OpenFormFindTask()
        {
            FindTaskForm Childform = new FindTaskForm
            {
                MdiParent = this.ParentForm,
                Dock = DockStyle.Fill
            };
            Childform.Show();
        }
 
        private void FindTaskControl4_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush zad = new SolidBrush(Color.White);
            Graphics g = this.CreateGraphics();
            FontFamily zadf = new FontFamily("Century Gothic");
            Font zfont = new Font(zadf, 16);
            g.DrawString("   Znajdź\nZadanie", zfont, zad, new PointF(90, 20));
        }
    }
}