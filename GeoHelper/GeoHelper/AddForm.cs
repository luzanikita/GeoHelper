using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GeoHelper
{
    // Форма добавления новых элементов в справочник.
    public partial class AddForm : Form
    {
        // Ссылка на главну форму.
        private MainForm Main { get; set; }
        public AddForm(MainForm main)
        {
            InitializeComponent();
            Main = main;
        }

        // Привязка источников данных к элементам формы.
        private void AddForm_Load(object sender, EventArgs e)
        {
            comboBoxCityContinent.DataSource = Main.Helper.ContinentList;
            comboBoxContinent.DataSource = Main.Helper.ContinentList;
            comboBoxCountry.DataSource = comboBoxCityContinent.SelectedIndex >= 0 ?
                Main.Helper.ContinentList[comboBoxCityContinent.SelectedIndex].CountryList : new List<Country> { };
            List<string> governmentForms = new List<string> { };
            using (StreamReader fs = new StreamReader($"..\\..\\Data\\GovernmentForm.txt"))
            {
                while (true)
                {
                    string str = fs.ReadLine();
                    if (str == null) break;
                    governmentForms.Add(str);
                }
            }
            comboBoxGovForm.DataSource = governmentForms;
        }

        // Отображения панели добавления города.
        private void radioButtonCity_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCountry.Visible = false;
            groupBoxCity.Visible = true;
            groupBoxContinent.Visible = false;
        }

        // Отображения панели добавления страны.
        private void radioButtonCountry_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCity.Visible = false;
            groupBoxCountry.Visible = true;
            groupBoxContinent.Visible = false;
        }

        // Отображения панели добавления континента. 
        private void radioButtonContinent_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCity.Visible = false;
            groupBoxCountry.Visible = false;
            groupBoxContinent.Visible = true;
        }

        // Обработка и добавление в справочник введенных данных.
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonContinent.Checked &&
                Validator.ValidName(textBoxContinentName, true))
            {
                Main.Helper.Add(textBoxContinentName.Text);
                Main.Helper.Update();
                Main.UpdateInfo();
                Close();
            }
            else if (radioButtonCountry.Checked &&
                Validator.ValidComboBox<Continent>(comboBoxContinent) &&
                Validator.ValidName(textBoxCountryName, true) &&
                Validator.ValidComboBox<string>(comboBoxGovForm))
            {
                Main.Helper.ContinentList[comboBoxContinent.SelectedIndex]
                    .Add(textBoxCountryName.Text, comboBoxGovForm.Text);
                Main.Helper.Update();
                Main.UpdateInfo();
                Close();
            }
            else if(radioButtonCity.Checked &&
                Validator.ValidComboBox<Continent>(comboBoxCityContinent) &&
                Validator.ValidComboBox<Country>(comboBoxCountry) &&
                Validator.ValidName(textBoxCityName, true) &&
                Validator.ValidDoubleField(textBoxCityArea, true) &&
                Validator.ValidIntField(textBoxCityPopulation, true) &&
                Validator.ValidCoordTextBox(textBoxLongitude, true) &&
                Validator.ValidCoordTextBox(textBoxLatitude, true)
                )
            {
                Main.Helper.ContinentList[comboBoxCityContinent.SelectedIndex]
                    .CountryList[comboBoxCountry.SelectedIndex]
                    .Add(textBoxCityName.Text,
                        new double[] { Convert.ToDouble(textBoxLongitude.Text),
                            Convert.ToDouble(textBoxLatitude.Text) },
                        Convert.ToDouble(textBoxCityArea.Text),
                        Convert.ToInt32(textBoxCityPopulation.Text),
                        checkBoxIsCapital.Checked);
                Main.Helper.Update();
                Main.UpdateInfo();
                Close();
            }
        }

        // Изменение отображения стран, при выборе соответствующего континента.
        private void comboBoxCityContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCountry.DataSource = Main.Helper.ContinentList[comboBoxCityContinent.SelectedIndex].CountryList;
            if(Main.Helper.ContinentList[comboBoxCityContinent.SelectedIndex].CountryList.Count == 0)
                comboBoxCountry.Text = "";
        }

        // Закрыть форму.
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
