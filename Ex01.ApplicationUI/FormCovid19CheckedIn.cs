using Ex01.ApplicationEngine;
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
    public partial class FormCovid19CheckedIn : Form
    {
        private readonly Engine r_engine;
        private Covid19SickPeople ConfirmedSickPeople = new Covid19SickPeople();
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
                ResultStatus_label.Text = "Positive";
            }
            else
            {
                ResultStatus_label.Text = "Negative";
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
                ResultStatus_label.Text = "Positive";
            }
            else
            {
                ResultStatus_label.Text = "Negative";
            }
           
        }

        private void AddToLocationsList()
        {
            Locations_listBox.Items.Clear();
            FacebookObjectCollection<Checkin> checkins = r_engine.Connection.LoggedUser.Checkins;
            foreach (Checkin checkin in checkins)
            {
                string LocationAndTime = string.Format("Location: {0}, Time: {1}",
                    checkin.Place.Name,
                    checkin.CreatedTime);
                Locations_listBox.Items.Add(LocationAndTime);
            }
        }
    }
}
