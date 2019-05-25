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
    public partial class IntroUserControl : UserControl
    {
        public IntroUserControl()
        {
            InitializeComponent();
            Load += IntroUserControl_Load1;
         
        }

        private void IntroUserControl_Load1(object sender, EventArgs e)
        {
            if(!DesignMode)
            using (Model1 context = new Model1())
            {

                int x = context.Cytaty.Count();


                Random rand = new Random();
                int a = rand.Next(x) + 1;

                var tmp = context.Cytaty.Single(p => p.IDcytatu == a);
                label1.Text = tmp.Tresc;

            }
            
        }

        private void IntroUserControl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
