using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Ex01.ApplicationEngine;


namespace Ex01.ApplicationUI
{
    public partial class FormAppMain : Form
    {
        private readonly Engine r_AppEngine = new Engine();
        private readonly ApplicationSettings r_AppSettings = ApplicationSettings.LoadFromFile();


        public FormAppMain()
        {
            InitializeComponent();
            r_AppEngine.Connection = new FBConnector();
            applyAppSettings();
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

            r_AppSettings.LastWindowLocation = this.Location;
            r_AppSettings.LastWindowSize = this.Size;
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
                        f_EventpictureBox .LoadAsync(latestPost.PictureURL);
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {

            FacebookService.Logout(() => { });
            f_RememberMeCheckBox.Checked = false;
            r_AppSettings.RememberUser = false;
            r_AppSettings.SaveToFile();
            clearForm();

        }
    }
}
