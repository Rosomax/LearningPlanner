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
    public partial class zakonczoneZadaniaControl2 : UserControl
    {
        public zakonczoneZadaniaControl2()
        {
            InitializeComponent();
            
        }
        
        public void OpenFormZakonczoneZadania()
        {
            ZakonczoneZadaniaForm Childform = new ZakonczoneZadaniaForm();

            Childform.MdiParent = this.ParentForm;
            Childform.Dock = DockStyle.Fill;
            Childform.Show();
        }
   
       
        

        private void zakonczoneZadaniaControl2_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush zadz = new SolidBrush(Color.White);
            Graphics g = this.CreateGraphics();
            FontFamily zadza = new FontFamily("Century Gothic");
            System.Drawing.Font zfont = new System.Drawing.Font(zadza, 16);
            g.DrawString("Zakończone\n       Zadania", zfont, zadz, new PointF(52, 20));
            
        }
    }
}
