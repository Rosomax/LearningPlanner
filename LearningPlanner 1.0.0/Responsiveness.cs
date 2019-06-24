using System.Drawing;

namespace LearningPlanner
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
            x.DescriptionTextBox.Size = new Size((int)controlWidthSize, textBoxHeigh * 12);
            // Ustawienie rozmiaru buttonow po maksymalizacji
            x.SaveButton.Size = new Size((int)controlWidthSize, x.TaskNameTextBox.Size.Height * 3);
            x.DeleteButton.Size = new Size((int)controlWidthSize, x.TaskNameTextBox.Size.Height * 3);
            x.CancelButton.Size = new Size((int)controlWidthSize, x.TaskNameTextBox.Size.Height * 3);

            // Zmienna przechowujaca lokalizacje pierwszego elementu do ktorego mozna sie odniesc
            int defaultButtonYLocation = (x.DescriptionTextBox.Location.Y + x.DescriptionTextBox.Size.Height + 40);

            // Lokalizacje buttonow po maksymalizacji
            x.SaveButton.Location = new Point(x.TaskNameTextBox.Location.X, defaultButtonYLocation);
            x.DeleteButton.Location =
                new Point(x.TaskNameTextBox.Location.X, x.SaveButton.Location.Y + x.SaveButton.Size.Height + 20);
            x.CancelButton.Location =
                new Point(x.TaskNameTextBox.Location.X, x.DeleteButton.Location.Y + x.DeleteButton.Size.Height + 20);

            // Lokalizacja oraz rozmiar datagrida
            x.TaskDataGridView.Location = new Point(widthSize - x.TaskNameTextBox.Size.Width - 120, 0);
            x.TaskDataGridView.Size = new Size((int)controlWidthSize * 2 - 120, heightSize);

        }

        public void CategoryResponse(CategoryForm x)
        {
            // Zmienne przechowujace szerokosc oraz wysokosc ekranu
            int widthSize = x.Width;
            int heightSize = x.Height;
            int FontSize = (int)(x.Width / 87.2);
            string FontName = "Century Gothic";
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
                new Point(ControlLocationWidth * 2 + ControlWidthSize, LabelHeightLocation);
            x.describeTaskLabel.Location =
                new Point(ControlLocationWidth * 3 + ControlWidthSize * 2, LabelHeightLocation);
            x.chooseCategoryLabel.Font = new Font(FontName, FontSize);
            x.chooseTaskLabel.Font = new Font(FontName, FontSize);
            x.describeTaskLabel.Font = new Font(FontName, FontSize);
            // zmienne przechowujące skalowalne rozmiary dla Data Grid
            int DataGridHeightSize = (int)(heightSize / 1.2);
            int DataGridLocationHeight = (int)(heightSize / 14.4);
            // Response dla Data Gridow
            x.chooseCategoryDataGrid.Size = new Size(ControlWidthSize, DataGridHeightSize);
            x.chooseTaskDataGrid.Size = new Size(ControlWidthSize, DataGridHeightSize);
            x.chooseCategoryDataGrid.Location = new Point(ControlLocationWidth, DataGridLocationHeight);
            x.chooseTaskDataGrid.Location =
                new Point(ControlLocationWidth * 2 + ControlWidthSize, DataGridLocationHeight);
            // zmienne przechowujące skalowalność dla richtextBoxa
            int DescribeRichTextBoxWidth = (int)(ControlWidthSize * 1.8);
            // Response dla richtexboxa describe
            x.describeTaskRichTextBox.Size = new Size(DescribeRichTextBoxWidth, DataGridHeightSize);
            x.describeTaskRichTextBox.Location =
                new Point(ControlLocationWidth * 3 + ControlWidthSize * 2, DataGridLocationHeight);
            x.describeTaskRichTextBox.Font = new Font(FontName, FontSize, FontStyle.Bold);

        }

        public void FindTaskResponse(FindTaskForm x)
        {
            // Zmienne przechowujace szerokosc oraz wysokosc ekranu
            int widthSize = x.Width;
            int heightSize = x.Height;
            //zmienne przechowujace skalowanie dla wiekszej liczby kontrolek
            int labelFontSize = widthSize / 60;
            int textBoxFontSize = (int)(widthSize / 87.2);
            string fontName = "Century Gothic";
            int controlWidthLocation = (int)(widthSize / 9.6); //200
            // zmienne przechowujace skalowanie dla wlasciwosci size kontrolek
            int findTaskDataGridWidth = (int)(widthSize / 2.74);
            int findTaskDataGridHeight = (int)(heightSize / 2.67);
            int findTasklabelWidthSize = (int)(widthSize / 6.7);
            int findTasklabelHeightSize = (int)(heightSize / 37.24);
            int textBoxWidthSize = (int)(widthSize / 3.7);
            int findTaskTextBoxHeightSize = (int)(heightSize / 3.6);
            int filtrLabelWidthSize = (int)(widthSize / 50.5);
            int filtrLabelsHeightSize = (int)(heightSize / 56.84);
            int filterComboBoxHeightSize = (int)(heightSize / 51.4);
            int filterFromLabelWidthSize = (int)(widthSize / 24.94);
            int filterFromHightSize = (int)(heightSize / 40.1);
            int findPictureBoxWidthSize = (int)(widthSize / 3.33);
            int findPictureHeightSize = (int)(heightSize / 2.58);
            // Ustawienie rozmairu dla wszystkich kontrolek
            x.FindTaskLabel.Size = new Size(findTasklabelWidthSize, findTasklabelHeightSize);
            x.FindTaskTextBox.Size = new Size(textBoxWidthSize, findTaskTextBoxHeightSize);
            x.FilterLabel.Size = new Size(filtrLabelWidthSize, filtrLabelsHeightSize);
            x.FilterComboBox.Size = new Size(textBoxWidthSize, filterComboBoxHeightSize);
            x.FilterFromLabel.Size = new Size(filterFromLabelWidthSize, filtrLabelsHeightSize);
            x.FilterFrom.Size = new Size(textBoxWidthSize, filterFromHightSize);
            x.FilterToLabel.Size = new Size(filterFromLabelWidthSize, filtrLabelsHeightSize);
            x.FilterTo.Size = new Size(textBoxWidthSize, filterFromHightSize);
            x.findPictureBox.Size = new Size(findPictureBoxWidthSize, findPictureHeightSize);
            x.FindTaskDataGrid.Size = new Size(findTaskDataGridWidth, findTaskDataGridHeight);
            // zmienne przechowujace skalowanie dla wlasciowsci location kontrolek
            int findTaskLabelLocationHeight = (int)(heightSize / 27.7);
            int findTaskTextBoxLocationHeight = (int)(heightSize / 10.8);
            int moveDownOne = (int)(heightSize / 21.6);
            int moveDownTwo = heightSize / 18;
            int findPictureBoxLocationWidth = (int)(widthSize / 9.6);
            int findPictureBoxLocationHeight = (int)(heightSize / 1.96);
            // Ustawienie lokalizacji dla wszystkich kontrolek
            x.FindTaskLabel.Location = new Point(controlWidthLocation, findTaskLabelLocationHeight);
            x.FindTaskTextBox.Location = new Point(controlWidthLocation, findTaskTextBoxLocationHeight);
            x.FilterLabel.Location = new Point(controlWidthLocation, findTaskTextBoxLocationHeight + moveDownOne);
            x.FilterComboBox.Location =
                new Point(controlWidthLocation, findTaskTextBoxLocationHeight + moveDownOne + moveDownTwo);
            x.FilterFromLabel.Location =
                new Point(controlWidthLocation, findTaskTextBoxLocationHeight + moveDownOne * 2 + moveDownTwo);
            x.FilterFrom.Location =
                new Point(controlWidthLocation, findTaskTextBoxLocationHeight + moveDownOne * 2 + moveDownTwo * 2);
            x.FilterToLabel.Location =
                new Point(controlWidthLocation, findTaskTextBoxLocationHeight + moveDownOne * 3 + moveDownTwo * 2);
            x.FilterTo.Location =
                new Point(controlWidthLocation, findTaskTextBoxLocationHeight + moveDownOne * 3 + moveDownTwo * 3);
            x.findPictureBox.Location = new Point(findPictureBoxLocationWidth, findPictureBoxLocationHeight);
            // Ustawienie czcionek dla wszystkich kontrolek
            x.FindTaskLabel.Font = new Font(fontName, labelFontSize);
            x.FindTaskTextBox.Font = new Font(fontName, textBoxFontSize);
            x.FilterLabel.Font = new Font(fontName, labelFontSize);
            x.FilterComboBox.Font = new Font(fontName, textBoxFontSize);
            x.FilterFromLabel.Font = new Font(fontName, labelFontSize);
            x.FilterFrom.Font = new Font(fontName, textBoxFontSize);
            x.FilterToLabel.Font = new Font(fontName, labelFontSize);
            x.FilterTo.Font = new Font(fontName, textBoxFontSize);
        }


    }
}
