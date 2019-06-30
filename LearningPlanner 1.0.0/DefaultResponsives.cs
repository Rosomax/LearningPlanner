using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningPlanner.Properties;
namespace LearningPlanner
{
    class DefaultResponsives
    {
        readonly string fontName = Settings.Default.RememberFont;
        readonly FontStyle fontStyle = FontStyle.Bold;
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
            int taskDataGridViewWidthSize = widthSize / 2;
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


            // Tu trzeba dopisac fonta!!!!

        }
    

        public void CategoryFormDefaultResponse(CategoryForm x)
        {
            // Zmienne przechowujace szerokosc oraz wysokosc ekranu
            int widthSize = x.Width;
            int heightSize = x.Height;
            //zmienne przechowujace skalowanie dla wiekszej liczby kontrolek
          
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

            if (Settings.Default.BoldFont)
            {
                x.chooseCategoryLabel.Font = new Font(fontName, labelFontSize,fontStyle);
                x.chooseTaskLabel.Font = new Font(fontName, labelFontSize,fontStyle);
                x.describeTaskLabel.Font = new Font(fontName, labelFontSize,fontStyle);
                x.chooseCategoryDataGrid.Font = new Font(fontName, gridFontSize, fontStyle);
                x.chooseTaskDataGrid.Font = new Font(fontName, gridFontSize, fontStyle);
                x.describeTaskRichTextBox.Font = new Font(fontName, gridFontSize, fontStyle);
            }
            else
            {
                x.chooseCategoryLabel.Font = new Font(fontName, labelFontSize);
                x.chooseTaskLabel.Font = new Font(fontName, labelFontSize);
                x.describeTaskLabel.Font = new Font(fontName, labelFontSize);
                x.chooseCategoryDataGrid.Font = new Font(fontName, gridFontSize);
                x.chooseTaskDataGrid.Font = new Font(fontName, gridFontSize);
                x.describeTaskRichTextBox.Font = new Font(fontName, gridFontSize);
            }
        }

