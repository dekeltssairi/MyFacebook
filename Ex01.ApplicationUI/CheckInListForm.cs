using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01.ApplicationUI
{
    public partial class CheckInListForm : Form
    {
        public CheckInListForm(FacebookObjectCollection<Checkin> checkins)
        {
            InitializeComponent();

            f_CheckinListBox.Items.Clear();

            foreach (Checkin checkin in checkins)
            {
                f_CheckinListBox.Items.Add(checkin.Place.Name);
            }
        }


    }
}
