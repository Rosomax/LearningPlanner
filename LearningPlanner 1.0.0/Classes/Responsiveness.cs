using System.Drawing;
using LearningPlanner.Properties;
namespace LearningPlanner
{
    class Responsiveness
    {
        readonly string fontName = Settings.Default.RememberFont;
        readonly FontStyle fontStyle = FontStyle.Bold;

        public void TaskFormRespons(TaskForm x)
        {
            // Zmienne przechowujace szerokosc oraz wysokosc ekranu
            int widthSize = x.Width;
            int heightSize = x.Height;
            int fontSize = (int)(widthSize / 87.27);
            // Zmienne przechowujace skalowalne rozmiary
            int textBoxWidth = widthSize / 9;
            int textBoxHeigh = heightSize / 36;
            double controlWidthSize = widthSize / 3;
            // Ustawienie rozmiaru textboxow po maksymializacji
            x.TaskNameTextBox.Size = new Size((int)controlWidthSize, textBoxHeigh);
            x.CategoryTextBox.Size = new Size((int)controlWidthSize, textBoxHeigh);
            x.DescriptionTextBox.Size = new Size((int)controlWidthSize, textBoxHeigh * (heightSize/90)); 
            // Ustawienie rozmiaru buttonow po maksymalizacji
            x.SaveButton.Size = new Size((int)controlWidthSize, x.TaskNameTextBox.Size.Height * (heightSize / 360)); 
            x.DeleteButton.Size = new Size((int)controlWidthSize, x.TaskNameTextBox.Size.Height * (heightSize / 360));
            x.CancelButton.Size = new Size((int)controlWidthSize, x.TaskNameTextBox.Size.Height * (heightSize / 360));
            // Zmienna przechowujaca lokalizacje pierwszego elementu do ktorego mozna sie odniesc
            int defaultButtonYLocation = (x.DescriptionTextBox.Location.Y + x.DescriptionTextBox.Size.Height + (heightSize /27)); 
            // Lokalizacje buttonow po maksymalizacji
            x.SaveButton.Location = new Point(x.TaskNameTextBox.Location.X, defaultButtonYLocation);
            x.DeleteButton.Location =
                new Point(x.TaskNameTextBox.Location.X, x.SaveButton.Location.Y + x.SaveButton.Size.Height + (heightSize / 54));
            x.CancelButton.Location =
                new Point(x.TaskNameTextBox.Location.X, x.DeleteButton.Location.Y + x.DeleteButton.Size.Height + (heightSize / 54));
            // Lokalizacja oraz rozmiar datagrida
            x.TaskDataGridView.Location = new Point(widthSize - x.TaskNameTextBox.Size.Width - (heightSize / 9), 0);
            x.TaskDataGridView.Size = new Size((int)controlWidthSize * 2 - 120, heightSize);
            if (Settings.Default.BoldFont)
            {

                x.TaskNameLabel.Font = new Font(fontName, fontSize, fontStyle);
                x.CategoryLabel.Font = new Font(fontName, fontSize, fontStyle);
                x.DescribeLabel.Font = new Font(fontName, fontSize, fontStyle);
            }
            else
            {
                x.TaskNameLabel.Font = new Font(fontName, fontSize);
                x.CategoryLabel.Font = new Font(fontName, fontSize);
                x.DescribeLabel.Font = new Font(fontName, fontSize);

            }
        }

