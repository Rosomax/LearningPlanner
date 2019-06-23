using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using LearningPlanner_1._0._0.Properties;
using System.Media;
using System.Collections.Generic;
using System.Linq;

namespace LearningPlanner_1._0._0
{


    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
          
        }
       


        private void SettingsForm_Load(object sender, EventArgs e)
        {
            
            SaveColorToSettings();
            SetMusic();
            GetSelectedFont();
            SettingsFormChangeFont();
           

        }

      



        private void SettingsForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            var m = e.Graphics.Transform;
            // rysowanie kola glownego - tarcza zegara
            e.Graphics.FillEllipse(Brushes.AntiqueWhite, 50, 50, 150, 150);
            Pen obramowanie = new Pen(Color.Black, 7);
            e.Graphics.DrawEllipse(obramowanie, 50, 50, 150, 150);

            //ryssowanie srodkowego kolka na zegarku - mocowanie wskazowek
            e.Graphics.FillEllipse(Brushes.Yellow, 120, 120, 10, 10);
            e.Graphics.DrawEllipse(Pens.Black, 120, 120, 10, 10);
            //wskazowka sekundowa
            e.Graphics.TranslateTransform(125, 125);
            e.Graphics.RotateTransform(DateTime.Now.Second * 6);
            e.Graphics.DrawLine(Pens.Red, 0, 0, 0, -35);

            //wskazowka minutowa
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(125, 125);
            e.Graphics.RotateTransform(DateTime.Now.Minute * 6);
            Pen minuta = new Pen(Color.Green, 2);
            e.Graphics.DrawLine(minuta, 0, 0, 0, -25);
            // wskazowka godzinowa
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(125, 125);
            e.Graphics.RotateTransform(DateTime.Now.Hour * 24);
            Pen godzina = new Pen(Color.Black, 3);
            e.Graphics.DrawLine(godzina, 0, 0, 0, -20);

            // Rysowanie czterech glownych kreseczek po kolei polnoc,poludnie,wschod,zachod
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(125, 50);
            e.Graphics.DrawLine(Pens.Black, 0, 0, 0, 23);

            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(125, 200);
            e.Graphics.DrawLine(Pens.Black, 0, 0, 0, -23);

            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(50, 125);
            e.Graphics.DrawLine(Pens.Black, 0, 0, 23, 0);

            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(200, 125);
            e.Graphics.DrawLine(Pens.Black, 0, 0, -23, 0);

            //////// gorna lewa cwiartka 1 mala z prawej
            //e.Graphics.Transform = m;
            //e.Graphics.TranslateTransform(140, 63); 
            //e.Graphics.RotateTransform(60);
            //e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, 17, 0);
            //// gorna lewa cwiartka 2 (srodkowa) mala z prawej
            //e.Graphics.Transform = m;
            //e.Graphics.TranslateTransform(95, 95);
            //e.Graphics.RotateTransform(45);
            //e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, 17, 0);
            //// gorna lewa cwiartka 3 z prawej
            //e.Graphics.Transform = m;
            //e.Graphics.TranslateTransform(63, 140);
            //e.Graphics.RotateTransform(30);
            //e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, 17, 0);

            ////gorna prawa cwiartka 1 mala z lewej
            //e.Graphics.Transform = m;
            //e.Graphics.TranslateTransform(260, 63); //
            //e.Graphics.RotateTransform(120);
            //e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, 17, 0);
            ////gorna prawa cwiartka 2 (srodkowa) z prawej
            //e.Graphics.Transform = m;
            //e.Graphics.TranslateTransform(305, 95);
            //e.Graphics.RotateTransform(-45);
            //e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, -17, 0);
            //// gorna prawa cwiartka 3 z prawej
            //e.Graphics.Transform = m;
            //e.Graphics.TranslateTransform(63, 260);
            //e.Graphics.RotateTransform(-30);
            //e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, 17, 0);

            //////// dolna lewa cwiartka pierwsza mala z prawej
            //e.Graphics.Transform = m;
            //e.Graphics.TranslateTransform(140, 337); //
            //e.Graphics.RotateTransform(120);
            //e.Graphics.DrawLine(Pens.DarkCyan, 0, 0,-17, 0);
            ////dolna lewa cwiartka 2 (srodkowa) mala z prawej
            //e.Graphics.Transform = m;
            //e.Graphics.TranslateTransform(95, 305);
            //e.Graphics.RotateTransform(-45);
            //e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, 17, 0);
            //////// dolna lewa cwiartka trzecia mala z prawej
            //e.Graphics.Transform = m;
            //e.Graphics.TranslateTransform(337, 140); //
            //e.Graphics.RotateTransform(-30);
            //e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, -17, 0);

            ///////dolna prawa cwiartka pierwsza z lewej
            //e.Graphics.Transform = m;
            //e.Graphics.TranslateTransform(260, 337); 
            //e.Graphics.RotateTransform(60);
            //e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, -17, 0);
            //// dolna prawa cwiartka 2 (srodkowa) z lewej
            //e.Graphics.Transform = m;
            //e.Graphics.TranslateTransform(305, 305);
            //e.Graphics.RotateTransform(45);
            //e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, -17, 0);
            ///////dolna prawa cwiartka trzecia z lewej
            //e.Graphics.Transform = m;
            //e.Graphics.TranslateTransform(337, 260); 
            //e.Graphics.RotateTransform(30);
            //e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, -17, 0);      

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();

        }



        private void ChangeColorTimer_Tick(object sender, EventArgs e)
        {
            RtextBox.Text = Convert.ToString(RtrackBar.Value);
            GtextBox.Text = Convert.ToString(GtrackBar.Value);
            BtextBox.Text = Convert.ToString(BtrackBar.Value);

            var red = Convert.ToInt32(RtextBox.Text);
            var green = Convert.ToInt32(GtextBox.Text);
            var blue = Convert.ToInt32(BtextBox.Text);

            this.BackColor = Color.FromArgb(red, green, blue);


        }

       


        private void ChangeBackColorSave()
        {
            Settings.Default.RValue = RtrackBar.Value;
            Settings.Default.GValue = GtrackBar.Value;
            Settings.Default.BValue = BtrackBar.Value;
            Settings.Default.Save();

        }

     

        private void SaveColorToSettings()
        {
            RtrackBar.Value = Settings.Default.RValue;
            GtrackBar.Value = Settings.Default.GValue;
            BtrackBar.Value = Settings.Default.BValue;

        }

        private void saveColorChangesButton_Click(object sender, EventArgs e)
        {
            ChangeBackColorSave();
            MessageBox.Show("Zapisano");

        }

        // Definicja playera
        SoundPlayer player = new SoundPlayer();

        // Metoda ktora odtwarza muzyka, odpala sie w nowym watku
        private void PlayMusic(object music)
        {        
                if (Settings.Default.CalmMusic)
                {
                    player.SoundLocation = "Music\\muz.wav";
                }
                else if (Settings.Default.ClassicMusic)
                {
                    player.SoundLocation = "Music\\classic.wav";
                }
                else if (Settings.Default.RelaxMusic)
                {
                    player.SoundLocation = "Music\\relax.wav";
                }
           
            player.PlayLooping();
        }

        // Metoda przyjmuje wczesniej zdefiniowany player i zatrzymuje muzyke
        private void StopMusic(object music)
        {
         player.Stop();
        }

        

        // Delegat przechowujacyc granie muzyki
      

        // Dodanie play music do watka tla
        public void BackgroundMusic()
        {            
           WaitCallback z = new WaitCallback(PlayMusic);
            ThreadPool.QueueUserWorkItem(z);            
        }
       
    
        // Ustawienie muzyki
        private void SetMusic()
        {
            if (BackgroundMusicCheckBox.Checked = Settings.Default.Music)
            {
                CalmMusicRadioButton.Checked = Settings.Default.CalmMusic;
                ClassicMusicRadioButton.Checked = Settings.Default.ClassicMusic;
                RelaxMusicRadioButton.Checked = Settings.Default.RelaxMusic;
            }


            if (BackgroundMusicCheckBox.Checked)
            {
                VisibleOn();
            }

        }

        // Zapamietanie stanu checkboxa
        private void RememberMusic()
        {
                Settings.Default.Music = BackgroundMusicCheckBox.Checked;
            
                Settings.Default.CalmMusic = CalmMusicRadioButton.Checked;
                Settings.Default.ClassicMusic = ClassicMusicRadioButton.Checked;
                Settings.Default.RelaxMusic = RelaxMusicRadioButton.Checked;
            

            Settings.Default.Save();
        }

        private void DefaultMusicSettings()
        {
            Settings.Default.Music = BackgroundMusicCheckBox.Checked = false;

            Settings.Default.CalmMusic = CalmMusicRadioButton.Checked = false;
            Settings.Default.ClassicMusic = ClassicMusicRadioButton.Checked = false;
            Settings.Default.RelaxMusic = RelaxMusicRadioButton.Checked = false;
        }



      private void VisibleOn()
        {
            CalmMusicRadioButton.Visible = true;
            ClassicMusicRadioButton.Visible = true;
            RelaxMusicRadioButton.Visible = true;
        }
        private void VisibleOff()
        {
            CalmMusicRadioButton.Visible = false;
            ClassicMusicRadioButton.Visible = false;
            RelaxMusicRadioButton.Visible = false;
        }


        private void BackgroundMusicCheckBox_Click(object sender, EventArgs e)
        {
            if (BackgroundMusicCheckBox.CheckState == CheckState.Checked)
            {
                VisibleOn();
                
                RememberMusic();
            }
            if (BackgroundMusicCheckBox.CheckState == CheckState.Unchecked)
            {
                VisibleOff();
                StopMusic(player);
                RememberMusic();
             
            }
                    

        }


        private void CalmMusicRadioButton_Click(object sender, EventArgs e)
        {
            if (CalmMusicRadioButton.Checked)
            {          
                RememberMusic();
                BackgroundMusic();
            }

        }

        private void ClassicMusicRadioButton_Click(object sender, EventArgs e)
        {
            if (ClassicMusicRadioButton.Checked)
            {
                RememberMusic();
                BackgroundMusic();
            }
        }

        private void RelaxMusicRadioButton_Click(object sender, EventArgs e)
        {
            if (RelaxMusicRadioButton.Checked)
            {
            
                RememberMusic();
                BackgroundMusic();
            }
        }












        private void ReportErrorButttom_Click(object sender, EventArgs e)
        {
            ReportErrorForm reportErrorForm = new ReportErrorForm();
            reportErrorForm.Show();
        }



    


        // Przechowywanie wybranego fonta
        string fontName;


        // Ustawienie fonta po wybraniu radio buttona
        public void SetFont()
       {
            if (ArialBlackRadioButton.Checked)
            {
                fontName = "Arial";              
            }
            else if (CalibriRadioButton.Checked)
            {
                fontName = "Calibri";                
            }
            else if (CourierRadioButton.Checked)
            {
                fontName = "Courier New";               
            }
                
            else if (TimesNewRomanRadioButton.Checked)
            {
                fontName = "Times New Roman";             
            }
              
            else if (VerdanaRadioButton.Checked)
            {
                fontName = "Verdana";               
            }
 

           
        }


        // 1
        public void RememberFont()
        {
            Settings.Default.RememberFont = fontName;
            Settings.Default.ArialBlackFont = ArialBlackRadioButton.Checked;
            Settings.Default.CalibriFont = CalibriRadioButton.Checked;
            Settings.Default.CourierFont = CourierRadioButton.Checked;
            Settings.Default.TimesNewRomanFont = TimesNewRomanRadioButton.Checked;
            Settings.Default.VerdanaFont = VerdanaRadioButton.Checked;
            Settings.Default.BoldFont = BoldCheckBox.Checked;
            
            Settings.Default.Save();
        }

        public void GetSelectedFont()
        {
            fontName = Settings.Default.RememberFont;
            ArialBlackRadioButton.Checked = Settings.Default.ArialBlackFont;
            CalibriRadioButton.Checked = Settings.Default.CalibriFont;
            CourierRadioButton.Checked = Settings.Default.CourierFont;
            TimesNewRomanRadioButton.Checked = Settings.Default.TimesNewRomanFont;
            VerdanaRadioButton.Checked = Settings.Default.VerdanaFont;
            BoldCheckBox.Checked = Settings.Default.BoldFont;

        }

        // Zmiana czcionki w aplikacji
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }


       
        

        // SettingsForm
        public void SettingsFormChangeFont()
        {

            foreach (var lbl in GetAll(this, typeof(Label)))
            {
                if(BoldCheckBox.CheckState==CheckState.Unchecked)
                (lbl as Label).Font = new Font(fontName, 14);
                if(BoldCheckBox.CheckState == CheckState.Checked)
                    (lbl as Label).Font = new Font(fontName, 14,FontStyle.Bold);
            }


            foreach (var btn in GetAll(this, typeof(Button)))
            {
                if (BoldCheckBox.CheckState == CheckState.Unchecked)
                    (btn as Button).Font = new Font(fontName, 10);
               if (BoldCheckBox.CheckState == CheckState.Checked)
                    (btn as Button).Font = new Font(fontName, 10,FontStyle.Bold);
            }
          

        }

        private void ArialBlackRadioButton_Click(object sender, EventArgs e)
        {
            if (ArialBlackRadioButton.Checked)
            {
                SetFont();
                SettingsFormChangeFont();
                RememberFont();
            }
        }

        private void CalibriRadioButton_Click(object sender, EventArgs e)
        {
            if (CalibriRadioButton.Checked)
            {
                SetFont();
                SettingsFormChangeFont();
                RememberFont();
            }
        }

        private void CourierRadioButton_Click(object sender, EventArgs e)
        {
            if (CourierRadioButton.Checked)
            {
                SetFont();
                SettingsFormChangeFont();
                RememberFont();
            }
        }

        private void TimesNewRomanRadioButton_Click(object sender, EventArgs e)
        {
            if (TimesNewRomanRadioButton.Checked)
            {
                SetFont();
                SettingsFormChangeFont();
                RememberFont();
            }
        }

        private void VerdanaRadioButton_Click(object sender, EventArgs e)
        {
            if (VerdanaRadioButton.Checked)
            {
                SetFont();
                SettingsFormChangeFont();
                RememberFont();
            }
        }

        private void BoldCheckBox_Click(object sender, EventArgs e)
        {
            if (BoldCheckBox.CheckState == CheckState.Checked)
                SetFont();
            SettingsFormChangeFont();
            RememberFont();
        }

        public void DefaultFontSettings()
        {
            foreach (var lbl in GetAll(this, typeof(Label)))
            {
                (lbl as Label).Font = new Font("Century Gothic", 14);
            }

            foreach (var btn in GetAll(this, typeof(Button)))
            {            
                    (btn as Button).Font = new Font("Century Gothic", 10);                              
            }

            Settings.Default.RememberFont = "Century Gothic";
            Settings.Default.ArialBlackFont = ArialBlackRadioButton.Checked = false;
            Settings.Default.CalibriFont = CalibriRadioButton.Checked = false;
            Settings.Default.CourierFont = CourierRadioButton.Checked = false;
            Settings.Default.TimesNewRomanFont = TimesNewRomanRadioButton.Checked = false;
            Settings.Default.VerdanaFont = VerdanaRadioButton.Checked = false;
            Settings.Default.BoldFont = BoldCheckBox.Checked = false;



        }




        private void defaultColorButton_Click(object sender, EventArgs e)
        {

            RtrackBar.Value = 138;
            GtrackBar.Value = 197;
            BtrackBar.Value = 222;           
            ChangeBackColorSave();

            DefaultFontSettings();
            DefaultMusicSettings();
            StopMusic(0);
            Settings.Default.Save();



        }
    }
}
