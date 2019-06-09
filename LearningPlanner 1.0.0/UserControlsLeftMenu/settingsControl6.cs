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
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            SolidBrush zad = new SolidBrush(Color.White);           
            FontFamily zadf = new FontFamily("Century Gothic");           
            Font zfont = new Font(zadf, 16);
            e.Graphics.DrawString("Ustawienia", zfont, zad, new PointF(68, 35));
        }
    }
}
