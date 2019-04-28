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
    public partial class ustawieniaControl6 : UserControl
    {
        public ustawieniaControl6()
        {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(178,8,55);
            label1.ForeColor = Color.Black;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            this.Cursor = new Cursor("Resources\\Hand-kursor.cur");
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            UstawieniaForm Childform = new UstawieniaForm();

            Childform.MdiParent = this.ParentForm;
            Childform.Dock = DockStyle.Fill;
            Childform.Show();
        }
    }
}
