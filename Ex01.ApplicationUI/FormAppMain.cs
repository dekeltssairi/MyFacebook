using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Ex01.ApplicationEngine;
using System.Threading;

namespace Ex01.ApplicationUI
{
    public partial class FormAppMain : Form
    {
        private readonly Engine r_AppEngine = new Engine();
        private readonly ApplicationSettings r_AppSettings = ApplicationSettings.LoadFromFile();
        

        public FormAppMain()
        {

            InitializeComponent();
            this.Size = new System.Drawing.Size(1200, 800);
            r_AppEngine.Connection = new FBConnector();
        }

        private void applyAppSettings()
        {
            this.StartPosition = FormStartPosition.Manual;
            f_RememberMeCheckBox.Checked = r_AppSettings.RememberUser;
            this.Size = r_AppSettings.LastWindowSize;
            this.Location = r_AppSettings.LastWindowLocation;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            r_AppEngine.Connection.LogIn();
            r_AppSettings.LastAccessToken = r_AppEngine.Connection.AccessToken;
            fetchUserInf();
        }

        protected override void OnShown(EventArgs e)
        {
            if (r_AppSettings.RememberUser && !String.IsNullOrEmpty(r_AppSettings.LastAccessToken))
            {
                r_AppEngine.Connection.Connect(r_AppSettings.LastAccessToken);
                fetchUserInf();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //r_AppEngine.Connection.LogIn();
            //r_AppSettings.LastAccessToken = r_AppEngine.Connection.AccessToken;
            //fetchUserInf();
        }

        private void fetchUserInf()
        {
            enableButtons();
            r_AppEngine.Connection.LoggedUser = r_AppEngine.Connection.LoginResult.LoggedInUser;
            f_ProfilePictureBox.Load(r_AppEngine.Connection.LoggedUser.PictureNormalURL);
            helloUserLabel.Text = string.Format("Welcome {0}!", r_AppEngine.Connection.LoggedUser.Name);
            helloUserLabel.Visible = true;
/*            foreach (Album album in r_AppEngine.Connection.LoggedUser.Albums)
            {
                if (album.Name == "Cover photos")
                {
                    cover_smallPictureBox.Load(album.PictureThumbURL);
                }
            }*/

            f_UserWellcome.Text = string.Format("Hello, {0}", r_AppEngine.Connection.LoggedUser.Name);
            getLastPostByUser();
        }

        private void enableButtons()
        {
            buttonLogout.Enabled = true;
            buttonLogin.Enabled = false;
            f_Postbutton.Enabled = true;
            f_ShowFriendsButton.Enabled = true;
            f_PostCommentslistBox.Enabled = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            r_AppSettings.LastWindowLocation = Location;
            r_AppSettings.LastWindowSize = Size;
            r_AppSettings.RememberUser = f_RememberMeCheckBox.Checked;
            if (r_AppSettings.RememberUser == true)
            {
                r_AppSettings.LastAccessToken = r_AppEngine.Connection.LoginResult.AccessToken;
            }
            else
            {
                r_AppSettings.LastAccessToken = null;
            }

            r_AppSettings.SaveToFile();
        }

        private void getLastPostByUser()
        {
            Post latestPost = null;

            try
            {
                if (r_AppEngine.Connection.LoggedUser.Posts.Count > 0)
                {
                    latestPost = r_AppEngine.Connection.LoggedUser.Posts[0];
                    if (latestPost.Type.Value == Post.eType.status)
                    {
                        f_lastPostStaus.Visible = true;
                        f_lastPostStaus.Text = latestPost.Message;
                        f_lastPostStaus.ReadOnly = true;
                    }
                    else if (latestPost.Type.Value == Post.eType.photo)
                    {
                        f_EventpictureBox.Visible = true;
                        f_EventpictureBox.LoadAsync(latestPost.PictureURL);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void clearForm()
        {
            this.Dispose(false);
            FormAppMain newForm = new FormAppMain();

            newForm.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void fetchPosts()
        {
            foreach (Post post in r_AppEngine.Connection.LoggedUser.Posts)
            {
                if (post.Message != null)
                {
                    listBox1.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBox1.Items.Add(post.Caption);
                }
                else
                {
                    listBox1.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (r_AppEngine.Connection.LoggedUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {

            FacebookService.Logout(() => { });
            f_RememberMeCheckBox.Checked = false;
            r_AppSettings.RememberUser = false;
            r_AppSettings.SaveToFile();
            clearForm();

        }

        private void f_ShowFriendsButton_Click(object sender, EventArgs e)
        {
            
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

        }

        private void onFriendListThread()
        {
            new FriendsListForm(r_AppEngine.Connection.LoggedUser.Friends).ShowDialog();
        }
        private void f_CheckinsButton_Click(object sender, EventArgs e)
        {
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
                new CheckInListForm(r_AppEngine.Connection.LoggedUser.Checkins).ShowDialog();
            }
        }

        private void fetchEvents()
        {
            listBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in r_AppEngine.Connection.LoggedUser.Events)
            {
                listBoxEvents.Items.Add(fbEvent);
            }

        }
        private void buttonMostDiggingFriend_Click(object sender, EventArgs e)
        {
            DateTime lastYear = DateTime.Today.AddYears(-1);
            User mostDiggingFriend = null;
            int maxNumOfPosts = 0;
            int numOfLastYearFriendPost; 
            foreach(User friend in r_AppEngine.Connection.LoggedUser.Friends)
            {
                numOfLastYearFriendPost = 0;
                foreach (Post post in friend.Posts)
                {
                    if (post.CreatedTime > lastYear)
                    {
                        numOfLastYearFriendPost++;
                    }
                }
                if (numOfLastYearFriendPost > maxNumOfPosts)
                {
                    maxNumOfPosts = numOfLastYearFriendPost;
                    mostDiggingFriend = friend;
                }
            }

            MessageBox.Show(string.Format("Most Digging Friend is {0}. He post {1} posts last year", mostDiggingFriend.Name, maxNumOfPosts.ToString()));
        }

        private void FormAppMain_Load(object sender, EventArgs e)
        {

        }

        private void f_Postbutton_Click(object sender, EventArgs e)
        {

        }

        private void Covid19_button_Click(object sender, EventArgs e)
        {
            if (r_AppEngine.Connection.LoggedUser == null)
            {
                MessageBox.Show("You must loggin first!");
            }
            else
            {
                new FormCovid19CheckedIn(r_AppEngine).ShowDialog();
            }
        }

        private void buttonShowMyPost_Click(object sender, EventArgs e)
        {
            if (r_AppEngine.Connection.LoggedUser != null)
            {
                listBox1.Items.Clear();
                fetchPosts();
            }
            else
            {
                MessageBox.Show("You must loggin first!");
            }
        }

        private void buttonShowMyEvents_Click(object sender, EventArgs e)
        {
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
        }
    }
}
