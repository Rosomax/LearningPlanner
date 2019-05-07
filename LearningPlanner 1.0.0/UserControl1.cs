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

            // Pobranie z bazy danych losowego cytatu i wypisanie go
            using (Model1 context = new Model1())
            {

                int x = context.Cytaty.Count();


                Random rand = new Random();
                int a = rand.Next(x) + 1;

                var tmp = context.Cytaty.Single(p => p.IDcytatu == a);
                label1.Text = tmp.Tresc;

            }

        }




    }
}
