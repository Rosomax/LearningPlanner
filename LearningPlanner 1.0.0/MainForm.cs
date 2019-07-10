using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using LearningPlanner.Properties;

namespace LearningPlanner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        #region EventsForTopPanelIcons
        private void MinimalizePictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void MaximilaziPictureBox_Click(object sender, EventArgs e)
        {
   
          

            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                MaximizePictureBox.Load("WindowIcons\\maximize-window.png");

            }
            else

            {
                WindowState = FormWindowState.Maximized;

                MaximizePictureBox.Load("WindowIcons\\restore-window.png");
            }



        }
        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void HomePictureBox_Click(object sender, EventArgs e)
        {
            foreach (Form c in MdiChildren)
            {
                c.Close();
            }

        }
        
        private void Something()
        {
           

            foreach (Form c in MdiChildren)
            {
                if (c.Name == "SettingsForm")
                {
                    MaximizePictureBox.Visible = false;
                    WindowState = FormWindowState.Normal;
                }
                else
                {
                    MaximizePictureBox.Visible = true;
                  
                }
            }

          


        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
           Something();

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

                Update();
            }
        }
        #endregion


        #region ActiveControlChecked


        private void TaskControl11_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            leftActiveControl1.SetBackColorMethod(leftActiveControl1);
            TaskControl.OpenFormTask();
        }

        private void CompletedTasksControl21_MouseClick(object sender, MouseEventArgs e)
        {

            ResetColor();
            leftActiveControl2.SetBackColorMethod(leftActiveControl2);
            CompletedTaskControl.OpenFormCompletedTask();

        }
        private void CategoryControl31_MouseClick(object sender, MouseEventArgs e)
        {

            ResetColor();
            leftActiveControl3.SetBackColorMethod(leftActiveControl3);
            CategoryControl.OpenFormCategory();

        }
        private void FindTaskControl41_MouseClick(object sender, MouseEventArgs e)
        {

            ResetColor();
            leftActiveControl4.SetBackColorMethod(leftActiveControl4);
            FindTaskControl.OpenFormFindTask();
        }
        private void ITNewsControl51_MouseClick(object sender, MouseEventArgs e)
        {

            ResetColor();
            leftActiveControl5.SetBackColorMethod(leftActiveControl5);
            ITNewsControl.OpenFormITNews();
        }
        private void SettingsControl61_MouseClick(object sender, MouseEventArgs e)
        {

            ResetColor();
            leftActiveControl6.SetBackColorMethod(leftActiveControl6);
            SettingsControl.OpenFormSettings();
        }
        // Metoda do resetu koloru
        private void ResetColor()
        {
            foreach (var tmp in LeftActiveControl.controlList)
            {
                tmp.BackColor = Color.Transparent;

            }

        }
        #endregion

        #region ChangeActiveControlView

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


        private void TaskControl11_MouseEnter_1(object sender, EventArgs e)
        {
            MouseEnterMechanics(TaskControl);
        }

        private void TaskControl11_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(TaskControl);
        }

        private void CompletedTaskControl21_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterMechanics(CompletedTaskControl);

        }

        private void CompletedTaskControl21_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(CompletedTaskControl);
        }
        private void CategoryControl31_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterMechanics(CategoryControl);
        }

        private void CategoryControl31_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(CategoryControl);
        }
        private void FindTaskControl41_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterMechanics(FindTaskControl);
        }
        private void FindTaskControl41_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(FindTaskControl);
        }
        private void ITNewsControl51_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterMechanics(ITNewsControl);
        }

        private void ITNewsControl51_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(ITNewsControl);
        }

        private void SettingsControl61_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterMechanics(SettingsControl);
        }
        private void SettingsControl61_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveMechanics(SettingsControl);
        }


        #endregion




        #region LoginToApplication

        public static int UserID { get; private set; }

        private void DataBaseLogging()
        {

            var login = LogintextBox1.Text;
            var password = PasswordTextBox.Text;

            using (EntitiesModel x = new EntitiesModel())
            {

                var user = x.Users.FirstOrDefault(e => e.Login == login);
                if (user != null)
                {
                    if (user.Haslo == password)
                    {
                        MessageBox.Show("Zalogowano");
                        UserID = user.IDosoby;
                        panel1.Hide();
                        panel1.Enabled = false;
                        ShowLeftMenu();
                        RememberCredentials();

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

            CategoryControl.Enabled = true;
            CompletedTaskControl.Enabled = true;
            FindTaskControl.Enabled = true;
            ITNewsControl.Enabled = true;
            SettingsControl.Enabled = true;
            TaskControl.Enabled = true;
            MaximizePictureBox.Enabled = true;
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
        }



        private void LoginButton_Click(object sender, EventArgs e)
        {
            DataBaseLogging();
            SettingsForm sf = new SettingsForm();

            if ((Settings.Default.Music) && (Settings.Default.CalmMusic == true ||
                Settings.Default.ClassicMusic == true || Settings.Default.RelaxMusic == true))
                sf.BackgroundMusic();
        }


        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (panel1.Visible))
            {
                DataBaseLogging();
            }
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }


        private void RememberCredentials()
        {
            if (RememberMeCheckBox.Checked)
                Settings.Default.Login = LogintextBox1.Text;
            Settings.Default.Password = PasswordTextBox.Text;
            Settings.Default.Save();


        }
        private void SetCredentials()
        {

            LogintextBox1.Text = Settings.Default.Login;
            PasswordTextBox.Text = Settings.Default.Password;
        }



        #endregion


       private void RegisterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Show();
        }
     
       private void MainForm_Load(object sender, EventArgs e)
        {
            SetCredentials();

        }
       
    }

}
   



