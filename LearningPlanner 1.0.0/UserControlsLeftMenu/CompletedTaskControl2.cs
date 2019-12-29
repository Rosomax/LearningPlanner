using System.Drawing;
using System.Windows.Forms;

namespace LearningPlanner
{
    public partial class CompletedTaskControl2 : UserControl
    {
        public CompletedTaskControl2()
        {
            InitializeComponent();
            
        }
        
        public void OpenFormCompletedTask()
        {
            CompletedTasksForm Childform = new CompletedTasksForm
            {
                MdiParent = this.ParentForm,
                Dock = DockStyle.Fill
            };
            Childform.Show();
        }
   
            

        private void CompletedTaskControl2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            SolidBrush zad = new SolidBrush(Color.White);
            FontFamily zadf = new FontFamily("Century Gothic");
            Font zfont = new Font(zadf, 16);
            e.Graphics.DrawString("Zakończone\n       Zadania", zfont, zad, new PointF(52, 20));

        }


      

        
    }
}
