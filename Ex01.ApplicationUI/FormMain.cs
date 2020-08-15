using Ex01.ApplicationEngine;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Ex01.ApplicationUI
{
    public partial class FormMain : Form
    {
        private readonly Engine r_AppEngine = new Engine();
        private readonly ApplicationSettings r_AppSettings = ApplicationSettings.LoadFromFile();
        public  FormMain()
        {
            InitializeComponent();
            r_AppEngine.Connection = new FBConnector();
        }
        private void applyAppSettings()
        {
            this.StartPosition = FormStartPosition.Manual;
            f_CheckBoxRememberMe.Checked = r_AppSettings.RememberUser;
            this.Location = r_AppSettings.LastWindowLocation;
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            f_LabelPleaseWait.Visible = true;
            r_AppEngine.Connection.LogIn();
            r_AppSettings.LastAccessToken = r_AppEngine.Connection.AccessToken;
            fetchUserInfo();
            f_LabelPleaseWait.Visible = false;
        }
        protected override void OnShown(EventArgs e)
        {
            if (r_AppSettings.RememberUser && !String.IsNullOrEmpty(r_AppSettings.LastAccessToken))
            {
                r_AppEngine.Connection.Connect(r_AppSettings.LastAccessToken);
                fetchUserInfo();
            }
        }

        private void fetchUserInfo()
        {
            r_AppEngine.Connection.LoggedUser = r_AppEngine.Connection.LoginResult.LoggedInUser;
            f_PictureBoxProfile.Load(r_AppEngine.Connection.LoggedUser.PictureNormalURL);
            handleButtonsVisibility();
            exposeLabels();
        }
        private void exposeLabels()
        {
            f_LabelHelloUser.Text = string.Format("Welcome {0}!", r_AppEngine.Connection.LoggedUser.Name);
            f_LabelHelloUser.Visible = true;
            f_LabelBirthDate.Text = string.Format("Birth date: {0}", r_AppEngine.Connection.LoggedUser.Birthday);
            f_LabelBirthDate.Visible = true;
            f_LabelGender.Text = string.Format("Gender: {0}", r_AppEngine.Connection.LoggedUser.Gender);
            f_LabelGender.Visible = true;
        }
        private void handleButtonsVisibility()
        {
            f_ButtonPost.Enabled = !f_ButtonPost.Enabled;
            f_ButtonLogin.Enabled = !f_ButtonLogin.Enabled;
            f_ButtonLogout.Enabled = !f_ButtonLogout.Enabled;
            f_ButtonCovid19.Enabled = !f_ButtonCovid19.Enabled;
            f_ButtonMyAlbums.Enabled = !f_ButtonMyAlbums.Enabled;
            f_ButtonShowLikes.Enabled = !f_ButtonShowLikes.Enabled;
            f_ButtonShowChekins.Enabled = !f_ButtonShowChekins.Enabled;
            f_ButtonShowMyPosts.Enabled = !f_ButtonShowMyPosts.Enabled;
            f_ButtonShowFriends.Enabled = !f_ButtonShowFriends.Enabled;
            f_ButtonShowMyEvents.Enabled = !f_ButtonShowMyEvents.Enabled;
            f_ButtonShowMostDiggingFriend.Enabled = !f_ButtonShowMostDiggingFriend.Enabled;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            r_AppSettings.LastWindowLocation = Location;
            r_AppSettings.LastWindowSize = Size;
            r_AppSettings.RememberUser = f_CheckBoxRememberMe.Checked;
            if (r_AppSettings.RememberUser)
            {
                r_AppSettings.LastAccessToken = r_AppEngine.Connection.LoginResult.AccessToken;
            }
            else
            {
                r_AppSettings.LastAccessToken = null;
            }

            r_AppSettings.SaveToFile();
        }
        private void clearForm()
        {
           this.Dispose(false);
           new FormMain().Show();
        }
        private void fetchPosts()                   // try just to add the post as is
        {
            foreach (Post post in r_AppEngine.Connection.LoggedUser.Posts)
            {
                if (post.Message != null)
                {
                    f_ListBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    f_ListBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    f_ListBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (r_AppEngine.Connection.LoggedUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (r_AppEngine.Connection.LoggedUser != null)
            {
                FacebookService.Logout(() => { });
                f_CheckBoxRememberMe.Checked = false;
                r_AppSettings.RememberUser = false;
                r_AppSettings.SaveToFile();
                clearForm();
            }
            else
            {
                MessageBox.Show("You must loggin first!");
            }
        }
        private void f_ShowFriendsButton_Click(object sender, EventArgs e)
        {
            f_LabelPleaseWait.Visible = true;
            if (r_AppEngine.Connection.LoggedUser == null)
            {
                MessageBox.Show("You must loggin first!");
            }
            else if (r_AppEngine.Connection.LoggedUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
            else
            {
                new Thread(onFriendListThread).Start();
            }

            f_LabelPleaseWait.Visible = false;
        }
        private void onFriendListThread()
        {
            new FormFriendList(r_AppEngine.Connection.LoggedUser.Friends).ShowDialog();
        }
        private void f_CheckinsButton_Click(object sender, EventArgs e)
        {
            f_LabelPleaseWait.Visible = true;
            if (r_AppEngine.Connection.LoggedUser == null)
            {
                MessageBox.Show("You must loggin first!");
            }
            else if (r_AppEngine.Connection.LoggedUser.Checkins.Count == 0)
            {
                MessageBox.Show("No Checkins to retrieve :(");
            }
            else
            {
                new FormCheckinList(r_AppEngine.Connection.LoggedUser.Checkins).ShowDialog();
            }

            f_LabelPleaseWait.Visible = false;
        }
        private void fetchEvents()
        {
            f_ListBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in r_AppEngine.Connection.LoggedUser.Events)
            {
                f_ListBoxEvents.Items.Add(fbEvent);
            }
        }
        private void buttonMostDiggingFriend_Click(object sender, EventArgs e)
        {
            f_LabelPleaseWait.Visible = true;
            if (r_AppEngine.Connection.LoggedUser != null)
            {
                DateTime lastYear = DateTime.Today.AddYears(-1);
                User mostDiggingFriend = null;
                int postCounter, maxNumOfPosts = 0;
                
                foreach (User friend in r_AppEngine.Connection.LoggedUser.Friends)
                {
                    postCounter = 0;
                    foreach (Post post in friend.Posts)
                    {
                        if (post.CreatedTime > lastYear)
                        {
                            postCounter++;
                        }
                    }
                    if (postCounter > maxNumOfPosts)
                    {
                        maxNumOfPosts = postCounter;
                        mostDiggingFriend = friend;
                    }
                }

                new FormMosiftDiggingFriend(mostDiggingFriend, f_PictureBoxProfile, maxNumOfPosts).ShowDialog();
            }
            else
            {
                MessageBox.Show("You must loggin first!");
            }

            f_LabelPleaseWait.Visible = false;
        }
        private void f_Postbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Out of Permission!");
        }
        private void Covid19_button_Click(object sender, EventArgs e)
        {
            f_LabelPleaseWait.Visible = true;

            if (r_AppEngine.Connection.LoggedUser == null)
            {
                MessageBox.Show("You must loggin first!");
            }
            else if (r_AppEngine.Connection.LoggedUser.Checkins.Count == 0)
            {
                MessageBox.Show("You dont have any chekins");
            }
            else
            {
                new FormCovid19CheckedIn(r_AppEngine).ShowDialog();                
            }

            f_LabelPleaseWait.Visible = false;
        }
        private void buttonShowMyPost_Click(object sender, EventArgs e)
        {
            f_LabelPleaseWait.Visible = true;

            if (r_AppEngine.Connection.LoggedUser != null)
            {
                f_ListBoxPosts.Items.Clear();
                fetchPosts();
            }
            else
            {
                MessageBox.Show("You must loggin first!");
            }

            f_LabelPleaseWait.Visible = false;
        }
        private void buttonShowMyEvents_Click(object sender, EventArgs e)
        {
            f_LabelPleaseWait.Visible = true;

            if (r_AppEngine.Connection.LoggedUser == null)
            {
                MessageBox.Show("You must loggin first!");
            }
            else if (r_AppEngine.Connection.LoggedUser.Events.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
            else
            {
                fetchEvents();
            }

            f_LabelPleaseWait.Visible = false;
        }
        private void buttonShowMyLikes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Out of Permission!");
        }
        private void buttonMyAlbums_Click(object sender, EventArgs e)
        {
            f_LabelPleaseWait.Visible = true;
            if (r_AppEngine.Connection.LoggedUser == null)
            {
                MessageBox.Show("You must loggin first!");
            }
            else if (r_AppEngine.Connection.LoggedUser.Albums.Count == 0)
            {
                MessageBox.Show("No albums to retrieve :(");
            }
            else
            {
                f_LabelPleaseWait.Visible = false;
                new FormAlbums(r_AppEngine.Connection.LoggedUser.Albums).ShowDialog();  
            }
        }
    }
}