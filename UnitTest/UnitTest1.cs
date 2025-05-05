using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab1;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public sealed class MyTests
    {
        [TestMethod]
        public void TestAddAirportToAirportList()
        {
            var airport = new Airport("Лондон", 0, 0, 0, false, "Лондон", 1900);
            var airportList = new TransportCenter();
            
            airportList.Add(airport);

            Assert.AreEqual(1, airportList.Length);

            CollectionAssert.Contains(airportList.Hubs, airport);
        }
        /*
        [TestMethod]
        public void TestRemoveAirportToAirportList()
        {
            var airport = new Airport("Лондон", 0, 0, 0, false, "Лондон", 1900);
            var airportList = new TransportCenter(new List<Hub> { airport, new Airport("Москва", 0, 0, 0, false, "Москва", 1900)});

            airportList.Remove("Лондон");

            Assert.AreEqual(1, airportList.Length);
            CollectionAssert.DoesNotContain(airportList.Hubs, airport);
        }

        [TestMethod]
        public void TestBuyTicket()
        {
            var airport1 = new Airport("Лондон", 0, 0, 0, false, "Лондон", 1900);
            var airport2 = new Airport("Москва", 0, 0, 0, false, "Москва", 1900);
            var ticket = airport1.BuyTicket(airport2);

            Assert.AreEqual(airport2, ticket.To);
            Assert.AreEqual(airport1, ticket.From);
        }
        */
    }
}
