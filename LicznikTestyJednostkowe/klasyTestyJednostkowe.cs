using Microsoft.VisualStudio.TestTools.UnitTesting;
using licznik;

namespace LicznikTestyJednostkowe
{
    [TestClass]
    public class klasyTestyJednostkowe
    {
        [TestMethod]
        public void testKonstruktora()
        {
            string name = "Jan Kowalski";
            string calories = "200.20";

            result r = new result(name, calories);
            PrivateObject po = new PrivateObject(r);
            string s_name = (string)po.GetField("name");
            string s_surname = (string)po.GetField("surname");
            string s_calories = (string)po.GetField("calories");

            Assert.AreEqual("Jan", s_name);
            Assert.AreEqual("Kowalski", s_surname);
            Assert.AreEqual(calories, s_calories);
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
        public void TestMetodycal()
        {
            string sex = "Mężczyzna", units = "Kilogramy/Centymetry";
            double age = 20, height = 150, weight = 80;

            calculate calcul = new calculate(sex, age, height, weight, units);
            double result = calcul.cal();

            Assert.AreEqual(1781.45, result);
        }
        [TestMethod]
        public void TestMetodychangeUnitsHeight()
        {
            double height = 5.6;
            string units = "Funty/Stopy";
            calculate cal = new calculate(height, units, "a");

            double result = cal.changeUnitsHeight();

            Assert.AreEqual(170.688, result);
        }
        [TestMethod]
        public void TestMetodychangeUnitsWeight()
        {
            double weight = 200;
            string units = "Funty/Stopy";
            calculate cal = new calculate(weight, units);

            double result = cal.changeUnitsWeight();

            Assert.AreEqual(90.718474, result);
        }
        [TestMethod]
        public void testKonstruktora1cal()
        {
            string sex = "sex", units = "units";
            double age = 5.2, height = 12.3, weight = 15.5;

            calculate c = new calculate(sex, age, height, weight, units);

            PrivateObject po = new PrivateObject(c);

            string s_sex = (string)po.GetField("sex");
            string s_units = (string)po.GetField("units");
            double s_age = (double)po.GetField("age");
            double s_height = (double)po.GetField("height");
            double s_weight = (double)po.GetField("weight");

            Assert.AreEqual(sex, s_sex, "Błąd w zmiennej sex");
            Assert.AreEqual(age, s_age, "Błąd w zmiennej age");
            Assert.AreEqual(height, s_height, "Bład w zmiennej height");
            Assert.AreEqual(weight, s_weight, "Bład w zmiennej weight");
            Assert.AreEqual(units, s_units, "Bład w zmiennej weight");

        }
        [TestMethod]
        public void testKonstruktora2cal()
        {
            string units = "units";
            double weight = 15.5;

            calculate c = new calculate(weight, units);

            PrivateObject po = new PrivateObject(c);

            string s_units = (string)po.GetField("units");
            double s_weight = (double)po.GetField("weight");

            Assert.AreEqual(weight, s_weight, "Bład w zmiennej weight");
            Assert.AreEqual(units, s_units, "Bład w zmiennej weight");

        }
        [TestMethod]
        public void testKonstruktora3cal()
        {
            string units = "units";
            double height = 15.5;

            calculate c = new calculate(height, units, "a");

            PrivateObject po = new PrivateObject(c);

            string s_units = (string)po.GetField("units");
            double s_height = (double)po.GetField("height");

            Assert.AreEqual(height, s_height, "Bład w zmiennej weight");
            Assert.AreEqual(units, s_units, "Bład w zmiennej weight");

        }
    }
    

}

