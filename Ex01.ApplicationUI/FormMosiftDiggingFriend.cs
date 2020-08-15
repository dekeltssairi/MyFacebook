using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01.ApplicationUI
{
    public partial class FormMosiftDiggingFriend : Form
    {

       

        public FormMosiftDiggingFriend(User mostDiggingFriend, PictureBox f_ProfilePictureBox, int maxNumOfPosts)
        {
            InitializeComponent();                              // designer code
            initializeComponent(mostDiggingFriend, maxNumOfPosts, f_ProfilePictureBox);
        }

        private void initializeComponent(User friend, int numOfPosts, PictureBox f_ProfilePictureBox)
        {
            f_LabelNumOfPosts.Text = string.Format("Most Digging Friend is {0}. He post {1} posts last year", friend.Name, numOfPosts.ToString());
            f_LabelFriendName.Text = friend.Name;
            f_PictureBoxProfilePicture.Load(friend.PictureLargeURL);
            //coverPhotoPictureBox.Load(friend.Cover.SourceURL);

            
        }
    }
}
