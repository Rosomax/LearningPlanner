using System;
using System.Windows.Forms;
using Tweetinvi;
using System.Diagnostics;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
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

        private readonly int IDUser = MainForm.UserID;
        

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

                using (LearningPlannerDataBaseEntities model = new LearningPlannerDataBaseEntities())
                {

                    var historyRecord = new TweetsHistory()
                    {
                        IDosoby = IDUser,
                        TwitterUser = user.Name
                    };



                    model.TweetsHistory.Add(historyRecord);
                    model.SaveChanges();

 
                }
                
            }
            catch
            {
                twitterTweetsTextBox.Text = "Nie wpisano żadnej nazwy lub użytkownik o podanym nicku nie istnieje!";
                twitterComboBox.SelectedIndex = default;
            }


        }

        private void TwitterForm_Load(object sender, EventArgs e)
        {

            using (LearningPlannerDataBaseEntities model = new LearningPlannerDataBaseEntities())
            {


                var top1 = model.Top3Users.Select(a => a.TwitterUser).Take(1);
                foreach (var item in top1)
                {

                    MostlySearchedLabel2.Text = "1. " + item;

                }
                var top2 = model.Top3Users.Select(a => a.TwitterUser).Take(2);
                foreach (var item in top2)
                {

                    MostlySearchedLabel3.Text = "2. " + item;

                }
                var top3 = model.Top3Users.Select(a => a.TwitterUser).Take(3);
                foreach (var item in top3)
                {

                    MostlySearchedLabel4.Text = "3. " + item;

                }

            }
        }
    }
}
