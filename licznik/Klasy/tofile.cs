using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using licznik.Interfejsy;

namespace licznik
{
    public class tofile : itofile
    {
        private string name, surname, calories;
        public tofile(string name,string surname, string calories)
        {
            this.name = name;
            this.surname = surname;
            this.calories = calories;
        }
        public void write()
        {
            DateTime today = DateTime.Today;
            string finalString = today.ToString("d") + '\t' + this.name + '\t' + this.surname + '\t' + this.calories + '\t';
            using (StreamWriter sw = File.AppendText("wyniki.txt"))
            {
                sw.WriteLine(finalString);
            }
        }
    }
}
