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
    public partial class mainForm : Form
    {
        
        public mainForm()
        {
            
            InitializeComponent();
            zadaniaControl11.MouseEnter += ZadaniaControl11_MouseEnter;
        }
        
        private void ZadaniaControl11_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ActiveCaption;
        }
     
        #region PanelMove

        private bool mouseDown;
        private Point lastLocation;

        // Gdy wskaznik myszy znajdujacy sie nad panelem zostanie wcisniety
        private void TopMainPanel_MouseDown(object sender, MouseEventArgs e)
        {

            mouseDown = true;
            lastLocation = e.Location;

        }
        // Gdy wskaznik myszy zostanie odpuszczony
        private void TopMainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        // Zmiana lokalizacji przy przenoszeniu
        private void TopMainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        #endregion

      
    }
}
