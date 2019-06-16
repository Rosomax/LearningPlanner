using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using LearningPlanner_1._0._0.Properties;
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



            defaultColorButton.ForeColor = Color.Black;
            RLabel.ForeColor = Color.Black;
            GLabel.ForeColor = Color.Black;
            BLabel.ForeColor = Color.Black;
            
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
            Settings.Default.track1 = RtrackBar.Value;
            Settings.Default.track2 = GtrackBar.Value;
            Settings.Default.track3 = BtrackBar.Value;
            Settings.Default.Save();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            RtrackBar.Value = 138;
            GtrackBar.Value = 197;
            BtrackBar.Value = 222;
            ChangeBackColorSave();
           
        }

        private void SaveColorToSettings()
        {
            RtrackBar.Value = Settings.Default.track1;
            GtrackBar.Value = Settings.Default.track2;
            BtrackBar.Value = Settings.Default.track3;
           
        }

        private void saveColorChangesButton_Click(object sender, EventArgs e)
        {
            ChangeBackColorSave();
            MessageBox.Show("Zapisano");
        }

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        

        
    }
    

}
