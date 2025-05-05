using lab1;

namespace UnitTests
{
    [TestClass]
    public sealed class MyTests
    {
        [TestMethod]
        public void TestAddAirportToAirportList()
        {
            var airport = new Airport("Лондон");
            var airportList = new AirportList();

            airportList.Add(airport);

            Assert.AreEqual(1, airportList.Length);

            CollectionAssert.Contains(airportList.Airports, airport);
        }

        [TestMethod]
        public void TestRemoveAirportToAirportList()
        {
            var airport = new Airport("Лондон");
            var airportList = new AirportList([airport, new Airport("Москва")]);

            airportList.Remove("Лондон");

            Assert.AreEqual(1, airportList.Length);
            CollectionAssert.DoesNotContain(airportList.Airports, airport);
        }
    }
}
