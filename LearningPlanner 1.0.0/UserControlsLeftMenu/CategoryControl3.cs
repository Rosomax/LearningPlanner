using System.Drawing;
using System.Windows.Forms;

namespace LearningPlanner
{
    public partial class categoryControl3 : UserControl
    {
        public categoryControl3()
        {
            InitializeComponent();
        }

        public void OpenFormCategory()
        {
            CategoryForm Childform = new CategoryForm
            {
                MdiParent = this.ParentForm,
                Dock = DockStyle.Fill
            };
            Childform.Show();
        }

        private void CategoryControl3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            SolidBrush zad = new SolidBrush(Color.White);           
            FontFamily zadf = new FontFamily("Century Gothic");           
            Font zfont = new Font(zadf, 16);
            e.Graphics.DrawString("Kategorie", zfont, zad, new PointF(80, 35));
            
        }
    }
}
