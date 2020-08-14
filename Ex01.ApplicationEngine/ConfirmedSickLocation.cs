using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.ApplicationEngine
{
    public class ConfirmedSickLocation
    {
        public string Location { get; set; }
        public DateTime DateOfSickConfirmation { get; set; }

        public void CreateConfirmedSickLocation(string i_Location, DateTime i_DateOfSickConfirmation)
        {
            Location = i_Location;
            DateOfSickConfirmation = i_DateOfSickConfirmation;
        }
    }
}
