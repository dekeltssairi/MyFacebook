using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    /*
     * Ip getIp(destination)
     * {
     *      שאל את הלוקל סרבר האם יש בידיו את התשובה
     *      אם יש לו את התשובה סיימנו. אחרת, הלוקל סרבר ילך למצוא את התשובה
     *      הגדר משתנה חדש : שורש שיקבל את שורש הדיאןאס
     *      כל עוד ללוקל סרבר אין דומיין מלא:
     *      גש לשורש ובקש ממנו רקורסיה, אם מסכים סבבה
     *      אחרת בקש תשובה "איטרטיבית" ע
     *      אם חזר הדומיין, צא מהלולאה והחזר לקליינט
     *      אחרת, שים ברוט את התשובה
     */
    public partial class FriendsListForm : Form
    {
        public FriendsListForm(FacebookObjectCollection<User> friends)
        {
            InitializeComponent();
            f_FriendsListBox.Items.Clear();
            fillFriends(friends);
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
            foreach (Post post in i_friendsPosts)
            {
                if (post.Message != null)
                {
                    f_PostListBox.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    f_PostListBox.Items.Add(post.Caption);
                }
                else
                {
                    f_PostListBox.Items.Add(string.Format("[{0}]", post.Type));
                }
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f_FriendsListBox.SelectedItems.Count == 1)
                displaySelectedFriend(f_FriendsListBox.SelectedItem as User);
        }
    }
}
