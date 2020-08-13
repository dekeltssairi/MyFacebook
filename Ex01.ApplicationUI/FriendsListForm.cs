using FacebookWrapper.ObjectModel;
using MRG.Controls.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Ex01.ApplicationUI
{
    public partial class FriendsListForm : Form
    {
        public FriendsListForm(FacebookObjectCollection<User> friends, LoadingCircle loadingCircle1)
        {
            InitializeComponent();
            f_FriendsListBox.Items.Clear();
            fillFriends(friends);
            loadingCircle1.Active = false;
        }

        private void fillFriends(FacebookObjectCollection<User> i_Friends)
        {
            foreach (User friend in i_Friends)
            {
                f_FriendsListBox.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }
        }

        private void displaySelectedFriend(User i_Selecteduser)
        {               
                if (i_Selecteduser.PictureNormalURL != null)
                {
                    f_PictureBox.LoadAsync(i_Selecteduser.PictureNormalURL);
                }
                else
                {
                    f_PictureBox.Image = f_PictureBox.ErrorImage;
                }

                displaySelectedFriendPosts(i_Selecteduser.Posts);   
        }

        private void displaySelectedFriendPosts(FacebookObjectCollection<Post> i_friendsPosts)
        {
            f_PostListBox.Items.Clear();

            new Thread(() =>
            {
                foreach (Post post in i_friendsPosts)
                {
                    f_PostListBox.Items.Add(post);
                }
            }).Start();
            
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f_FriendsListBox.SelectedItems.Count == 1)
                displaySelectedFriend(f_FriendsListBox.SelectedItem as User);
        }
        private void f_PostListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post post = (Post)sender;
        }

        private void f_PostListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
