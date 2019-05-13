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
        public ZeSwiataIt()
        {
            InitializeComponent();
        }

        private void ZeSwiataIt_Load(object sender, EventArgs e)
        {
            this.Cursor= new Cursor("Resources\\Kursor.cur");
            this.BackColor = Color.FromArgb(138, 197, 222);
            #region channel box
            
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
        }

      

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

        private void channelsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            transferToUrlTextBox();
        }

        

        private void ZeSwiataIt_SizeChanged(object sender, EventArgs e)
        {
            if ( this.Size.Width <= 799)
            {
                channelsListBox.Size = new Size(176, 212);
                channelsListBox.BackColor = Color.PaleGreen;
            }
            else if ( this.Size.Width >= 800)
            {
                channelsListBox.BackColor = Color.Red;
                channelsListBox.Size = new Size(176, 500);
            }
        }
    }
}
