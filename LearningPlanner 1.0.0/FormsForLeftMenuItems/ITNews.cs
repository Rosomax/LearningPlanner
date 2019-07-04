using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Collections.Generic;
using System.Linq;
using LearningPlanner.Properties;
namespace LearningPlanner
{
    public partial class ITNews : Form
    {
        public ITNews()
        {
            InitializeComponent();
        }

        List<string> rssAdresses = new List<string>
        {
            "http://technow.pl/feed",
           "https://pclab.pl/xml/rss.xml",
           "https://itreseller.com.pl/feed/",
           "http://www.itworld.com/news/index.rss",
           "http://www.computerworld.com/index.rss",
            "http://www.huj.com/index.rss"
        };

        List<string> rssNames = new List<string>
        {
        "TECHNOW",
        "PC-LAB",
        "ITRESELLER",
        "ITWORLD",
        "COMPUTERWORLD",       
        };

        List<string> wwwAdresses = new List<string>
        {
        "https://www.itnews.com/",
        "https://stackoverflow.com/"
        };

        List<string> wwwNames = new List<string>
        {
        "IT NEWS IDG",
        "STACKOVERFLOW"
        };
        

        private void ITNews_Load(object sender, EventArgs e)
        {
         

            BackColor = Color.FromArgb(Settings.Default.RValue, Settings.Default.GValue, Settings.Default.BValue);


            FillChannels();
            FillSites();

        }

        private void FillChannels()
        {
            foreach (var item in rssNames)
            {
                ChannelsListBox.Items.Add(item);
            }
        }

        private void FillSites()
        {
            foreach (var item in wwwNames)
            {
                FavoriteSitesListBox.Items.Add(item);
            }
        }


        private void ITNews_SizeChanged(object sender, EventArgs e)
        {
            if (Size.Width <= 799)
            {
                DefaultResponsives dresp = new DefaultResponsives();
                dresp.ITNewsDefaultResponse(this);
            }
            else 
            {
                Responsiveness responsiveness = new Responsiveness();
                responsiveness.ITNewsResponse(this);
            }
        }


        #region Change strings to URL and transfer to textbox for xmls
       
        private void TransferToUrlTextBox()
        {
            if (ChannelsListBox.SelectedItem != null)
            {
                int[] capacity = new int[10];
                string copyUrl = (ChannelsListBox.SelectedItem as string);
                for (int i = 0; i < ChannelsListBox.Items.Count; i++)
                {
                    capacity[i] = i;
                    if (ChannelsListBox.SelectedIndex == i)
                    copyUrl = rssAdresses[i];
                }
                UrlTextBox.Text = copyUrl;
            }
                
        }


        private void TransferToUrlWWWTextBox()
        {
            if (FavoriteSitesListBox.SelectedItem != null)
            {
                int[] capacity = new int[10];
                string copyWWWUrl = (FavoriteSitesListBox.SelectedItem as string);
                for (int i = 0; i < FavoriteSitesListBox.Items.Count; i++)
                {
                   capacity[i] = i;

                    if (FavoriteSitesListBox.SelectedIndex == i)
                        copyWWWUrl = wwwAdresses[i];
                }
                WWWtextbox.Text = copyWWWUrl;
                //copyWWWUrl = (FavoriteSitesListBox.SelectedItem as string);
            }

        }
        #endregion

       

      


        private void AddUrlButton_Click(object sender, EventArgs e)
        {
         try
            {
                XmlReader feedReadXML = XmlReader.Create(UrlTextBox.Text);
                SyndicationFeed feedXML = SyndicationFeed.Load(feedReadXML);
                TabPage feedTab = new TabPage(feedXML.Title.Text);
                DisplayForNewsTabControl.TabPages.Add(feedTab);
                ListBox feedList = new ListBox();
                feedTab.Controls.Add(feedList);
                feedList.Dock = DockStyle.Fill;
                feedList.HorizontalScrollbar = true;


                foreach (SyndicationItem feedItem in feedXML.Items)
                {


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

                   
                    feedList.Items.Add(feedItem.Title.Text);
                   
                    feedList.Items.Add(fix_sum);
                                   
                    
                    feedList.Items.Add("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
                }
            }
            catch { MessageBox.Show("Nie dodano żadengo adresu URL kanału RSS", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error ); }


        }
      
        private void ChannelsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            TransferToUrlTextBox();
        }
        private void FavoriteSitesListBox_MouseClick(object sender, MouseEventArgs e)
        {
            TransferToUrlWWWTextBox();
        }
   

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
