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
    public partial class ZakonczoneZadaniaForm : Form
    {
        public ZakonczoneZadaniaForm()
        {
            InitializeComponent();
        }

        private void ZakonczoneZadaniaForm_Load(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("Resources\\Kursor.cur");
            this.BackColor = Color.FromArgb(138, 197, 222);

        }



    }
}
