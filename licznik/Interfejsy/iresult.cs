using System;
using System.Collections.Generic;
using System.Text;

namespace licznik.Interfejsy
{
    interface iresult
    {
        bool checkName(string name);
        string getName();
        string getSurname();
        string getCalories();
    }
}
