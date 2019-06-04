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

namespace LearningPlanner_1._0._0
{
    public partial class UstawieniaForm : Form
    {
        public UstawieniaForm()
        {
            InitializeComponent();
        }

        private void UstawieniaForm_Load(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("Resources\\Kursor.cur");
            this.BackColor = Color.FromArgb(138, 197, 222);

        }

        private void UstawieniaForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            var m = e.Graphics.Transform;
            // rysowanie kola glownego - tarcza zegara
            e.Graphics.FillEllipse(Brushes.AntiqueWhite, 150, 150, 300, 300);
            e.Graphics.DrawEllipse(Pens.Black, 150, 150, 300, 300);

            //ryssowanie srodkowego kolka na zegarku - mocowanie wskazowek
            e.Graphics.FillEllipse(Brushes.Yellow, 290, 290, 20, 20);
            e.Graphics.DrawEllipse(Pens.Black, 290, 290, 20, 20);
            //wskazowka sekundowa
            e.Graphics.TranslateTransform(300, 300);
            e.Graphics.RotateTransform(DateTime.Now.Second * 6);
            e.Graphics.DrawLine(Pens.Red, 0, 0, 0, -85);

            //wskazowka minutowa
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(300, 300);
            e.Graphics.RotateTransform(DateTime.Now.Minute*6);
            Pen minuta = new Pen(Color.Green, 3);
            e.Graphics.DrawLine(minuta, 0, 0, 0, -65);
            // wskazowka godzinowa
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(300, 300);
            e.Graphics.RotateTransform(DateTime.Now.Hour*24);
            Pen godzina = new Pen(Color.Black, 5);
            e.Graphics.DrawLine(godzina, 0, 0, 0, -45);

            // Rysowanie czterech glownych kreseczek po kolei polnoc,poludnie,wschod,zachod
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(300, 150);
            e.Graphics.DrawLine(Pens.Black, 0, 0, 0, 23);

            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(300, 450);
            e.Graphics.DrawLine(Pens.Black, 0, 0, 0, -23);

            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(150, 300);
            e.Graphics.DrawLine(Pens.Black, 0, 0, 23, 0);

            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(450, 300);
            e.Graphics.DrawLine(Pens.Black, 0, 0, -23, 0);

            ////// gorna lewa cwiartka 1 mala z prawej
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(240, 163); 
            e.Graphics.RotateTransform(60);
            e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, 17, 0);
            // gorna lewa cwiartka 2 (srodkowa) mala z prawej
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(195, 195);
            e.Graphics.RotateTransform(45);
            e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, 17, 0);
            // gorna lewa cwiartka 3 z prawej
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(163, 240);
            e.Graphics.RotateTransform(30);
            e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, 17, 0);

            //gorna prawa cwiartka 1 mala z lewej
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(360, 163); //
            e.Graphics.RotateTransform(120);
            e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, 17, 0);
            //gorna prawa cwiartka 2 (srodkowa) z prawej
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(405, 195);
            e.Graphics.RotateTransform(-45);
            e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, -17, 0);
            // gorna prawa cwiartka 3 z prawej
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(163, 360);
            e.Graphics.RotateTransform(-30);
            e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, 17, 0);

            ////// dolna lewa cwiartka pierwsza mala z prawej
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(240, 437); //
            e.Graphics.RotateTransform(120);
            e.Graphics.DrawLine(Pens.DarkCyan, 0, 0,-17, 0);
            //dolna lewa cwiartka 2 (srodkowa) mala z prawej
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(195, 405);
            e.Graphics.RotateTransform(-45);
            e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, 17, 0);
            ////// dolna lewa cwiartka trzecia mala z prawej
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(437, 240); //
            e.Graphics.RotateTransform(-30);
            e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, -17, 0);

            /////dolna prawa cwiartka pierwsza z lewej
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(360, 437); 
            e.Graphics.RotateTransform(60);
            e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, -17, 0);
            // dolna prawa cwiartka 2 (srodkowa) z lewej
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(405, 405);
            e.Graphics.RotateTransform(45);
            e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, -17, 0);
            /////dolna prawa cwiartka trzecia z lewej
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(437, 360); 
            e.Graphics.RotateTransform(30);
            e.Graphics.DrawLine(Pens.DarkCyan, 0, 0, -17, 0);      
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }



    }
    
}
