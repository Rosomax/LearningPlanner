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
        public ZeSwiataIt()
        {
            InitializeComponent();
        }

        private void ZeSwiataIt_Load(object sender, EventArgs e)
        {
            this.Cursor= new Cursor("Resources\\Kursor.cur");
            this.BackColor = Color.FromArgb(138, 197, 222);
           
            
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

                    // Dodanie tytulu wiadomosci z kanalu rss
                    feedList.Items.Add(feedItem.Title.Text);
                    // dodanie textu wiadomosci z kanalu rss
                    feedList.Items.Add(fix_sum);
                    // DOdanie separatora
                    feedList.Items.Add("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
                }
            }
            catch { MessageBox.Show("Nie dodano żadengo adresu URL kanału RSS", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error ); }


        }
    }
}
