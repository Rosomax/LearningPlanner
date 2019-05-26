using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningPlanner_1._0._0
{
    public partial class IntroForm1 : Form
    {
        public IntroForm1()
        {
            InitializeComponent();
           
            CreateTimer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        void CreateTimer()
        {
            Timer t1 = new Timer();
            t1.Interval = 500;
            t1.Tick += T1_Tick;
            this.Invalidate();
            t1.Start();
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            button1.Visible = true;
            this.Invalidate();
            
        }
    }
}
