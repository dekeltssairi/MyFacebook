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
    public partial class FormFriendList : Form
    {
        public FormFriendList(FacebookObjectCollection<User> friends)
        {
            InitializeComponent();
            f_ListBoxFriends.Items.Clear();
            fillFriends(friends);
        }

        private void fillFriends(FacebookObjectCollection<User> i_Friends)
        {
            foreach (User friend in i_Friends)
            {
                f_ListBoxFriends.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }
        }

        private void displaySelectedFriend(User i_Selecteduser)
        {               
                if (i_Selecteduser.PictureNormalURL != null)
                {
                    f_PictureBoxProfile.LoadAsync(i_Selecteduser.PictureNormalURL);
                }
                else
                {
                    f_PictureBoxProfile.Image = f_PictureBoxProfile.ErrorImage;
                }

                displaySelectedFriendPosts(i_Selecteduser.Posts);   
        }

        private void displaySelectedFriendPosts(FacebookObjectCollection<Post> i_friendsPosts)
        {
            f_ListBoxPosts.Items.Clear();
           foreach (Post post in i_friendsPosts)
                {
                    f_ListBoxPosts.Items.Add(post);
                }
           
            
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f_ListBoxFriends.SelectedItems.Count == 1)
                displaySelectedFriend(f_ListBoxFriends.SelectedItem as User);
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
