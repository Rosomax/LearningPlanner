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
    public partial class ciekawoskiControl5 : UserControl
    {
        public ciekawoskiControl5()
        {
            InitializeComponent();
        }
        public void OpenFormCiekawostki()
        {
            ZeSwiataIt Childform = new ZeSwiataIt();
            Childform.MdiParent = this.ParentForm;
            Childform.Dock = DockStyle.Fill;
            Childform.Show();
        }

        private void ciekawoskiControl5_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush zad = new SolidBrush(Color.White);
            Graphics g = this.CreateGraphics();
            FontFamily zadf = new FontFamily("Century Gothic");
            System.Drawing.Font zfont = new System.Drawing.Font(zadf, 16);
            g.DrawString("Ze świata IT", zfont, zad, new PointF(60, 35));
        }
    }
    
}
