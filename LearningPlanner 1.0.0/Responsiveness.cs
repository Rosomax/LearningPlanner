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

        public void CategoryResponse(CategoryForm x)
        {
            // Zmienne przechowujace szerokosc oraz wysokosc ekranu
            int widthSize = x.Width;
            int heightSize = x.Height;
            int FontSize = (int)(x.Width / 87.2);
            string FontName = "Centhury Gothic";
            //zmienne przechowujace skalowanie dla wiekszej liczby kontrolek
            int ControlWidthSize = widthSize / 5;
            int ControlLocationWidth = (int)(widthSize / 16.5);
            //zmienne przechowujące skalowalne rozmiary dla Labeli
            int LabelHeightSize = heightSize / 17;
            int LabelHeightLocation = heightSize / 120;
            // Response dla Labeli
            x.chooseCategoryLabel.Size = new Size(ControlWidthSize, LabelHeightSize);
            x.chooseTaskLabel.Size = new Size(ControlWidthSize, LabelHeightSize);
            x.describeTaskLabel.Size = new Size(ControlWidthSize, LabelHeightSize);
            x.chooseCategoryLabel.Location = new Point(ControlLocationWidth, LabelHeightLocation);
            x.chooseTaskLabel.Location = 
                new Point(ControlLocationWidth*2 + ControlWidthSize, LabelHeightLocation);
            x.describeTaskLabel.Location =
                new Point(ControlLocationWidth*3 + ControlWidthSize*2 , LabelHeightLocation);
            x.chooseCategoryLabel.Font = new Font(FontName, FontSize);
            x.chooseTaskLabel.Font= new Font(FontName, FontSize);
            x.describeTaskLabel.Font= new Font(FontName, FontSize);
            // zmienne przechowujące skalowalne rozmiary dla Data Grid
            int DataGridHeightSize = (int)(heightSize /1.2);
            int DataGridLocationHeight = (int)(heightSize /14.4);
            // Response dla Data Gridow
            x.chooseCategoryDataGrid.Size = new Size(ControlWidthSize,DataGridHeightSize);
            x.chooseTaskDataGrid.Size = new Size(ControlWidthSize, DataGridHeightSize);
            x.chooseCategoryDataGrid.Location = new Point(ControlLocationWidth,DataGridLocationHeight);
            x.chooseTaskDataGrid.Location = 
                new Point(ControlLocationWidth*2+ ControlWidthSize, DataGridLocationHeight);
            // zmienne przechowujące skalowalność dla richtextBoxa
            int DescribeRichTextBoxWidth = (int)(ControlWidthSize * 1.8);
            // Response dla richtexboxa describe
            x.describeTaskRichTextBox.Size = new Size(DescribeRichTextBoxWidth, DataGridHeightSize);
            x.describeTaskRichTextBox.Location = 
                new Point(ControlLocationWidth * 3 + ControlWidthSize * 2, DataGridLocationHeight);
            x.describeTaskRichTextBox.Font = new Font("Century Gothic", FontSize, FontStyle.Bold);

        }
         



    }
}
