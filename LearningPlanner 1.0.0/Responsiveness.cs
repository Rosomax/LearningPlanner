using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace LearningPlanner_1._0._0
{
    class Responsiveness
    {

        public void TaskFormRespons(TaskForm x)
        {
            // Zmienne przechowujace szerokosc oraz wysokosc ekranu
            int widthSize = x.Width;
            int heightSize = x.Height;

            // Zmienne przechowujace skalowalne rozmiary
            int textBoxWidth = widthSize / 9;
            int textBoxHeigh = heightSize / 36;                   
            double controlWidthSize = widthSize / 3;
                   
            
            // Ustawienie rozmiaru textboxow po maksymializacji
            x.TaskNameTextBox.Size = new Size((int)controlWidthSize, textBoxHeigh);
            x.CategoryTextBox.Size = new Size((int)controlWidthSize, textBoxHeigh);
            x.DescriptionTextBox.Size = new Size((int)controlWidthSize, textBoxHeigh*12);
            // Ustawienie rozmiaru buttonow po maksymalizacji
            x.SaveButton.Size = new Size((int)controlWidthSize, x.TaskNameTextBox.Size.Height*3);
            x.DeleteButton.Size = new Size((int)controlWidthSize, x.TaskNameTextBox.Size.Height * 3);
            x.CancelButton.Size = new Size((int)controlWidthSize, x.TaskNameTextBox.Size.Height * 3);

            // Zmienna przechowujaca lokalizacje pierwszego elementu do ktorego mozna sie odniesc
            int defaultButtonYLocation = (x.DescriptionTextBox.Location.Y + x.DescriptionTextBox.Size.Height + 40);

            // Lokalizacje buttonow po maksymalizacji
            x.SaveButton.Location = new Point(x.TaskNameTextBox.Location.X, defaultButtonYLocation);
            x.DeleteButton.Location = 
                new Point(x.TaskNameTextBox.Location.X,x.SaveButton.Location.Y+x.SaveButton.Size.Height+20);
            x.CancelButton.Location = 
                new Point(x.TaskNameTextBox.Location.X,x.DeleteButton.Location.Y + x.DeleteButton.Size.Height+20);

            // Lokalizacja oraz rozmiar datagrida
            x.TaskDataGridView1.Location = new Point(widthSize - x.TaskNameTextBox.Size.Width - 120, 0);
            x.TaskDataGridView1.Size = new Size((int)controlWidthSize * 2 - 120, heightSize);
           
        }

         



    }
}
