using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Ex01.ApplicationEngine
{
    public class Covid19SickPeople
    {
        private const string k_SickPeopleFileSuffix = @"\\Covid19SickPeople.xml";
        public List<ConfirmedSickLocation> ConfirmedSickLocations { get; set;}

        public static Covid19SickPeople LoadFromFile()
        {
            Covid19SickPeople covid19SickPeople = new Covid19SickPeople();

            if (File.Exists(Directory.GetCurrentDirectory() + k_SickPeopleFileSuffix))
            {
                using (Stream xmlStream = new FileStream(Directory.GetCurrentDirectory() + k_SickPeopleFileSuffix, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Covid19SickPeople));
                    covid19SickPeople = serializer.Deserialize(xmlStream) as Covid19SickPeople;
                }
            }

            return covid19SickPeople;
        }

        public Covid19SickPeople()
        {
            // load default locations
            ConfirmedSickLocations = new List<ConfirmedSickLocation>();
        }

        public void SaveToFile()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + k_SickPeopleFileSuffix))
            {
                File.Delete(Directory.GetCurrentDirectory() + k_SickPeopleFileSuffix);
            }

            using (Stream xmlStream = new FileStream(Directory.GetCurrentDirectory() + k_SickPeopleFileSuffix, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Covid19SickPeople));
                serializer.Serialize(xmlStream, this);
            }
        }

        public void AddConfirmedLocationTotheList(ConfirmedSickLocation i_confirmedSickLocation)
        {
            if (!ConfirmedSickLocations.Any(location => location == i_confirmedSickLocation))
            {
                ConfirmedSickLocations.Add(i_confirmedSickLocation);
            }
        }

        public bool CheckIfLocationIsInTheList(ConfirmedSickLocation i_Location)
        {
            foreach(ConfirmedSickLocation confirmedSickLocation in ConfirmedSickLocations)
            {
                if (confirmedSickLocation.Location.Equals(i_Location.Location))
                {
                    if (IsWithInTheRecoveryTime((DateTime)confirmedSickLocation.DateOfSickConfirmation))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool IsWithInTheRecoveryTime(DateTime i_TimeToCompare)
        {
            // need to turn to cosnt
            const double HowMuchHoursToWait = 24;
            double IsInfectionTimeIsOver = (DateTime.Now - i_TimeToCompare).TotalHours;

            return IsInfectionTimeIsOver > HowMuchHoursToWait;
        }
    }
}
