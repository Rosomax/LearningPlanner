using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using LearningPlanner.Properties;
using System.Media;
using System.Collections.Generic;
using System.Linq;

namespace LearningPlanner
{

    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();                    
        }
       
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            SetColorFromSettings();
            SetMusicFromSettings();
            SetFontFromSettings();
            SettingsFormChangeFont();
        }    
        
        private void SettingsForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            var m = e.Graphics.Transform;
            // rysowanie kola glownego - tarcza zegara
            e.Graphics.FillEllipse(Brushes.AntiqueWhite, 40, 60, 150, 150);
            Pen obramowanie = new Pen(Color.Black, 7);
            e.Graphics.DrawEllipse(obramowanie, 40, 60, 150, 150);

            //ryssowanie srodkowego kolka na zegarku - mocowanie wskazowek
            e.Graphics.FillEllipse(Brushes.Yellow, 110, 130, 10, 10);
            e.Graphics.DrawEllipse(Pens.Black, 110, 130, 10, 10);
            //wskazowka sekundowa
            e.Graphics.TranslateTransform(115, 135);
            e.Graphics.RotateTransform(DateTime.Now.Second * 6);
            e.Graphics.DrawLine(Pens.Red, 0, 0, 0, -35);

            //wskazowka minutowa
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(115, 135);
            e.Graphics.RotateTransform(DateTime.Now.Minute * 6);
            Pen minuta = new Pen(Color.Green, 2);
            e.Graphics.DrawLine(minuta, 0, 0, 0, -25);
            // wskazowka godzinowa
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(115, 135);
            e.Graphics.RotateTransform(DateTime.Now.Hour * 24);
            Pen godzina = new Pen(Color.Black, 3);
            e.Graphics.DrawLine(godzina, 0, 0, 0, -20);

            // Rysowanie czterech glownych kreseczek po kolei polnoc,poludnie,wschod,zachod
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(115, 60);
            e.Graphics.DrawLine(Pens.Black, 0, 0, 0, 23);

            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(115, 210);
            e.Graphics.DrawLine(Pens.Black, 0, 0, 0, -23);

            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(40, 135);
            e.Graphics.DrawLine(Pens.Black, 0, 0, 23, 0);

            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(190, 135);
            e.Graphics.DrawLine(Pens.Black, 0, 0, -23, 0);
            
            string drawString = "Settings";
            Font drawFont = new Font("Century Gothic", 18, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float x = 355.0F;
            float y = 130.0F;
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(x, y);
            e.Graphics.RotateTransform(rotate);
            e.Graphics.DrawString(drawString, drawFont, drawBrush, 0, 0, drawFormat);

        }


        #region ColorMethods

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

            BackColor = Color.FromArgb(red, green, blue);
        }


        private void SaveBackColorChanges()
        {
            Settings.Default.RValue = RtrackBar.Value;
            Settings.Default.GValue = GtrackBar.Value;
            Settings.Default.BValue = BtrackBar.Value;
            Settings.Default.Save();
        }

     
        private void SetColorFromSettings()
        {
            RtrackBar.Value = Settings.Default.RValue;
            GtrackBar.Value = Settings.Default.GValue;
            BtrackBar.Value = Settings.Default.BValue;
        }

        private void SaveColorChangesButton_Click(object sender, EventArgs e)
        {
            SaveBackColorChanges();
            MessageBox.Show("Zapisano");
        }

        #endregion


        #region MusicMethods

        SoundPlayer player = new SoundPlayer();
    
        private void PlayCheckedMusic(object music)
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

      
        private void StopMusic(object music)
        {
            player.Stop();
        }
       
       public void BackgroundMusic()
        {            
           WaitCallback waitCallback = new WaitCallback(PlayCheckedMusic);
            ThreadPool.QueueUserWorkItem(waitCallback);            
        }
                   
        private void SetMusicFromSettings()
        {
            if (BackgroundMusicCheckBox.Checked = Settings.Default.Music)
            {
                CalmMusicRadioButton.Checked = Settings.Default.CalmMusic;
                ClassicMusicRadioButton.Checked = Settings.Default.ClassicMusic;
                RelaxMusicRadioButton.Checked = Settings.Default.RelaxMusic;

                RadioBtnsVisibleOn();
            }
        }
        
        private void SaveMusicStatusToSettings()
        {
                Settings.Default.Music = BackgroundMusicCheckBox.Checked;
            
                Settings.Default.CalmMusic = CalmMusicRadioButton.Checked;
                Settings.Default.ClassicMusic = ClassicMusicRadioButton.Checked;
                Settings.Default.RelaxMusic = RelaxMusicRadioButton.Checked;
            

            Settings.Default.Save();
        }

        private void SaveDefaultMusicStatusSettings()
        {
            Settings.Default.Music = BackgroundMusicCheckBox.Checked = false;

            Settings.Default.CalmMusic = CalmMusicRadioButton.Checked = false;
            Settings.Default.ClassicMusic = ClassicMusicRadioButton.Checked = false;
            Settings.Default.RelaxMusic = RelaxMusicRadioButton.Checked = false;
        }

        private void RadioBtnsVisibleOn()
        {
            CalmMusicRadioButton.Visible = true;
            ClassicMusicRadioButton.Visible = true;
            RelaxMusicRadioButton.Visible = true;
        }

        private void RadioBtnsVisibleOff()
        {
            CalmMusicRadioButton.Visible = false;
            ClassicMusicRadioButton.Visible = false;
            RelaxMusicRadioButton.Visible = false;
        }

        private void BackgroundMusicCheckBox_Click(object sender, EventArgs e)
        {
            if (BackgroundMusicCheckBox.CheckState == CheckState.Checked)
            {
                RadioBtnsVisibleOn();
                SaveMusicStatusToSettings();
            }

            if (BackgroundMusicCheckBox.CheckState == CheckState.Unchecked)
            {
                RadioBtnsVisibleOff();
                StopMusic(player);
                SaveMusicStatusToSettings();
            }
                    
        }

        private void CalmMusicRadioButton_Click(object sender, EventArgs e)
        {
            if (CalmMusicRadioButton.Checked)
            {
                SaveMusicStatusToSettings();
                BackgroundMusic();
            }

        }

        private void ClassicMusicRadioButton_Click(object sender, EventArgs e)
        {
            if (ClassicMusicRadioButton.Checked)
            {
                SaveMusicStatusToSettings();
                BackgroundMusic();
            }
        }

        private void RelaxMusicRadioButton_Click(object sender, EventArgs e)
        {
            if (RelaxMusicRadioButton.Checked)
            {
                SaveMusicStatusToSettings();
                BackgroundMusic();
            }
        }

        #endregion



        #region FontMethods


        string fontName;
      
        private void SetCheckedFont()
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

       
        public void SaveFontStatusToSettings()
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

        public void SetFontFromSettings()
        {
            fontName = Settings.Default.RememberFont;
            ArialBlackRadioButton.Checked = Settings.Default.ArialBlackFont;
            CalibriRadioButton.Checked = Settings.Default.CalibriFont;
            CourierRadioButton.Checked = Settings.Default.CourierFont;
            TimesNewRomanRadioButton.Checked = Settings.Default.TimesNewRomanFont;
            VerdanaRadioButton.Checked = Settings.Default.VerdanaFont;
            BoldCheckBox.Checked = Settings.Default.BoldFont;
        }

        




            private void ArialBlackRadioButton_Click(object sender, EventArgs e)
            {
                if (ArialBlackRadioButton.Checked)
                {
                    SetCheckedFont();
                    SettingsFormChangeFont();
                    SaveFontStatusToSettings();
                }
            }

            private void CalibriRadioButton_Click(object sender, EventArgs e)
            {
                if (CalibriRadioButton.Checked)
                {
                    SetCheckedFont();
                    SettingsFormChangeFont();
                    SaveFontStatusToSettings();
                }
            }

            private void CourierRadioButton_Click(object sender, EventArgs e)
            {
                if (CourierRadioButton.Checked)
                {
                    SetCheckedFont();
                    SettingsFormChangeFont();
                    SaveFontStatusToSettings();
                }
            }

            private void TimesNewRomanRadioButton_Click(object sender, EventArgs e)
            {
                if (TimesNewRomanRadioButton.Checked)
                {
                    SetCheckedFont();
                    SettingsFormChangeFont();
                    SaveFontStatusToSettings();
                }
            }

            private void VerdanaRadioButton_Click(object sender, EventArgs e)
            {
                if (VerdanaRadioButton.Checked)
                {
                    SetCheckedFont();
                    SettingsFormChangeFont();
                    SaveFontStatusToSettings();
                }
            }


        private void BoldCheckBox_Click(object sender, EventArgs e)
        {
            if (BoldCheckBox.CheckState == CheckState.Checked)
                SetCheckedFont();
            SettingsFormChangeFont();
            SaveFontStatusToSettings();
        }



        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }


        public void SettingsFormChangeFont()
        {

            foreach (var lbl in GetAll(this, typeof(Label)))
            {
                if (BoldCheckBox.CheckState == CheckState.Unchecked)
                    (lbl as Label).Font = new Font(fontName, 14);
                if (BoldCheckBox.CheckState == CheckState.Checked)
                    (lbl as Label).Font = new Font(fontName, 14, FontStyle.Bold);
            }


            foreach (var btn in GetAll(this, typeof(Button)))
            {
                if (BoldCheckBox.CheckState == CheckState.Unchecked)
                    (btn as Button).Font = new Font(fontName, 10);
                if (BoldCheckBox.CheckState == CheckState.Checked)
                    (btn as Button).Font = new Font(fontName, 10, FontStyle.Bold);
            }


        }




        public void SetDefaultFontSettings()
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

            foreach (var btn in GetAll(this, typeof(RadioButton)))
            {
                (btn as RadioButton).Checked = false;

            }

        }

        #endregion





        private void RestoreDefaultButton_Click(object sender, EventArgs e)
        {
            RtrackBar.Value = 138;
            GtrackBar.Value = 197;
            BtrackBar.Value = 222;
            SaveBackColorChanges();
            SetDefaultFontSettings();
            SaveDefaultMusicStatusSettings();
            StopMusic(0);
            Settings.Default.Save();
        }

        private void ReportErrorButton_Click(object sender, EventArgs e)
        {
            ReportErrorForm reportErrorForm = new ReportErrorForm();
            reportErrorForm.Show();
        }

        float rotate = 0;

        private void SettingTimer_Tick(object sender, EventArgs e)
        {
                rotate += 1.5f;
        }

        private void AuthorsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jakub Benzef\nbenzef@tlen.pl\n\nMichał Białek\nm.biaek91@gmail.com", "Autorzy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
}
