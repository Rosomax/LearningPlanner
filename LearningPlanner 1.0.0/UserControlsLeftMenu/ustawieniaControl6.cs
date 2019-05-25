using System;
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
    public partial class ustawieniaControl6 : UserControl
    {
        public ustawieniaControl6()
        {
            InitializeComponent();
        }

        public void OpenFormUstawienia()
        {
            UstawieniaForm Childform = new UstawieniaForm();
            Childform.MdiParent = this.ParentForm;
            Childform.Dock = DockStyle.Fill;
            Childform.Show();
        }
        
        

        private void ustawieniaControl6_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush zad = new SolidBrush(Color.White);
            Graphics g = this.CreateGraphics();
            FontFamily zadf = new FontFamily("Century Gothic");
            System.Drawing.Font zfont = new System.Drawing.Font(zadf, 16);
            g.DrawString("Ustawienia", zfont, zad, new PointF(68, 35));
        }
    }
}
