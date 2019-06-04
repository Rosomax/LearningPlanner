using System.Drawing;
using System.Windows.Forms;

namespace LearningPlanner_1._0._0
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
            SolidBrush zad = new SolidBrush(Color.White);
            Graphics g = this.CreateGraphics();
            FontFamily zadf = new FontFamily("Century Gothic");
            Font zfont = new Font(zadf, 16);
            g.DrawString("Kategorie", zfont, zad, new PointF(80, 35));
        }
    }
}
