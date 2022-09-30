using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace licznik
{
    public partial class valuesForm : Form
    {
        public valuesForm()
        {
            InitializeComponent();
        }

        private void Licznik_Load(object sender, EventArgs e)
        {
            sexCombo.SelectedIndex = 0;
            ageCombo.SelectedIndex = 0;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            buttonsControll button = new buttonsControll();
            button.goBack();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            var mainActiveForm = valuesForm.ActiveForm;
            mainActiveForm.Hide();
            var name = new nameForm();
            name.FormClosed += (s, args) => mainActiveForm.Close();
            double height = double.Parse(heightCombo.Text, System.Globalization.CultureInfo.InvariantCulture);
            calculate calculate = new calculate(sexCombo.Text, Convert.ToDouble(ageCombo.Text), height, Convert.ToDouble(weightCombo.Text), this.unitsTextBox.Text);
            double result = calculate.cal();
            result=Math.Round(result, 2);
            MessageBox.Show("Dzienne zapotrzebowanie kaloryczne organizmu: \n" + result);
            name.value.Text = Convert.ToString(result);
            name.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        { 
            buttonsControll button = new buttonsControll();
            button.exit();
        }
    }
}
