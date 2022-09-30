using System;
using System.Collections.Generic;
using System.Text;
using licznik.Interfejsy;

namespace licznik
{
    public class calculate : icalculate
    {
        private string sex, units;
        private double age, height, weight;
        public calculate(string sex, double age, double height, double weight, string units)
        {
            this.sex = sex;
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.units = units;
        }
        public calculate(double weight, string units)
        {
            this.weight = weight;
            this.units = units;
        }
        public calculate(double height, string units, string a)
        {
            this.height = height;
            this.units = units;
        }
        public double cal()
        {
            double result = 0;
            height = this.changeUnitsHeight();
            weight = this.changeUnitsWeight();
            switch (sex)
            {
                case "Mężczyzna":
                    result = 66.5 + (13.75 * this.weight) + (5.003 * this.height) - (6.775 * this.age);
                    break;
                case "Kobieta":
                    result = 655.1 + (9.563 * this.weight) + (1.85 * this.height) - (4.676 * this.age);
                    break;
            }
            return result;
        }
        public double changeUnitsHeight()
        {
            if (this.units == "Funty/Stopy")
            {
                this.height *= 30.48;
            }
            return this.height;
        }
        public double changeUnitsWeight()
        {
            if (this.units == "Funty/Stopy")
            {
                this.weight *= 0.45359237;
            }
            return this.weight;
        }
    }
}
