using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using licznik.Interfejsy;

namespace licznik
{
    public class fillCombo : ifillcombo
    {
        private string jednostki;
        public fillCombo(string jednostki)
        {
            this.jednostki = jednostki;
        }
        public string[] fillHeight()
        {
            string[] lineOfContents = new string[] { };
            switch (this.jednostki)
            {
                case "Kilogramy/Centymetry":
                    lineOfContents = File.ReadAllLines("cm.txt");
                    break;
                case "Funty/Stopy":
                    lineOfContents = File.ReadAllLines("ft.txt");
                    break;
            }
            return lineOfContents;
        }
        public string[] fillWeight()
        {
            string[] lineOfContents = new string[] { };
            switch (this.jednostki)
            {
                case "Kilogramy/Centymetry":
                    lineOfContents = File.ReadAllLines("kg.txt");
                    break;
                case "Funty/Stopy":
                    lineOfContents = File.ReadAllLines("lbs.txt");
                    break;
            }
            return lineOfContents;
        }
        public string get()
        {
            return this.jednostki;
        }

    }
}