        public void CategoryResponse(CategoryForm x)
        {
            // Zmienne przechowujace szerokosc oraz wysokosc ekranu
            int widthSize = x.Width;
            int heightSize = x.Height;
            int fontSize = (int)(x.Width / 87.2);
            
            //zmienne przechowujace skalowanie dla wiekszej liczby kontrolek
            int controlWidthSize = widthSize / 5;
            int controlLocationWidth = (int)(widthSize / 16.5);
            //zmienne przechowujące skalowalne rozmiary dla Labeli
            int labelHeightSize = heightSize / 17;
            int labelHeightLocation = heightSize / 120;
            // Response dla Labeli
            x.chooseCategoryLabel.Size = new Size(controlWidthSize, labelHeightSize);
            x.chooseTaskLabel.Size = new Size(controlWidthSize, labelHeightSize);
            x.describeTaskLabel.Size = new Size(controlWidthSize, labelHeightSize);
            x.chooseCategoryLabel.Location = new Point(controlLocationWidth, labelHeightLocation);
            x.chooseTaskLabel.Location =
                new Point(controlLocationWidth * 2 + controlWidthSize, labelHeightLocation);
            x.describeTaskLabel.Location =
                new Point(controlLocationWidth * 3 + controlWidthSize * 2, labelHeightLocation);
          
            // zmienne przechowujące skalowalne rozmiary dla Data Grid
            int dataGridHeightSize = (int)(heightSize / 1.2);
            int dataGridLocationHeight = (int)(heightSize / 14.4);
            // Response dla Data Gridow
            x.chooseCategoryDataGrid.Size = new Size(controlWidthSize, dataGridHeightSize);
            x.chooseTaskDataGrid.Size = new Size(controlWidthSize, dataGridHeightSize);
            x.chooseCategoryDataGrid.Location = new Point(controlLocationWidth, dataGridLocationHeight);
            x.chooseTaskDataGrid.Location =
                new Point(controlLocationWidth * 2 + controlWidthSize, dataGridLocationHeight);
            // zmienne przechowujące skalowalność dla richtextBoxa
            int describeRichTextBoxWidth = (int)(controlWidthSize * 1.8);
            // Response dla richtexboxa describe
            x.describeTaskRichTextBox.Size = new Size(describeRichTextBoxWidth, dataGridHeightSize);
            x.describeTaskRichTextBox.Location =
                new Point(controlLocationWidth * 3 + controlWidthSize * 2, dataGridLocationHeight);

            if (Settings.Default.BoldFont)
            {
                x.describeTaskRichTextBox.Font = new Font(fontName, fontSize);
                x.chooseCategoryLabel.Font = new Font(fontName, fontSize, fontStyle);
                x.chooseTaskLabel.Font = new Font(fontName, fontSize, fontStyle);
                x.describeTaskLabel.Font = new Font(fontName, fontSize, fontStyle);
            }
            else
            {
                x.describeTaskRichTextBox.Font = new Font(fontName,fontSize);
                x.chooseCategoryLabel.Font = new Font(fontName, fontSize);
                x.chooseTaskLabel.Font = new Font(fontName, fontSize);
                x.describeTaskLabel.Font = new Font(fontName, fontSize);
            }

        }

