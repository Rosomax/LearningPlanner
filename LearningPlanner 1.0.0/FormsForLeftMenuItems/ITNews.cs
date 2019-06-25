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

       
        string s0 = "http://technow.pl/feed"; 
        string s1 = "https://pclab.pl/xml/rss.xml"; 
        string s2 = "https://itreseller.com.pl/feed/"; 
        string s3 = "http://www.itworld.com/news/index.rss"; 
        string s4 = "http://www.computerworld.com/index.rss"; 
      
       
        string ws0 = "https://www.itnews.com/";
        string ws1 = "https://stackoverflow.com/"; 



       public ITNews()
        {
            InitializeComponent();
        }

        private void ITNews_Load(object sender, EventArgs e)
        {
         

            BackColor = Color.FromArgb(Settings.Default.RValue, Settings.Default.GValue, Settings.Default.BValue);

            string s0t = "TECHNOW";
            string s1t = "PC-LAB";
            string s2t = "ITRESELLER";
            string s3t = "ITWORLD";
            string s4t = "COMPUTERWORLD";
            ChannelsListBox.Items.Add(s0t);
            ChannelsListBox.Items.Add(s1t);
            ChannelsListBox.Items.Add(s2t);
            ChannelsListBox.Items.Add(s3t);
            ChannelsListBox.Items.Add(s4t);
                     
            string wst0 = "IT NEWS IDG";
            string wst1 = "STACKOVERFLOW";
                                                       
            FavoriteSitesListBox.Items.Add(wst0);
            FavoriteSitesListBox.Items.Add(wst1);


            ITNewsFormChangeFont();
        }

        private void ITNews_SizeChanged(object sender, EventArgs e)
        {
            if (this.Size.Width <= 799)
            {
                urlGroupBox.Size = new Size(203, 544);
                UrlTextBox.Size = new Size(175, 13);
                AddUrlButton.Size = new Size(175, 40);
                ChannelsTitleLabel.Size = new Size(175, 50);
                ChannelsTitleLabel.Location = new Point(13, 77);
                ChannelsListBox.Size = new Size(175, 84);
                ChannelsListBox.Location = new Point(13, 133);
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
                DisplayForNewsTabControl.Size = new Size(520, 195); // Rozmiar okna na xml
                // zmiana fonta
                FavoriteSitesListBox.Font = new Font("Centhury gothic", 8);
                ChannelsListBox.Font = new Font("Centhury gothic", 8);

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

                string copyUrl = (ChannelsListBox.SelectedItem as string);
                if(ChannelsListBox.SelectedIndex==0)
                {
                    copyUrl = s0;
                }
                else if(ChannelsListBox.SelectedIndex == 1)
                {
                    copyUrl = s1;
                }
                 else if(ChannelsListBox.SelectedIndex == 2)
                {
                    copyUrl = s2;
                }
                else if (ChannelsListBox.SelectedIndex == 3)
                {
                    copyUrl = s3;
                }
                else if (ChannelsListBox.SelectedIndex == 4)
                {
                    copyUrl = s4;
                }
                UrlTextBox.Text = copyUrl;
                //copyUrl = (channelsListBox.SelectedItem as string);  
            }
                
        }

        // Change string to url for WWW
        private void TransferToUrlWWWTextBox()
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




        #region ChangeFontFromSettings

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }


        public void ITNewsFormChangeFont()
        {

            foreach (var lbl in GetAll(this, typeof(Label)))
            {
                if (Settings.Default.BoldFont)
                    (lbl as Label).Font = new Font(Settings.Default.RememberFont, 12, FontStyle.Bold);
                else
                    (lbl as Label).Font = new Font(Settings.Default.RememberFont, 12);

            }

            foreach (var btn in GetAll(this, typeof(Button)))
            {
                if (Settings.Default.BoldFont)
                    (btn as Button).Font = new Font(Settings.Default.RememberFont, 14, FontStyle.Bold);
                else
                    (btn as Button).Font = new Font(Settings.Default.RememberFont, 14);
            }

            foreach (var tb in GetAll(this, typeof(TextBox)))
            {
                if (Settings.Default.BoldFont)
                    (tb as TextBox).Font = new Font(Settings.Default.RememberFont, 8, FontStyle.Bold);
                else
                    (tb as TextBox).Font = new Font(Settings.Default.RememberFont, 8);
            }

            foreach (var lb in GetAll(this, typeof(ListBox)))
            {
                try
                {
                    if (Settings.Default.BoldFont)
                        (lb as ListBox).Font = new Font(Settings.Default.RememberFont, 8, FontStyle.Bold);
                    else
                        (lb as ListBox).Font = new Font(Settings.Default.RememberFont, 8);

                }

                catch { }
                
                }


        }

        #endregion
    }
}
