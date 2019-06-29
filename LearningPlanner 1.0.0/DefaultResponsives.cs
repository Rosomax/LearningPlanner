using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlanner
{
    class DefaultResponsives
    {
        string fontName = "Century Gothic";
    
        public void TaskFormDefaultResponse(TaskForm x)
        {
            // Zmienne przechowujace szerokosc oraz wysokosc ekranu
            int widthSize = x.Width;
            int heightSize = x.Height;
            //zmienne przechowujace skalowanie dla wiekszej liczby kontrolek
            int textBoxWidthSize = (int)(widthSize / 3.4);
            int textBoxHeightSize = (int)(heightSize / 14.29);
            int buttonWidthSize = (int)(widthSize /6.94);
            int buttonHeightSize = heightSize /10;
            int buttonHeightLocation = (int)(heightSize / 1.27); 
            // zmienne przechowujace skalowanie dla wlasciwosci size kontrolek
            int descriptionTextBoxHeightSize = (int)(heightSize / 4.5);
            int taskDataGridViewWidthSize = (int)(widthSize /2);
            int taskDataGridViewHeightSize = heightSize;
            // Ustawienie rozmairu dla wszystkich kontrolek
            x.TaskNameTextBox.Size = new Size(textBoxWidthSize, textBoxHeightSize);
            x.CategoryTextBox.Size = new Size(textBoxWidthSize, textBoxHeightSize);
            x.DescriptionTextBox.Size = new Size(textBoxWidthSize,descriptionTextBoxHeightSize);
            x.TaskDataGridView.Size = new Size(taskDataGridViewWidthSize, taskDataGridViewHeightSize);
            x.SaveButton.Size = new Size(buttonWidthSize,buttonHeightSize);
            x.DeleteButton.Size = new Size(buttonWidthSize, buttonHeightSize);
            x.CancelButton.Size = new Size(buttonWidthSize, buttonHeightSize);
            // zmienne przechowujace skalowanie dla wlasciowsci location kontrolek
            int saveButtonWidthLocation = (int)(widthSize /68.18);
            int deleteButtonWidthLocation = widthSize / 6;
            int cancelButtonWidthLocation = (int)(widthSize /3.14);
            // Ustawienie lokalizacji dla wszystkich kontrolek
            x.SaveButton.Location = new Point(saveButtonWidthLocation, buttonHeightLocation);
            x.DeleteButton.Location = new Point(deleteButtonWidthLocation, buttonHeightLocation);
            x.CancelButton.Location = new Point(cancelButtonWidthLocation, buttonHeightLocation);
        }
    

        public void CategoryFormDefaultResponse(CategoryForm x)
        {
            // Zmienne przechowujace szerokosc oraz wysokosc ekranu
            int widthSize = x.Width;
            int heightSize = x.Height;
            //zmienne przechowujace skalowanie dla wiekszej liczby kontrolek
            FontStyle fontStyle = FontStyle.Bold;
            int labelFontSize =(int)(widthSize/53.57);
            int gridFontSize = (int)(widthSize / 62.5);
            int labelHeightSize = (int)(heightSize / 21.74);
            int labelHeightLocation = (int)(heightSize / 55.55);
            int dataGridWidthSize = (int)(widthSize / 4.16);
            int dataGridHeightSize = (int)(heightSize / 1.1);
            int dataGridHeightLocation = (int)(heightSize /14.28);
            // zmienne przechowujace skalowanie dla wlasciwosci size kontrolek
            int chooseCategoryLabelWidthSize = (int)(widthSize / 4.07);
            int chooseTaskLabelWidthSize = (int)(widthSize / 4.41);
            int describeTaskLabelWidthSize = (int)(widthSize / 5.35);
            int describeTaskRichTextBoxWidthSize = (int)(widthSize / 2.51);
            // Ustawienie rozmairu dla wszystkich kontrolek
            x.chooseCategoryLabel.Size = new Size(chooseCategoryLabelWidthSize, labelHeightSize);
            x.chooseTaskLabel.Size = new Size(chooseTaskLabelWidthSize, labelHeightSize);
            x.describeTaskLabel.Size = new Size(describeTaskLabelWidthSize, labelHeightSize);
            x.chooseCategoryDataGrid.Size = new Size(dataGridWidthSize, dataGridHeightSize);
            x.chooseTaskDataGrid.Size = new Size(dataGridWidthSize, dataGridHeightSize);
            x.describeTaskRichTextBox.Size = new Size(describeTaskLabelWidthSize, dataGridHeightSize);
            // zmienne przechowujace skalowanie dla wlasciowsci location kontrolek
            int chooseCategoryLabelWidthLocation = (int)(widthSize / 62.5);
            int chooseTaskLabelWidthLocation = (int)(widthSize / 3.02);
            int describeTaskLabelWidthLocation = (int)(widthSize / 1.5);
            int chooseCategoryDataGridWidthLocation = (int)(widthSize / 46.87);
            int chooseTaskDataGridWidthLocation = (int)(widthSize / 2.97);
            int describeTaskRIchTextBoxWidthLocation = (int)(widthSize / 1.49);
            // Ustawienie lokalizacji dla wszystkich kontrolek
            x.chooseCategoryLabel.Location = new Point(chooseCategoryLabelWidthLocation, labelHeightLocation);
            x.chooseTaskLabel.Location = new Point(chooseTaskLabelWidthLocation, labelHeightLocation);
            x.describeTaskLabel.Location = new Point(describeTaskLabelWidthLocation, labelHeightLocation);
            x.chooseCategoryDataGrid.Location = new Point(chooseCategoryDataGridWidthLocation, dataGridHeightLocation);
            x.chooseTaskDataGrid.Location = new Point(chooseTaskDataGridWidthLocation, dataGridHeightLocation);
            x.describeTaskRichTextBox.Location = new Point(describeTaskRIchTextBoxWidthLocation,dataGridHeightLocation);
            // Ustawienie czcionek dla wszystkich kontrolek
            x.chooseCategoryLabel.Font = new Font(fontName, labelFontSize);
            x.chooseTaskLabel.Font = new Font(fontName, labelFontSize);
            x.describeTaskLabel.Font = new Font(fontName, labelFontSize);
            x.chooseCategoryDataGrid.Font = new Font(fontName, gridFontSize, fontStyle);
            x.chooseTaskDataGrid.Font = new Font(fontName, gridFontSize, fontStyle);
            x.describeTaskRichTextBox.Font = new Font(fontName, gridFontSize, fontStyle);
        }

        public void FindTaskDefaultResponse(FindTaskForm x)
        {
            // Zmienne przechowujace szerokosc oraz wysokosc ekranu
            int widthSize = x.Width;
            int heightSize = x.Height;
            //zmienne przechowujace skalowanie dla wiekszej liczby kontrolek

            // zmienne przechowujace skalowanie dla wlasciwosci size kontrolek

            // Ustawienie rozmairu dla wszystkich kontrolek

            // zmienne przechowujace skalowanie dla wlasciowsci location kontrolek

            // Ustawienie lokalizacji dla wszystkich kontrolek

        }
    }
}
