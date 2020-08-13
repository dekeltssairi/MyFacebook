using Ex01.ApplicationEngine;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01.ApplicationUI
{
    public partial class FormCovid19CheckedIn : Form
    {
        private readonly Engine r_engine;
        private Covid19SickPeople ConfirmedSickPeople = Covid19SickPeople.LoadFromFile();
        private ConfirmedSickLocation LocationInput = new ConfirmedSickLocation();

        public FormCovid19CheckedIn(Engine i_Engine)
        {
            r_engine = i_Engine;
            InitializeComponent();

        }

        private void AddConfirmedSickLocation_button_Click(object sender, EventArgs e)
        {
            LocationInput.DateOfSickConfirmation = LocationTimeToCheck_dateTimePicker.Value;
            LocationInput.Location = LocationDescription_textBox.Text;
            ConfirmedSickPeople.AddConfirmedLocationTotheList(LocationInput);

            LocationDescription_textBox.Clear();
        }

        private void CheckUserLocation_button_Click(object sender, EventArgs e)
        {
            LocationInput.DateOfSickConfirmation = LocationTimeToCheck_dateTimePicker.Value;
            LocationInput.Location = LocationDescription_textBox.Text;
            if (ConfirmedSickPeople.CheckIfLocationIsInTheList(LocationInput))
            {
                ResultStatus_label.Text = Utilities.Constants.NegaiveMessage;
            }
            else
            {
                ResultStatus_label.Text = Utilities.Constants.NegaiveMessage;
            }

            LocationDescription_textBox.Clear();
        }

        private void MyCheckins_button_Click(object sender, EventArgs e)
        {
            AddToLocationsList();
        }

        private void LoadSickList_button_Click(object sender, EventArgs e)
        {
            Locations_listBox.Items.Clear();
            foreach (ConfirmedSickLocation confirmedSickLocation in ConfirmedSickPeople.ConfirmedSickLocations)
            {
                Locations_listBox.Items.Add(string.Format("{0},{1}", confirmedSickLocation.Location, confirmedSickLocation.DateOfSickConfirmation));
            }
        }

        private void CheckMyCheckins_button_Click(object sender, EventArgs e)
        {
            FacebookObjectCollection<Checkin> checkins = r_engine.Connection.LoggedUser.Checkins;
            bool result = false;
            foreach (Checkin checkin in checkins)
            {
                LocationInput.DateOfSickConfirmation = checkin.CreatedTime;
                LocationInput.Location = checkin.Name;
                if(ConfirmedSickPeople.CheckIfLocationIsInTheList(LocationInput))
                {
                    result = true;
                } 
            }

            if(result == true)
            {
                ResultStatus_label.Text = Utilities.Constants.PositiveMessage;
            }
            else
            {
                ResultStatus_label.Text = Utilities.Constants.NegaiveMessage;
            }
           
        }

        private void AddToLocationsList()
        {
            Locations_listBox.Items.Clear();
            FacebookObjectCollection<Checkin> checkins = r_engine.Connection.LoggedUser.Checkins;
            foreach (Checkin checkin in checkins)
            {
                Locations_listBox.Items.Add(checkin);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            ConfirmedSickPeople.SaveToFile();
        }

        private void Locations_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Locations_listBox.SelectedItems.Count == 1)
            {
                displaySelectedLocation(Locations_listBox.SelectedItem as Checkin);
            }
        }

        private void displaySelectedLocation(Checkin i_Checkin)
        {
            if (i_Checkin != null)
            {
                LocationDescription_textBox.Text = i_Checkin.Place.Name ?? " ";
                LocationTimeToCheck_dateTimePicker.Value = i_Checkin.CreatedTime ?? LocationTimeToCheck_dateTimePicker.Value;
            }
        }

        private void Friends_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Friends_listBox.SelectedItems.Count == 1)
            {
                displaySelectedFriendCheckIns(Locations_listBox.SelectedItem as User);
            }
        }

        private void displaySelectedFriendCheckIns(User i_SelectedUser)
        {
            Friends_listBox.Items.Clear();

            new Thread(() =>
            {
                foreach (Checkin checkin in i_SelectedUser.Checkins)
                {
                    Friends_listBox.Items.Add(checkin);
                }
            }).Start();
        }
    }
}
