using System;
using System.Collections.Generic;
using lab5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddAirportToAirportList()
        {
            var airport = new Airport("Лондон", 0, 0, 0, false, "Лондон", 1900);
            var airportList = new AirportList();

            airportList.Add(airport);

            Assert.AreEqual(1, airportList.Length);

            CollectionAssert.Contains(airportList.Hubs, airport);
        }

        [TestMethod]
        public void TestRemoveAirportToAirportList()
        {
            var airport = new Airport("Лондон", 0, 0, 0, false, "Лондон", 1900);
            var airportList = new AirportList(new List<Airport> { airport, new Airport("Москва", 0, 0, 0, false, "Москва", 1900) });

            airportList.Remove("Лондон");

            Assert.AreEqual(1, airportList.Length);
            CollectionAssert.DoesNotContain(airportList.Hubs, airport);
        }
    }
}
