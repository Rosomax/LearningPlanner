using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.ServiceModel.Syndication;

namespace LearningPlanner_1._0._0
{
    public partial class ITNews : Form
    {

        // RSS Links
        string s0 = "https://www.gry-online.pl/rss/news.xml"; // gryonline
        string s1 = "http://pclab.pl/xml/rss.xml"; //pclab
        string s2 = "http://www.gazeta.pl/pub/rss/sport.xml"; // Sport
        string s3 = "http://kanaly.rss.interia.pl/fakty.xml"; // Newses interia
        string s4 = "http://vitalia.pl/artykuly.xml"; // Dietetics

       
        // WWW links
        string ws0 = "https://www.itnews.com/";//itnews
        string ws1 = "https://stackoverflow.com/"; //stackoverflow



 public ITNews()
        {
            InitializeComponent();
        }

        private void ITNews_Load(object sender, EventArgs e)
        {
            this.Cursor= new Cursor("Resources\\Kursor.cur");
            this.BackColor = Color.FromArgb(138, 197, 222);
                       
            string s0t = "GRY ONLINE";
            string s1t = "PC-LAB";
            string s2t = "SPORT";
            string s3t = "FAKTY - POLSKA";
            string s4t = "DIETETYKA i FITNESS";
            channelsListBox.Items.Add(s0t);
            channelsListBox.Items.Add(s1t);
            channelsListBox.Items.Add(s2t);
            channelsListBox.Items.Add(s3t);
            channelsListBox.Items.Add(s4t);
           
          

            string wst0 = "IT NEWS IDG";
            string wst1 = "STACKOVERFLOW";
                                                       

            FavoriteSitesListBox.Items.Add(wst0);
            FavoriteSitesListBox.Items.Add(wst1);
            
        }

        #region Change strings to URL and transfer to textbox for xmls
        // For XML - change string to URL
        private void transferToUrlTextBox()
        {
            if (channelsListBox.SelectedItem != null)
            {
                string copyUrl;
                copyUrl = (channelsListBox.SelectedItem as string);
                if(channelsListBox.SelectedIndex==0)
                {
                    copyUrl = s0;
                }
                else if(channelsListBox.SelectedIndex == 1)
                {
                    copyUrl = s1;
                }
                 else if(channelsListBox.SelectedIndex == 2)
                {
                    copyUrl = s2;
                }
                else if (channelsListBox.SelectedIndex == 3)
                {
                    copyUrl = s3;
                }
                else if (channelsListBox.SelectedIndex == 4)
                {
                    copyUrl = s4;
                }
                urlTextBox.Text = copyUrl;
                copyUrl = (channelsListBox.SelectedItem as string);  
            }
                
        }

        // Change string to url for WWW
        private void transferToUrlWWWTextBox()
        {
            if (FavoriteSitesListBox.SelectedItem != null)
            {
                string copyWWWUrl;
                copyWWWUrl = (FavoriteSitesListBox.SelectedItem as string);
                if (FavoriteSitesListBox.SelectedIndex == 0)
                {
                    copyWWWUrl = ws0;
                }
                else if (FavoriteSitesListBox.SelectedIndex == 1)
                {
                    copyWWWUrl = ws1;
                }
                else if (FavoriteSitesListBox.SelectedIndex == 2)
                {
                    copyWWWUrl = s2;
                }
                else if (FavoriteSitesListBox.SelectedIndex == 3)
                {
                    copyWWWUrl = s3;
                }
                else if (FavoriteSitesListBox.SelectedIndex == 4)
                {
                    copyWWWUrl = s4;
                }
                WWWtextbox.Text = copyWWWUrl;
                copyWWWUrl = (FavoriteSitesListBox.SelectedItem as string);   
            }

        }
        #endregion


