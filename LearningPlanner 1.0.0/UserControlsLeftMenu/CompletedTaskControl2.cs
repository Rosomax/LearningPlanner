using System.Drawing;
using System.Windows.Forms;

namespace LearningPlanner_1._0._0
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
            SolidBrush zadz = new SolidBrush(Color.White);
            Graphics g = this.CreateGraphics();
            FontFamily zadza = new FontFamily("Century Gothic");
            Font zfont = new Font(zadza, 16);
            g.DrawString("Zakończone\n       Zadania", zfont, zadz, new PointF(52, 20));
            
        }
    }
}
