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
    public partial class ZadaniaControl1 : UserControl
    {
        public ZadaniaControl1()
        {
            InitializeComponent();
            
        }
        

        public void OpenFormZadania()
        {
            ZadanieForm Childform = new ZadanieForm();

            Childform.MdiParent = this.ParentForm;
            Childform.Dock = DockStyle.Fill;
            Childform.Show();
            
        }
      

        // Rysowanie napisu na kontrolce
        private void ZadaniaControl1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush zad = new SolidBrush(Color.White);
            Graphics g = this.CreateGraphics();
            FontFamily zadf = new FontFamily("Century Gothic");
            System.Drawing.Font zfont = new System.Drawing.Font(zadf, 16);
            g.DrawString("Zadanie", zfont, zad, new PointF(93, 35));
        }
    }
}
