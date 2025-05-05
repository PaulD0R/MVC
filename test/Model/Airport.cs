using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using lab7;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace lab7
{
    public class Airport
    {
        public string CheckName { get; set; }
        public string Name { get; set; }
        public int? CountFlight { get; set; }
        public int? CountTicket { get; set; }
        public int? Area { get; set; }
        public bool? IsOpen { get; set; }
        public string City { get; set; }
        public short? YearOfConstruction { get; set; }


        public Airport()
        {
            Name = string.Empty;
            CountFlight = 0;
            CountTicket = 0;
            Area = 0;
            IsOpen = false;
            City = string.Empty;
            YearOfConstruction = 1900;
            CheckName = string.Empty;
        }

        public Airport(string name, int countFlight, int countTicket, int area, bool isOpen, string city, short yearOfConsuption)
        {
            Name = name;
            CountFlight = countFlight;
            CountTicket = countTicket;
            Area = area;
            IsOpen = isOpen;
            City = city;
            YearOfConstruction = yearOfConsuption;
            CheckName = name;
        }

        public Airport(string name)
        {
            Name = name;
            CountFlight = 0;
            CountTicket = 0;
            Area = 0;
            IsOpen = false;
            City = name;
            YearOfConstruction = 1900;
            CheckName = name;
        }

        public Airport(string name, string city)
        {
            Name = name;
            CountFlight = 0;
            CountTicket = 0;
            Area = 0;
            IsOpen = false;
            City = city;
            YearOfConstruction = 1900;
            CheckName = name;
        }
    }
}