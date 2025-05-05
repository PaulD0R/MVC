using lab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Controller
{
    internal class AirportController
    {
        private readonly AirportList _airportList;
        private readonly Form1 _form1;
        private readonly Form2 _form2;

        public AirportController(AirportList airportList, Form1 form1, Form2 form2)
        {
            _airportList = airportList;
            _form1 = form1;
            _form2 = form2;

            _form1.AirportAdded += 
        }

        private void AddAirport(Airport airport)
        {

        }


    }
}
