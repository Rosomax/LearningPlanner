using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;


namespace LearningPlanner_1._0._0
{


    public partial class MainForm : Form
    {

        public MainForm()
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
        private void ClosePictureBox_Click(object sender, EventArgs e)
        {

            this.Close();

        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {

            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            //AboutLearningPlanner aboutLearningPlanner = new AboutLearningPlanner();
            //aboutLearningPlanner.Show();
        }
        #endregion
        #region PanelMove

        private bool mouseDown;
        private Point lastLocation;


        private void LearningPlannerLabel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void LearningPlannerLabel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void LearningPlannerLabel_MouseMove(object sender, MouseEventArgs e)
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



        private void TaskControl11_MouseClick(object sender, MouseEventArgs e)
        {

            // Resetowanie koloru dla nieaktywnej karty
            ResetColor();
            // Przypisanie do delegata metody
            colorHandler += leftActiveControl1.SetBackColorMethod;
            // wywolanie delegata                   
            colorHandler(leftActiveControl1);
            colorHandler -= leftActiveControl1.SetBackColorMethod;
            taskControl11.OpenFormTask();
        }


        private void CompletedTasksControl21_MouseClick(object sender, MouseEventArgs e)
        {

            ResetColor();
            colorHandler += leftActiveControl2.SetBackColorMethod;
            colorHandler(leftActiveControl2);
            colorHandler -= leftActiveControl2.SetBackColorMethod;
            completedTaskControl21.OpenFormCompletedTask();

        }
        private void CategoryControl31_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            colorHandler += leftActiveControl3.SetBackColorMethod;
            colorHandler(leftActiveControl3);
            colorHandler -= leftActiveControl3.SetBackColorMethod;
            categoryControl31.OpenFormCategory();
        }
        private void FindTaskControl41_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            colorHandler += leftActiveControl4.SetBackColorMethod;
            colorHandler(leftActiveControl4);
            colorHandler -= leftActiveControl4.SetBackColorMethod;
            findTaskControl41.OpenFormFindTask();
        }
        private void ITNewsControl51_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            colorHandler += leftActiveControl5.SetBackColorMethod;
            colorHandler(leftActiveControl5);
            colorHandler -= leftActiveControl5.SetBackColorMethod;
            itnewsControl51.OpenFormITNews();
        }
        private void SettingsControl61_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            colorHandler += leftActiveControl6.SetBackColorMethod;
            colorHandler(leftActiveControl6);
            colorHandler -= leftActiveControl6.SetBackColorMethod;
            settingsControl61.OpenFormSettings();
        }
        // Metoda do resetu koloru
        public void ResetColor()
        {
            foreach (var tmp in LeftActiveControl.controlList)
            {
                tmp.BackColor = Color.Transparent;

            }

        }
        #endregion

        #region Obsluga wejscia i wyjscia myszy na kontrolki - zdarzenia
        private void TaskControl11_MouseEnter_1(object sender, EventArgs e)
        {
            MouseEnterMechanics(taskControl11);
        }

        private void TaskControl11_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(taskControl11);
        }

        private void CompletedTaskControl21_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterMechanics(completedTaskControl21);

        }

        private void CompletedTaskControl21_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(completedTaskControl21);
        }
        private void CategoryControl31_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterMechanics(categoryControl31);
        }

        private void CategoryControl31_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(categoryControl31);
        }
        private void FindTaskControl41_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterMechanics(findTaskControl41);
        }
        private void FindTaskControl41_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(findTaskControl41);
        }
        private void ITNewsControl51_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterMechanics(itnewsControl51);
        }

        private void ITNewsControl51_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(itnewsControl51);
        }

        private void SettingsControl61_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterMechanics(settingsControl61);
        }
        private void SettingsControl61_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(settingsControl61);
        }


        #endregion

        private void MaximilaziPictureBox_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                maximilaziPictureBox.Load("WariantyOkna\\maximize-window.png");
                
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

                maximilaziPictureBox.Load("WariantyOkna\\restore-window.png");
            }




        }

        private void MinimalizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Zmiana widocznosci wpisywanego hasla
        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
                passwordtextBox1.UseSystemPasswordChar = false;
            else
                passwordtextBox1.UseSystemPasswordChar = true;
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            DataBaseLogging();
           
        }

      



        // Id zalogowanego uzytkownika
        public static int UserID { get; private set; }


        private void DataBaseLogging()
        {

            var login = LogintextBox1.Text;
            var password = passwordtextBox1.Text;

            using (EntitiesModel2 x = new EntitiesModel2())
            {

                var user = x.Uzytkownicy.FirstOrDefault(e => e.Login == login);
                if (user != null)
                {
                    if (user.Haslo == password)
                    {
                        MessageBox.Show("Zalogowano");
                        UserID = user.IDosoby;                      
                        panel1.Hide();
                        panel1.Enabled = false;
                        ShowLeftMenu();
                    }

                    else
                        MessageBox.Show("Złe hasło");
                }
                else
                    MessageBox.Show($"Nie znaleziono użytkownika '{login}' ");
               

            }


        }

        private void ShowLeftMenu()
        {
          
            categoryControl31.Enabled = true;          
            completedTaskControl21.Enabled = true;           
            findTaskControl41.Enabled = true;          
            itnewsControl51.Enabled = true;          
            settingsControl61.Enabled = true;          
            taskControl11.Enabled = true;
            maximilaziPictureBox.Enabled = true;
        }

        private void RegisterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Show();
     
            
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
                DataBaseLogging();
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }

  

   
}
   



