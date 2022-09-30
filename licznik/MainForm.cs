using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace licznik
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            unitsCombo.SelectedIndex = 0;
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            var mainActiveForm = MainForm.ActiveForm;
            mainActiveForm.Hide();
            var form = new valuesForm();
            form.FormClosed += (s, args) => mainActiveForm.Close();
            fillCombo jednostki = new fillCombo(unitsCombo.Text);
            string[] heightArray = jednostki.fillHeight();
            string[] weightArray = jednostki.fillWeight();
            foreach (var line in heightArray)
            {
                string[] tokens = line.Split(',');
                form.heightCombo.Items.Add(tokens[0]);
            }
            foreach (var line in weightArray)
            {
                string[] tokens = line.Split(',');
                form.weightCombo.Items.Add(tokens[0]);
            }
            form.Show();
            form.unitsTextBox.Text = jednostki.get();
            form.heightCombo.SelectedIndex = 0;
            form.weightCombo.SelectedIndex = 0;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            buttonsControll button = new buttonsControll();
            button.exit();
        }

    }
}
