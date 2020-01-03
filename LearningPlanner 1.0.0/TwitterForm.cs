using System;
using System.Windows.Forms;
using Tweetinvi;
using System.Diagnostics;
namespace LearningPlanner
{
    public partial class TwitterForm : Form
    {
        public TwitterForm()
        {
            InitializeComponent();

            Secrets sec = new Secrets();

 
            Auth.SetUserCredentials(sec.GetApiKey(), sec.GetApiSecretKey(),
                sec.GetAccessToken(), sec.GetSecretAccessToken());

 
        }
        private void twitterTweetsTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void findButton_Click(object sender, EventArgs e)
        {

            twitterTweetsTextBox.Clear();
            this.Invalidate();
          
            var user = User.GetUserFromScreenName(findTextBox.Text);

            if (twitterComboBox.SelectedItem == null)
            {
                twitterComboBox.SelectedIndex = 3;
            }
            try
            {

                var userTimeLine = Timeline.GetUserTimeline(user, twitterComboBox.SelectedIndex + 1);

                followersLabel.Text = user.Name + Environment.NewLine + "Obserwujących: " + Environment.NewLine
                    + user.FollowersCount;

                var image = user.ProfileImageUrl400x400;
                foundPersonPicture.ImageLocation = image;

                foreach (var item in userTimeLine)
                {
                    twitterTweetsTextBox.AppendText("--- " + item.FullText + " - " + item.CreatedAt
                        + Environment.NewLine + Environment.NewLine);
                }

                followersLabel.Visible = true;
            }
            catch
            {
                twitterTweetsTextBox.Text = "Nie wpisano żadnej nazwy lub użytkownik o podanym nicku nie istnieje!";
                twitterComboBox.SelectedIndex = default;
            }
        }
    }
}
