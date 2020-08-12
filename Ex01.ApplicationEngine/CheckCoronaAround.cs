using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Ex01.ApplicationEngine
{
    class CheckCoronaAround
    {
        public User LoggedUser { get; set; }

        private readonly User[] r_FriendsToCheck;

        public User[] FriendsToCheck
        {
            get
            {
                return r_FriendsToCheck;
            }
        }

        public void FindCoronaVirus(ListBox i_FriendsListChosenFriends)
        {
            foreach (User friend in i_FriendsListChosenFriends.Items)
            {
                   
            }
        }


    }
}
