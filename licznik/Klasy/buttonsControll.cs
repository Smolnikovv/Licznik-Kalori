using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using licznik.Interfejsy;

namespace licznik
{
    public class buttonsControll : ibuttonsControll
    {
        public void exit()
        {
            Application.Exit();
        }
        public void goBack()
        {
            var activeForm = valuesForm.ActiveForm;
            activeForm.Hide();
            MainForm newForm = new MainForm();
            newForm.Show();
        }
    }
}
