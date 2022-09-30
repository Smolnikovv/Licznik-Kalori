using Microsoft.VisualStudio.TestTools.UnitTesting;
using licznik;

namespace licznikTestyJednostkowe2
{
    [TestClass]
    class resultTestyJednostkowe
    {
        [TestMethod]
        public void testKonstruktora()
        {
            string name = "Jan Kowalski";
            string calories = "200.20";

            result r = new result(name, calories);

            Assert.AreEqual("Jan", r.name);
            Assert.AreEqual("Kowalski", r.surname);
            Assert.AreEqual(calories, r.calories);
        }
        [TestMethod]
        public void testcheckName()
        {
            string name = "Jan Kowalski";
            string calories = "200.20";

            result r = new result(name, calories);
            bool res = r.checkName(name);

            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void testcheckName2()
        {
            string name = "JanKowalski";
            string calories = "200.20";

            result r = new result(name, calories);
            bool res = r.checkName(name);

            Assert.AreEqual(false, res);
        }
    }
}