        public void FindTaskResponse(FindTaskForm x)
        {
            // Zmienne przechowujace szerokosc oraz wysokosc ekranu
            int widthSize = x.Width;
            int heightSize = x.Height;
            //zmienne przechowujace skalowanie dla wiekszej liczby kontrolek
            int labelFontSize = widthSize / 60;
            int textBoxFontSize = (int)(widthSize / 87.2);
            int controlWidthLocation = (int)(widthSize / 9.6); //200
            // zmienne przechowujace skalowanie dla wlasciwosci size kontrolek
            int findTaskDataGridWidth = (int)(widthSize / 1.8); //
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
            x.FindPictureBox.Size = new Size(findPictureBoxWidthSize, findPictureHeightSize);
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
            x.FindPictureBox.Location = new Point(findPictureBoxLocationWidth, findPictureBoxLocationHeight);
            // Ustawienie czcionek dla wszystkich kontrolek

            if (Settings.Default.BoldFont)
            {
                x.FindTaskLabel.Font = new Font(fontName, labelFontSize, fontStyle);
                x.FindTaskTextBox.Font = new Font(fontName, textBoxFontSize, fontStyle);
                x.FilterLabel.Font = new Font(fontName, labelFontSize, fontStyle);
                x.FilterComboBox.Font = new Font(fontName, textBoxFontSize, fontStyle);
                x.FilterFromLabel.Font = new Font(fontName, labelFontSize, fontStyle);
                x.FilterFrom.Font = new Font(fontName, textBoxFontSize, fontStyle);
                x.FilterToLabel.Font = new Font(fontName, labelFontSize, fontStyle);
                x.FilterTo.Font = new Font(fontName, textBoxFontSize, fontStyle);
            }

            else
            {
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

        public void ITNewsResponse (ITNews x)
        {
            // Zmienne przechowujace szerokosc oraz wysokosc ekranu
            int widthSize = x.Width;
            int heightSize = x.Height;
            //zmienne przechowujace skalowanie dla wiekszej liczby kontrolek
            
            int fontSize = (int)(widthSize / 137.14);
            int controlWidthSize = (int)(widthSize / 6.53);
            int labelHeightSize = (int)(heightSize / 21.6);
            int listBoxHeightSize = (int)(heightSize / 3.85);
            int buttonHeightSize = (heightSize / 18);
            int webBrowserandXmlWidthSize = (int)(widthSize / 1.1988); 
            int controlWidthLocation = (int)(widthSize / 147.69);
            // zmienne przechowujace skalowanie dla wlasciwosci size kontrolek
            int groupBoxWidthSize = (widthSize / 6);
            int groupBoxHeightSize = (int)(heightSize / 1.98);
            int textBoxHeightSize = (int)(heightSize / 83.07);
            int webBrowserHeightSize = (int)(heightSize / 1.38);
            int xmlBrowserHeightSize = (int)(heightSize / 3.6);
            // Ustawienie rozmairu dla wszystkich kontrolek
            x.urlGroupBox.Size = new Size(groupBoxWidthSize, groupBoxHeightSize);
            x.UrlTextBox.Size = new Size(controlWidthSize, textBoxHeightSize);
            x.AddUrlButton.Size = new Size(controlWidthSize, buttonHeightSize);
            x.ChannelsTitleLabel.Size = new Size(controlWidthSize, labelHeightSize);
            x.ChannelsListBox.Size = new Size(controlWidthSize, listBoxHeightSize);
            x.SitesLabel.Size = new Size(controlWidthSize, labelHeightSize);
            x.FavoriteSitesListBox.Size = new Size(controlWidthSize, listBoxHeightSize);
            x.LoadWWWbutton.Size = new Size(controlWidthSize, buttonHeightSize);
            x.WWWtextbox.Size = new Size(controlWidthSize, textBoxHeightSize);
            x.WebBrowserForXml.Size = new Size(webBrowserandXmlWidthSize, webBrowserHeightSize );
            x.DisplayForNewsTabControl.Size = new Size(webBrowserandXmlWidthSize, xmlBrowserHeightSize);
            // zmienne przechowujace skalowanie dla wlasciowsci location kontrolek
            int addUrlButtonLocationHeight = (heightSize / 31);
            int channelTitleLabelLocationHeight = (int)(heightSize /11.13);
            int channelsListBoxLocationHeight = (int)(heightSize /6.92);
            int sitesLabelLocationHeigh = (int)(heightSize /2.34 );
            int favoriteSitesListBoxLocationHeight = (int)(heightSize /2.07);
            int loadWWWbuttonLocationHeight = (int)(heightSize /1.33);
            int wWWtextboxLocationHeight = (int)(heightSize /1.24);
            int displayForNewTabControlLocationWidth = (int)(widthSize / 9.46);
            // Ustawienie lokalizacji dla wszystkich kontrolek
            x.AddUrlButton.Location = new Point(controlWidthLocation, addUrlButtonLocationHeight);
            x.ChannelsTitleLabel.Location = new Point(controlWidthLocation, channelTitleLabelLocationHeight);
            x.ChannelsListBox.Location = new Point(controlWidthLocation, channelsListBoxLocationHeight);
            x.SitesLabel.Location = new Point(controlWidthLocation, sitesLabelLocationHeigh);
            x.FavoriteSitesListBox.Location = new Point(controlWidthLocation, favoriteSitesListBoxLocationHeight);
            x.LoadWWWbutton.Location = new Point(controlWidthLocation, loadWWWbuttonLocationHeight);
            x.WWWtextbox.Location = new Point(controlWidthLocation, wWWtextboxLocationHeight);
            x.DisplayForNewsTabControl.Location = new Point(displayForNewTabControlLocationWidth, 0);
            x.WebBrowserForXml.Location = new Point(displayForNewTabControlLocationWidth, xmlBrowserHeightSize);
            // Ustawienie czcionek dla wszystkich kontrolek
            if (Settings.Default.BoldFont)
            {
                x.FavoriteSitesListBox.Font = new Font(fontName, fontSize,fontStyle);
                x.ChannelsListBox.Font = new Font(fontName, fontSize,fontStyle);
            }
            else
            {
                x.FavoriteSitesListBox.Font = new Font(fontName, fontSize);
                x.ChannelsListBox.Font = new Font(fontName, fontSize);
            }


        }

        public void SettingsResponse(SettingsForm x)
        {

        }


    }
}