        private void addUrlButton_Click(object sender, EventArgs e)
        {
         try
            {
                // pobiera wartość z text boxa ( text) i na jego podstawie tworzy nowy XML reader
                XmlReader feedReadXML = XmlReader.Create(urlTextBox.Text);
                //--------------------------------------------
                SyndicationFeed feedXML = SyndicationFeed.Load(feedReadXML);
                //przypisanie nazwy , tytulu z kanalu rss do zmiennej typu Tab zakladka
                TabPage feedTab = new TabPage(feedXML.Title.Text);
                // przypisanie nazwy do zakladki z naszego contentu rss
                displayForNewsTabControl.TabPages.Add(feedTab);
                // utworzenie listboxa do trzymania contentu
                ListBox feedList = new ListBox();
                // wypelnienie contentem z kanalu rss
                feedTab.Controls.Add(feedList);
                // wypelnienie calego obszaru listboxem
                feedList.Dock = DockStyle.Fill;
                // Dodanie scroll bara do lepszego przewijania contentu
                feedList.HorizontalScrollbar = true;
              

                foreach (SyndicationItem feedItem in feedXML.Items)
                {

                    //// to do obcinania
                    string summary = feedItem.Summary.Text;
                    bool running = true;

                    string fix_sum = "";
                    string link = "";
                    foreach (char characterdata in summary)
                    {
                        if (characterdata != '<' && running)
                        {
                            fix_sum = fix_sum + characterdata;
                        }
                        else
                        {
                            running = false;
                        }
                    }
                    foreach (char characterdata in summary)
                    {
                        if (characterdata == '>' && running)
                        {
                           // string tmp;
                            //tmp=
                            if (characterdata == '<' && running)
                            {
                                link = link + characterdata;
                            }
                            else
                            {
                                running = false;
                            }
                        }

                    }

                    // Dodanie tytulu wiadomosci z kanalu rss
                    feedList.Items.Add(feedItem.Title.Text);
                    // dodanie textu wiadomosci z kanalu rss
                    feedList.Items.Add(fix_sum);
                    //feedList.Items.Add(link);
               
                    
                    // DOdanie separatora
                    feedList.Items.Add("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
                }
            }
            catch { MessageBox.Show("Nie dodano żadengo adresu URL kanału RSS", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error ); }


        }
        // Kliknieca w listboxy
        private void channelsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            transferToUrlTextBox();
        }
        private void FavoriteSitesListBox_MouseClick(object sender, MouseEventArgs e)
        {
            transferToUrlWWWTextBox();
        }

        #region zmianay w responsowynosci, ukladzie i wielkosci formantow przy zmianach wielkosci okna

        private void ITNews_SizeChanged(object sender, EventArgs e)
        {
            if ( this.Size.Width <= 799)
            {
                urlGroupBox.Size = new Size(203, 544);
                urlTextBox.Size = new Size(175, 13);
                addUrlButton.Size = new Size(175, 40);
                channelsTitleLabel.Size = new Size(175, 50);
                channelsTitleLabel.Location = new Point(13, 77);
                channelsListBox.Size = new Size(175, 84);
                channelsListBox.Location = new Point(13, 133);
                channelsListBox.BackColor = Color.FromArgb(138, 197, 222);
                WebBrowserForXml.Size = new Size(520, 268);
                SitesLabel.Size = new Size(175, 50);
                SitesLabel.Location = new Point(13, 236);
                FavoriteSitesListBox.Size = new Size(175, 95);
                FavoriteSitesListBox.Location = new Point(13, 293);
                LoadWWWbutton.Size = new Size(175, 40);
                LoadWWWbutton.Location = new Point(13, 389);
                WWWtextbox.Size = new Size(175, 13);
                WWWtextbox.Location = new Point(13, 434);
                WebBrowserForXml.Size = new Size(520, 343); // ROZMIAR PRZEGLDARKI
                displayForNewsTabControl.Size = new Size(520, 195); // Rozmiar okna na xml
                // zmiana fonta
                FavoriteSitesListBox.Font = new Font("Centhury gothic", 8);
                channelsListBox.Font = new Font("Centhury gothic", 8);

            }
            else if ( this.Size.Width >= 800)
            {
                /// Planuje jeszcze czcionki zwiekszyc odpowiednio do rozmiaru okna
                urlGroupBox.Size = new Size(320, 544);
                urlTextBox.Size = new Size(294, 13);
                addUrlButton.Size = new Size(294, 60);
                channelsTitleLabel.Size = new Size(294, 50);
                channelsTitleLabel.Location = new Point(13, 97);
                channelsListBox.BackColor = Color.FromArgb(138, 197, 222);
                channelsListBox.Size = new Size(294, 280);
                channelsListBox.Location = new Point(13, 156);
                
                
                SitesLabel.Size = new Size(294, 50);
                SitesLabel.Location = new Point(13, 461);
                FavoriteSitesListBox.Size = new Size(294, 280);
                FavoriteSitesListBox.Location = new Point(13, 520);
                LoadWWWbutton.Size = new Size(294, 60);
                LoadWWWbutton.Location = new Point(13, 807);
                WWWtextbox.Size = new Size(294, 13);
                WWWtextbox.Location = new Point(13, 872);
                WebBrowserForXml.Size = new Size(1020, 740); // ROZMIAR PRZEGLDARKI
                displayForNewsTabControl.Size = new Size(1020, 300); // Rozmiar okna na xml
                // zmiana fonta
                FavoriteSitesListBox.Font = new Font("Centhury gothic", 14);
                channelsListBox.Font = new Font("Centhury gothic", 14);
            }
        }
        #endregion
       

        private void LoadWWWbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Uri uri = new Uri(WWWtextbox.Text);
                WebBrowserForXml.Url = uri;
            }
            
            catch { MessageBox.Show("Nie dodano żadengo adresu URL strony WWW", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error); }
           
            
           
        }

       
    }
}
