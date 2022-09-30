using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace licznik
{
    public partial class nameForm : Form
    {
        public nameForm()
        {
            InitializeComponent();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            result res = new result(nameTextBox.Text, value.Text);
            tofile write = new tofile(res.getName(), res.getSurname(), res.getCalories());
            write.write();
            buttonsControll button = new buttonsControll();
            button.exit();
        }

      
    }
}