        public void FindTaskDefaultResponse(FindTaskForm x)
        {
            // Zmienne przechowujace szerokosc oraz wysokosc ekranu
            int widthSize = x.Width;
            int heightSize = x.Height;
            //zmienne przechowujace skalowanie dla wiekszej liczby kontrolek
            FontStyle fontStyle = FontStyle.Bold;
            int labelFontSize = (int)(widthSize /55);
            int labelHeightSize = (int)(heightSize / 26.31);
            int labelHeightLocation = (int)(heightSize / 12.82);
            int textBoxHeightSize = (int)(heightSize /2.5);
            int labelFontTextBox = (int)(widthSize / 62.5);
            int textBoxWidthLocation = (int)(widthSize / 26.78);
            int findTaskLabelWidthLocation = (int)(widthSize / 31.25);
            int labelFilterFontSize = (int)(widthSize / 65);
            int filterDataPickerWidthSize = (int)(widthSize / 2.70);
            int filterDataPickerHeightSize = (int)(heightSize / 22.72);
            int filterLabelWidthLocation = (int)(widthSize / 93.75);
            int filterDateTimePickerWidthLocation = (int)(widthSize / 62.5);
            int filterFromDateTimePickerHeight = (int)(heightSize / 2.38);
            int filterLabelWidthSize = (int)(widthSize / 9.74);
            int filterLabelHeightSize = (int)(heightSize/26.31);
            // zmienne przechowujace skalowanie dla wlasciwosci size kontrolek
            int findTaskLabelWidthSize = (int)(widthSize / 4.03);
            int findTaskTextBoxWidthSize = (int)(widthSize /3.5);
            int findTaskFilterLabelWidthSize = (int)(widthSize / 19.73);
            int findTaskFilterLabelHeightSize = (int)(heightSize / 26.31);
            int filterComboBoxHeightSize = (int)(heightSize / 23.8);
            int findPictureBoxWidthSize = (int)(widthSize / 4.26);
            int findPictureBoxHeightSize = (int)(heightSize / 5.05);
            int findPictureBoxWidthLocation = (int)(widthSize / 17.04);
            int findPictureBoxHeightLocation = (int)(heightSize / 1.39);
            int findTaskDataGridWidthSize = (int)(widthSize / 1.66);
            int findTaskDataGridHeightSize = heightSize / 1;
         
            // Ustawienie rozmairu dla wszystkich kontrolek
            x.FindTaskLabel.Size = new Size(findTaskLabelWidthSize, labelHeightSize);
            x.FindTaskTextBox.Size = new Size(findTaskTextBoxWidthSize, textBoxHeightSize);
            x.FilterLabel.Size = new Size(findTaskFilterLabelWidthSize, findTaskFilterLabelHeightSize);
            x.FilterFrom.Size = new Size(filterDataPickerWidthSize, filterDataPickerHeightSize);
            x.FilterTo.Size = new Size(filterDataPickerWidthSize, filterDataPickerHeightSize);
            x.FilterComboBox.Size = new Size(findTaskTextBoxWidthSize, filterComboBoxHeightSize);
            x.FilterFromLabel.Size = new Size(filterLabelWidthSize, filterLabelHeightSize);
            x.FilterToLabel.Size = new Size(filterLabelWidthSize, filterLabelHeightSize);
            x.FindPictureBox.Size = new Size(findPictureBoxWidthSize, findPictureBoxHeightSize);
            x.FindTaskDataGrid.Size = new Size(findTaskDataGridWidthSize, findTaskDataGridHeightSize);
            

            
            // zmienne przechowujace skalowanie dla wlasciowsci location kontrolek
            int textBoxHeightLocation = (int)(heightSize / 8.19);
            int filterLabelHeightLocation = (int)(heightSize / 4.42);
            int filterToLabelHeightLocation = (int)(heightSize / 2.05);
            int filterFromLabelHeightLocation = (int)(heightSize / 2.66);
            int filterToDateTimePickerHeightLocation = (int)(heightSize / 1.88);
            int filterComboBoxLocation = (int)(heightSize / 3.70);
            
            // Ustawienie lokalizacji dla wszystkich kontrolek
            x.FindTaskLabel.Location = new Point(findTaskLabelWidthLocation, labelHeightLocation);
            x.FindTaskTextBox.Location = new Point(textBoxWidthLocation, textBoxHeightLocation);
            x.FilterLabel.Location = new Point(findTaskLabelWidthLocation,filterLabelHeightLocation);
            x.FilterFromLabel.Location = new Point(filterLabelWidthLocation, filterFromLabelHeightLocation);
            x.FilterToLabel.Location = new Point(filterLabelWidthLocation, filterToLabelHeightLocation);
            x.FilterFrom.Location = new Point(filterDateTimePickerWidthLocation, filterFromDateTimePickerHeight);
            x.FilterTo.Location = new Point(filterDateTimePickerWidthLocation, filterToDateTimePickerHeightLocation);
            x.FilterComboBox.Location = new Point(textBoxWidthLocation, filterComboBoxLocation);
            x.FindPictureBox.Location = new Point(findPictureBoxWidthLocation, findPictureBoxHeightLocation);
            // Ustawienie czcionek dla wszystkich kontrolek
            if (Settings.Default.BoldFont)
            {
                x.FindTaskLabel.Font = new Font(fontName, labelFontSize,fontStyle);
                x.FindTaskTextBox.Font = new Font(fontName, labelFontTextBox);
                x.FilterLabel.Font = new Font(fontName, labelFontSize, fontStyle);
                x.FilterComboBox.Font = new Font(fontName, labelFontTextBox);
                x.FilterFromLabel.Font = new Font(fontName, labelFontSize, fontStyle);
                x.FilterFrom.Font = new Font(fontName, labelFilterFontSize);
                x.FilterTo.Font = new Font(fontName, labelFilterFontSize);
                x.FilterToLabel.Font = new Font(fontName, labelFontSize, fontStyle);
            }
            else
            {
                x.FindTaskLabel.Font = new Font(fontName, labelFontSize);
                x.FindTaskTextBox.Font = new Font(fontName, labelFontTextBox);
                x.FilterLabel.Font = new Font(fontName, labelFontSize);
                x.FilterComboBox.Font = new Font(fontName, labelFontTextBox);
                x.FilterFromLabel.Font = new Font(fontName, labelFontSize);
                x.FilterFrom.Font = new Font(fontName, labelFilterFontSize);
                x.FilterTo.Font = new Font(fontName, labelFilterFontSize);
                x.FilterToLabel.Font = new Font(fontName, labelFontSize);
            }

        }
    }
}
