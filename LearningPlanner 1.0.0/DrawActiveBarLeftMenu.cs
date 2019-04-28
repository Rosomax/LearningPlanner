using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlanner_1._0._0
{
    class DrawActiveBarLeftMenu
    {
        int wysokosc = 185;
        int szerokosc = 12;
        // Mysle czy calosci nie zrobic jako oddzielnej klasy? 

        // Rysowanie zaznaczen przy aktywmym pod menu do programu learning planner - kolor panelu w RGB - 178;8;55

        
        SolidBrush malowanie = new SolidBrush(Color.FromArgb(255, 178, 8, 55));

        // Deklaracja i ustawienieparametrow pedzla do  narysowanie prostokatow zaznaczen

        // Prostokat dla menu Zadania 
        public void RysujZadania(Graphics g)
        {
            // zadeklarowanie zmiennej transform
            var m = g.Transform;
            // Prostokat dla menu Zadania 
            g.FillRectangle(malowanie, 0, 0, szerokosc, wysokosc);
            g.Transform = m;

        }

        // Prostokat dla menu Zakonczone Zadania 
        public void RysujZakonczoneZadania(Graphics g)
        {
            // zadeklarowanie zmiennej transform
            var m = g.Transform;
            
            g.FillRectangle(malowanie, 0, 113, szerokosc, wysokosc);
            g.Transform = m;
        }

        // Prostokat dla menu Kategorie 
        public void RysujKategorie(Graphics g)
        {
            // zadeklarowanie zmiennej transform
            var m = g.Transform;

            g.FillRectangle(malowanie, 0, 226, szerokosc, wysokosc);
            g.Transform = m;
        }


        // Prostokat dla menu Znajdz Zadanie 
        public void RysujZnajdzZadanie(Graphics g)
        {
            // zadeklarowanie zmiennej transform
            var m = g.Transform;

            g.FillRectangle(malowanie, 0, 339, szerokosc, wysokosc);
            g.Transform = m;
        }

        // Prostokat dla menu Ze świata it
        public void RysujZeSwiataIt(Graphics g)
        {
            // zadeklarowanie zmiennej transform
            var m = g.Transform;

            g.FillRectangle(malowanie, 0, 452, szerokosc, wysokosc);
            g.Transform = m;
        }


        // Prostokat dla menu Ustawienia
        public void RysujUstawienia(Graphics g)
        {
            // zadeklarowanie zmiennej transform
            var m = g.Transform;

            g.FillRectangle(malowanie, 0, 565, szerokosc, wysokosc);
            g.Transform = m;
        }
    }
}

// czysci wszystko co narysowane - domyslnie ma kasowac ewentualne poprzednie zaznaczenie menu
// g.Graphics.Clear(Color.FromArgb(255, 178, 8, 55));