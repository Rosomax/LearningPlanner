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
            

        }

        private void ZadaniaControl11_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ActiveCaption;
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region PanelMove

        private bool mouseDown;
        private Point lastLocation;


        private void learningPlannerLabel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void learningPlannerLabel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void learningPlannerLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        #endregion



        private void pictureBox2_Click(object sender, EventArgs e)
        {

            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
        }
        // Utworzenie delegata 
       
        SetColorHandler colorHandler;
           
        

        private void zadaniaControl11_MouseClick(object sender, MouseEventArgs e)
        {            
             
               // Resetowanie koloru dla nieaktywnej karty

                ResetColor();
                // Przypisanie do delegata metody
               colorHandler += leftActiveControl1.setBackColorMethod;
                // wywolanie delegata                   
                colorHandler(leftActiveControl1);
                colorHandler -= leftActiveControl1.setBackColorMethod;
                                         
        }


        private void zakonczoneZadaniaControl21_MouseClick(object sender, MouseEventArgs e)
        {            
         
            ResetColor();
            colorHandler += leftActiveControl2.setBackColorMethod;
            colorHandler(leftActiveControl2);
            colorHandler -= leftActiveControl2.setBackColorMethod;
            zakonczoneZadaniaControl21.OpenFormZakonczoneZadania();
            
        }

        // Metoda do resetu koloru
        public void ResetColor()
        {
            foreach (var tmp in LeftActiveControl.controlList)
            {
                tmp.BackColor = Color.Transparent;
                this.Refresh();
            }

        }



    }
   


}
