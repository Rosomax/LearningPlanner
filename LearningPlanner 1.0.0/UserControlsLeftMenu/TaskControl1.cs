using System.Drawing;
using System.Windows.Forms;

namespace LearningPlanner_1._0._0
{
    public partial class TaskControl1 : UserControl
    {
        public  TaskControl1()
        {
            InitializeComponent();         
        }

        public void OpenFormTask()
        {
            TaskForm Childform = new TaskForm
            {
                MdiParent = this.ParentForm,
                Dock = DockStyle.Fill

            };
            Childform.Show();

        }
           
            
        // Rysowanie napisu na kontrolce
        private void TaskControl1_Paint(object sender, PaintEventArgs e)
        {            
            SolidBrush zad = new SolidBrush(Color.White);
            Graphics g = this.CreateGraphics();
            FontFamily zadf = new FontFamily("Century Gothic");
            Font zfont = new Font(zadf, 16);
            g.DrawString("Zadanie", zfont, zad, new PointF(93, 35));
            
        }
    }
}
