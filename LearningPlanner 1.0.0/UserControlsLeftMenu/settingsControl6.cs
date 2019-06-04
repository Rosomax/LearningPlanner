using System.Drawing;
using System.Windows.Forms;

namespace LearningPlanner_1._0._0
{
    public partial class SettingsControl6 : UserControl
    {
        public SettingsControl6()
        {
            InitializeComponent();
        }

        public void OpenFormSettings()
        {
            SettingsForm Childform = new SettingsForm
            {
                MdiParent = this.ParentForm,
                Dock = DockStyle.Fill
            };
            Childform.Show();
        }
        
        

        private void SettingsControl6_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush zad = new SolidBrush(Color.White);
            Graphics g = this.CreateGraphics();
            FontFamily zadf = new FontFamily("Century Gothic");
            Font zfont = new Font(zadf, 16);
            g.DrawString("Ustawienia", zfont, zad, new PointF(68, 35));
        }
    }
}
