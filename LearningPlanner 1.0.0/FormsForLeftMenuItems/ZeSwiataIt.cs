using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.ServiceModel.Syndication;

namespace LearningPlanner_1._0._0
{
    public partial class ZeSwiataIt : Form
    {
#region Kanały RSS po linkach
        string s0 = "https://www.gry-online.pl/rss/news.xml"; // gryonline
        string s1 = "http://pclab.pl/xml/rss.xml"; //pclab
        string s2 = "http://www.gazeta.pl/pub/rss/sport.xml"; // Sport
        string s3 = "http://kanaly.rss.interia.pl/fakty.xml"; // Fakty kraj interia
        string s4 = "http://vitalia.pl/artykuly.xml"; // Dietetyka

        #endregion

 #region STRONY WWW po linkach
        string ws0 = "https://www.itnews.com/";//itnews
        string ws1 = "https://stackoverflow.com/"; //stackoverflow

#endregion

 public ZeSwiataIt()
        {
            InitializeComponent();
        }

        private void ZeSwiataIt_Load(object sender, EventArgs e)
        {
            this.Cursor= new Cursor("Resources\\Kursor.cur");
            this.BackColor = Color.FromArgb(138, 197, 222);
            #region  Nazwy dla channel box
            
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
            #endregion

            #region NAZWY WWW do BOXA POLECANE

            string wst0 = "IT NEWS IDG";
            string wst1 = "STACKOVERFLOW";
                                                       

            PolecaneStronyListBox.Items.Add(wst0);
            PolecaneStronyListBox.Items.Add(wst1);
            #endregion
        }

        #region ZAMIANY stringow na url i transfer ich do tex boxa dla xml-a i WWW
        // Dla XML - zamiana string na url
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
                copyUrl = (channelsListBox.SelectedItem as string);  // chyba usunac
            }
                
        }

        // Zamiana string na url dla WWW
        private void transferToUrlWWWTextBox()
        {
            if (PolecaneStronyListBox.SelectedItem != null)
            {
                string copyWWWUrl;
                copyWWWUrl = (PolecaneStronyListBox.SelectedItem as string);
                if (PolecaneStronyListBox.SelectedIndex == 0)
                {
                    copyWWWUrl = ws0;
                }
                else if (PolecaneStronyListBox.SelectedIndex == 1)
                {
                    copyWWWUrl = ws1;
                }
                else if (PolecaneStronyListBox.SelectedIndex == 2)
                {
                    copyWWWUrl = s2;
                }
                else if (PolecaneStronyListBox.SelectedIndex == 3)
                {
                    copyWWWUrl = s3;
                }
                else if (PolecaneStronyListBox.SelectedIndex == 4)
                {
                    copyWWWUrl = s4;
                }
                WWWtextbox.Text = copyWWWUrl;
                copyWWWUrl = (PolecaneStronyListBox.SelectedItem as string);   /// -TU trzeba bedzie pewnie na uri skonwertowac
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
        private void PolecaneStronyListBox_MouseClick(object sender, MouseEventArgs e)
        {
            transferToUrlWWWTextBox();
        }

        #region zmianay w responsowynosci, ukladzie i wielkosci formantow przy zmianach wielkosci okna

        private void ZeSwiataIt_SizeChanged(object sender, EventArgs e)
        {
            if ( this.Size.Width <= 799)
            {
                channelsListBox.Size = new Size(175, 95);
                channelsListBox.BackColor = Color.FromArgb(138, 197, 222);
                WebBrowserForXml.Size = new Size(520, 268);
                StronyLabel.Size = new Size(175, 50);
                StronyLabel.Location = new Point(13, 236);
                PolecaneStronyListBox.Size = new Size(175, 95);
                PolecaneStronyListBox.Location = new Point(13, 293);
                ZaladujWWWbutton.Size = new Size(175, 40);
                ZaladujWWWbutton.Location = new Point(13, 389);
                WWWtextbox.Size = new Size(175, 13);
                WWWtextbox.Location = new Point(13, 434);

            }
            else if ( this.Size.Width >= 800)
            {
                channelsListBox.BackColor = Color.FromArgb(138, 197, 222);
                channelsListBox.Size = new Size(176, 200);
                WebBrowserForXml.Size = new Size(520, 560);
                StronyLabel.Size = new Size(175, 50);
                StronyLabel.Location = new Point(13, 361);
                PolecaneStronyListBox.Size = new Size(175, 200);
                PolecaneStronyListBox.Location = new Point(13, 420);
                ZaladujWWWbutton.Size = new Size(175, 40);
                ZaladujWWWbutton.Location = new Point(13, 627);
                WWWtextbox.Size = new Size(175, 13);
                WWWtextbox.Location = new Point(13, 672);
            }
        }
        #endregion
        private void displayForNewsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ZaladujWWWbutton_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(WWWtextbox.Text);
            WebBrowserForXml.Url = uri;
        }

       
    }
}
