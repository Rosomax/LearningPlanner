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
    public partial class kategorieControl3 : UserControl
    {
        public kategorieControl3()
        {
            InitializeComponent();
        }

        public void OpenFormKategorie()
        {
            KategorieForm Childform = new KategorieForm();

            Childform.MdiParent = this.ParentForm;
            Childform.Dock = DockStyle.Fill;
            Childform.Show();
        }
        

        #region metodyObslugiMyszy
        // Mouse methods 
        public void MouseEnterMechanics(Control control)
        {
            control.BackColor = Color.FromArgb(178, 8, 55);
            control.ForeColor = Color.Black;
            control.Cursor = new Cursor("Resources\\Hand-kursor.cur");
        }

        public void MouseLeaveMechanics(Control control)
        {
            control.BackColor = Color.Transparent;
            control.ForeColor = Color.White;
        }

        // Events for mouse methods mechanics

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterMechanics(this);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(this);
        }


        

        private void kategorieControl3_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterMechanics(this);
        }

        private void kategorieControl3_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(this);
        }


        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterMechanics(this);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(this);
        }
        
        //click
        private void label1_Click(object sender, EventArgs e)
        {
            kategorie = true;
            OpenFormKategorie();
        }

        private void kategorieControl3_MouseClick(object sender, MouseEventArgs e)
        {
            kategorie = true;
            OpenFormKategorie();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            kategorie = true;
            OpenFormKategorie();
        }

        #endregion
    }
}
