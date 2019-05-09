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

        #endregion

        #region obsluga ikon na gornym pasku
        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // AboutLearningPlanner aboutLearningPlanner = new AboutLearningPlanner();
            //  aboutLearningPlanner.Show();
        }
        #endregion
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



        #region Delegat zaznaczajacy prostokat oraz obsluga kontrolek pod klik (z lewego  paska)
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
            zadaniaControl11.OpenFormZadania();
        }


        private void zakonczoneZadaniaControl21_MouseClick(object sender, MouseEventArgs e)
        {

            ResetColor();
            colorHandler += leftActiveControl2.setBackColorMethod;
            colorHandler(leftActiveControl2);
            colorHandler -= leftActiveControl2.setBackColorMethod;
            zakonczoneZadaniaControl21.OpenFormZakonczoneZadania();

        }
        private void kategorieControl31_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            colorHandler += leftActiveControl3.setBackColorMethod;
            colorHandler(leftActiveControl3);
            colorHandler -= leftActiveControl3.setBackColorMethod;
            kategorieControl31.OpenFormKategorie();
        }
        private void znajdzZadanieControl41_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            colorHandler += leftActiveControl4.setBackColorMethod;
            colorHandler(leftActiveControl4);
            colorHandler -= leftActiveControl4.setBackColorMethod;
            znajdzZadanieControl41.OpenFormZnajdzZadanie();
        }
        private void ciekawoskiControl51_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            colorHandler += leftActiveControl5.setBackColorMethod;
            colorHandler(leftActiveControl5);
            colorHandler -= leftActiveControl5.setBackColorMethod;
            ciekawoskiControl51.OpenFormCiekawostki();
        }
        private void ustawieniaControl61_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            colorHandler += leftActiveControl6.setBackColorMethod;
            colorHandler(leftActiveControl6);
            colorHandler -= leftActiveControl6.setBackColorMethod;
            ustawieniaControl61.OpenFormUstawienia();
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
        #endregion

        #region Obsluga wejscia i wyjscia myszy na kontrolki - zdarzenia
        private void zadaniaControl11_MouseEnter_1(object sender, EventArgs e)
        {
            MouseEnterMechanics(zadaniaControl11);
        }

        private void zadaniaControl11_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(zadaniaControl11);
        }

        private void zakonczoneZadaniaControl21_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterMechanics(zakonczoneZadaniaControl21);

        }

        private void zakonczoneZadaniaControl21_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(zakonczoneZadaniaControl21);
        }
        private void kategorieControl31_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterMechanics(kategorieControl31);
        }

        private void kategorieControl31_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(kategorieControl31);
        }
        private void znajdzZadanieControl41_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterMechanics(znajdzZadanieControl41);
        }
        private void znajdzZadanieControl41_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(znajdzZadanieControl41);
        }
        private void ciekawoskiControl51_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterMechanics(ciekawoskiControl51);
        }

        private void ciekawoskiControl51_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(ciekawoskiControl51);
        }

        private void ustawieniaControl61_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterMechanics(ustawieniaControl61);
        }
        private void ustawieniaControl61_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(ustawieniaControl61);
        }


        #endregion

        private void maximilaziPictureBox_Click(object sender, EventArgs e)
        {
            
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                maximilaziPictureBox.Load("Resources\\maximize-window.png");
            }
            else if(this.WindowState==FormWindowState.Normal )
            {
                this.WindowState = FormWindowState.Maximized;
                
                maximilaziPictureBox.Load("Resources\\restore-window.png");
            }
        }

        private void minimalizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}




