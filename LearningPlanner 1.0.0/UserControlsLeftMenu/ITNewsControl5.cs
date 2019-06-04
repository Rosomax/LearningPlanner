using System.Drawing;
using System.Windows.Forms;

namespace LearningPlanner_1._0._0
{
    public partial class ITNewsControl5 : UserControl
    {
        public ITNewsControl5()
        {
            InitializeComponent();
        }
        public void OpenFormITNews()
        {
            ITNews Childform = new ITNews
            {
                MdiParent = this.ParentForm,
                Dock = DockStyle.Fill
            };
            Childform.Show();
        }

        private void ITNewsControl5_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush zad = new SolidBrush(Color.White);
            Graphics g = this.CreateGraphics();
            FontFamily zadf = new FontFamily("Century Gothic");
            Font zfont = new Font(zadf, 16);
            g.DrawString("Ze świata IT", zfont, zad, new PointF(60, 35));
        }
    }
    
}
