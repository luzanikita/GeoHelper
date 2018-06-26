using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GeoHelper
{
    // Форма зміни даних довідника.
    public partial class EditForm : Form
    {
        // Посилання на головну форму.
        private MainForm Main { get; set; }

        public EditForm(MainForm main)
        {
            InitializeComponent();
            Main = main;
        }

        // Додавання джерел даних до елементів форми.
        private void EditForm_Load(object sender, EventArgs e)
        {
            comboBoxCityContinent.DataSource = Main.Helper.ContinentList;
            comboBoxContinent.DataSource = Main.Helper.ContinentList;
            comboBoxCountryContinent.DataSource = Main.Helper.ContinentList;
            UpdateCountryInfo();
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

        // Додавання джерел даних країн.
        private void UpdateCountryInfo()
        {
            if (Main.Helper.ContinentList.Count > 0)
            {
                comboBoxCountry.DataSource = new List<Country> { };
                if (comboBoxCountryContinent.SelectedIndex >= 0 &&
                    Main.Helper
                        .ContinentList[comboBoxCountryContinent.SelectedIndex]
                        .CountryList.Count > 0)
                    comboBoxCountry.DataSource = Main.Helper
                        .ContinentList[comboBoxCountryContinent.SelectedIndex]
                        .CountryList;
                else
                    comboBoxCountry.Text = "";


                comboBoxCityCountry.DataSource = new List<Country> { };
                if (comboBoxCityContinent.SelectedIndex >= 0 &&
                    Main.Helper
                        .ContinentList[comboBoxCityContinent.SelectedIndex]
                        .CountryList.Count > 0)
                    comboBoxCityCountry.DataSource = Main.Helper
                        .ContinentList[comboBoxCityContinent.SelectedIndex]
                        .CountryList;
                else
                    comboBoxCityCountry.Text = "";

                UpdateCityInfo();
            }
            else
            {
                comboBoxCountry.DataSource = new List<Country> { };
                comboBoxCountry.Text = "";

                comboBoxCityCountry.DataSource = new List<Country> { };
                comboBoxCityCountry.Text = "";

                comboBoxCity.DataSource = new List<City> { };
                comboBoxCity.Text = "";
            }
        }

        // Додавання джерел даних міст.
        private void UpdateCityInfo()
        {
            if (comboBoxCityCountry.SelectedIndex >= 0 &&
                Main.Helper
                    .ContinentList[comboBoxCityContinent.SelectedIndex]
                    .CountryList[comboBoxCityCountry.SelectedIndex]
                    .CityList.Count > 0)
            {
                comboBoxCity.DataSource = new List<City> { };
                comboBoxCity.DataSource = Main.Helper
                    .ContinentList[comboBoxCityContinent.SelectedIndex]
                    .CountryList[comboBoxCityCountry.SelectedIndex]
                    .CityList;
            }
            else
            {
                comboBoxCity.DataSource = new List<City> { };
                comboBoxCity.Text = "";
            }
        }

        // Відображення панелі зміни континентів.
        private void radioButtonContinent_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCountry.Visible = false;
            groupBoxCity.Visible = false;
            groupBoxContinent.Visible = true;
        }

        // Відображення панелі зміни країн.
        private void radioButtonCountry_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCity.Visible = false;
            groupBoxCountry.Visible = true;
            groupBoxContinent.Visible = false;
        }

        // Відображення панелі зміни міст.
        private void radioButtonCity_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCity.Visible = true;
            groupBoxCountry.Visible = false;
            groupBoxContinent.Visible = false;
        }

        // Обробка та зміна обраних даних довідника.
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonContinent.Checked &&
                Validator.ValidComboBox<Continent>(comboBoxContinent) &&
                Validator.ValidName(textBoxContinentName))
            {
                Main.Helper.ContinentList[comboBoxContinent.SelectedIndex]
                    .Edit(textBoxContinentName.Text);
                Main.Helper.Update();
                Main.UpdateInfo();
                Close();
            }
            else if (radioButtonCountry.Checked &&
                Validator.ValidComboBox<Continent>(comboBoxCountryContinent) &&
                Validator.ValidComboBox<Country>(comboBoxCountry) &&
                Validator.ValidName(textBoxCountryName) &&
                Validator.ValidComboBox<string>(comboBoxGovForm))
            {
                Main.Helper.ContinentList[comboBoxCountryContinent.SelectedIndex]
                    .CountryList[comboBoxCountry.SelectedIndex]
                    .Edit(textBoxCountryName.Text, comboBoxGovForm.Text);
                Main.Helper.Update();
                Main.UpdateInfo();
                Close();
            }
            else if (radioButtonCity.Checked &&
                Validator.ValidComboBox<Continent>(comboBoxCityContinent) &&
                Validator.ValidComboBox<Country>(comboBoxCityCountry) &&
                Validator.ValidComboBox<City>(comboBoxCity) &&
                Validator.ValidName(textBoxCityName) &&
                Validator.ValidCoordTextBox(textBoxLongitude) &&
                Validator.ValidCoordTextBox(textBoxLatitude) &&
                Validator.ValidDoubleField(textBoxCityArea) &&
                Validator.ValidIntField(textBoxCityPopulation))
            {
                double longitude = textBoxLongitude.Text == "" ? 404 : Convert.ToDouble(textBoxLongitude.Text);
                double latitude = textBoxLatitude.Text == "" ? 404 : Convert.ToDouble(textBoxLatitude.Text);
                double area = textBoxCityArea.Text == "" ? -1 : Convert.ToDouble(textBoxCityArea.Text);
                int population = textBoxCityPopulation.Text == "" ? -1 : Convert.ToInt32(textBoxCityPopulation.Text);

                Main.Helper.ContinentList[comboBoxCityContinent.SelectedIndex]
                    .CountryList[comboBoxCityCountry.SelectedIndex]
                    .Capital
                    .Edit("",
                        new double[] { 404, 404 },
                        -1,
                        -1,
                        !checkBoxIsCapital.Checked);

                Main.Helper.ContinentList[comboBoxCityContinent.SelectedIndex]
                    .CountryList[comboBoxCityCountry.SelectedIndex]
                    .CityList[comboBoxCity.SelectedIndex]
                    .Edit(textBoxCityName.Text,
                        new double[] { longitude, latitude},
                        area,
                        population,
                        checkBoxIsCapital.Checked);

                Main.Helper.Update();
                Main.UpdateInfo();
                Close();
            }
        }

        // Закрити форму.
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Зміна списків країн та міст, при виборі відповідного континента на панелі зміни міст.
        private void comboBoxCityContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCountryInfo();
        }

        // Зміна списку міст, при виборі відповідної країни на панелі зміни міст.
        private void comboBoxCityCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCityInfo();
        }

        // Зміна списку країн, при виборі відповідного континента на панелі зміни країн.
        private void comboBoxCountryContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCountryInfo();
        }
    }
}
