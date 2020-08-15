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
    public partial class FormCheckinList : Form
    {
        public FormCheckinList(FacebookObjectCollection<Checkin> checkins)
        {
            InitializeComponent();

            f_ListBoxCheckins.Items.Clear();

            foreach (Checkin checkin in checkins)
            {
                f_ListBoxCheckins.Items.Add(checkin.Place.Name);
            }
        }


    }
}
