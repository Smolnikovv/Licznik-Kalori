using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using licznik.Interfejsy;

namespace licznik
{
    public class result : iresult
    {
        private string name, surname, calories;
        public result(string name, string calories)
        {
            if (checkName(name))
            {
                string[] split = name.Split(' ');
                this.name = split[0];
                this.surname = split[1];
                this.calories = calories;
            }
            else
            {
                buttonsControll button = new buttonsControll();
                button.exit();
            }
        }
        public bool checkName(string name)
        {
            if (name==null || !(name.Contains(' ')))
            {
                MessageBox.Show("Błędne dane. Program zakończy działanie");
                return false;
            }
            else
            {
                return true;
            }
        }
        public string getName()
        {
            return this.name;
        }
        public string getSurname()
        {
            return this.surname;
        }
        public string getCalories()
        {
            return this.calories;
        }
    }
}
