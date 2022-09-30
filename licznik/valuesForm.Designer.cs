
namespace licznik
{
    partial class valuesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sexCombo = new System.Windows.Forms.ComboBox();
            this.weightCombo = new System.Windows.Forms.ComboBox();
            this.ageCombo = new System.Windows.Forms.ComboBox();
            this.heightCombo = new System.Windows.Forms.ComboBox();
            this.sexLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.unitsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sexCombo
            // 
            this.sexCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexCombo.FormattingEnabled = true;
            this.sexCombo.Items.AddRange(new object[] {
            "Kobieta",
            "Mężczyzna"});
            this.sexCombo.Location = new System.Drawing.Point(65, 12);
            this.sexCombo.Name = "sexCombo";
            this.sexCombo.Size = new System.Drawing.Size(121, 23);
            this.sexCombo.TabIndex = 1;
            // 
            // weightCombo
            // 
            this.weightCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weightCombo.FormattingEnabled = true;
            this.weightCombo.Location = new System.Drawing.Point(290, 12);
            this.weightCombo.Name = "weightCombo";
            this.weightCombo.Size = new System.Drawing.Size(121, 23);
            this.weightCombo.TabIndex = 2;
            // 
            // ageCombo
            // 
            this.ageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ageCombo.FormattingEnabled = true;
            this.ageCombo.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.ageCombo.Location = new System.Drawing.Point(65, 80);
            this.ageCombo.Name = "ageCombo";
            this.ageCombo.Size = new System.Drawing.Size(121, 23);
            this.ageCombo.TabIndex = 3;
            // 
            // heightCombo
            // 
            this.heightCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.heightCombo.FormattingEnabled = true;
            this.heightCombo.Location = new System.Drawing.Point(290, 80);
            this.heightCombo.Name = "heightCombo";
            this.heightCombo.Size = new System.Drawing.Size(121, 23);
            this.heightCombo.TabIndex = 4;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(30, 20);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(29, 15);
            this.sexLabel.TabIndex = 6;
            this.sexLabel.Text = "Płeć";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(247, 20);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(37, 15);
            this.weightLabel.TabIndex = 7;
            this.weightLabel.Text = "Waga";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(26, 88);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(33, 15);
            this.ageLabel.TabIndex = 8;
            this.ageLabel.Text = "Wiek";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(241, 88);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(43, 15);
            this.heightLabel.TabIndex = 9;
            this.heightLabel.Text = "Wzrost";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(146, 126);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 11;
            this.calculateButton.Text = "Oblicz";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(227, 126);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Powrót";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(308, 126);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Zamknij";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 14;
            // 
            // unitsTextBox
            // 
            this.unitsTextBox.Location = new System.Drawing.Point(12, 41);
            this.unitsTextBox.Name = "unitsTextBox";
            this.unitsTextBox.Size = new System.Drawing.Size(100, 23);
            this.unitsTextBox.TabIndex = 15;
            this.unitsTextBox.Visible = false;
            // 
            // valuesForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 161);
            this.Controls.Add(this.unitsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.heightCombo);
            this.Controls.Add(this.ageCombo);
            this.Controls.Add(this.weightCombo);
            this.Controls.Add(this.sexCombo);
            this.Name = "valuesForm";
            this.Text = "Licznik";
            this.Load += new System.EventHandler(this.Licznik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox sexCombo;
        public System.Windows.Forms.ComboBox weightCombo;
        private System.Windows.Forms.ComboBox ageCombo;
        public System.Windows.Forms.ComboBox heightCombo;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox unitsTextBox;
    }
}

