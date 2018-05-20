using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoHelper
{
    // Форма изменения данных справочника.
    public partial class EditForm : Form
    {
        // Ссылка на главную форму.
        private MainForm Main { get; set; }

        public EditForm(MainForm main)
        {
            InitializeComponent();
            Main = main;
        }

        // Привязка источников данных к элементам формы.
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

        // Привязка данных о странах.
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

        // Привязка данных о городах.
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

        // Отображение панели изменения континентов.
        private void radioButtonContinent_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCountry.Visible = false;
            groupBoxCity.Visible = false;
            groupBoxContinent.Visible = true;
        }

        // Отображение панели изменения стран.
        private void radioButtonCountry_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCity.Visible = false;
            groupBoxCountry.Visible = true;
            groupBoxContinent.Visible = false;
        }

        // Отображения панели изменения городов.
        private void radioButtonCity_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCity.Visible = true;
            groupBoxCountry.Visible = false;
            groupBoxContinent.Visible = false;
        }

        // Обработка и изменение введенных данных справочника.
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonContinent.Checked)
                {
                    Main.Helper.ContinentList[comboBoxCityContinent.SelectedIndex]
                        .Edit(textBoxContinentName.Text);

                }
                else if (radioButtonCountry.Checked)
                {
                    Main.Helper.ContinentList[comboBoxCountryContinent.SelectedIndex]
                        .CountryList[comboBoxCountry.SelectedIndex]
                        .Edit(textBoxCountryName.Text, comboBoxGovForm.Text);
                }
                else
                {

                    Main.Helper.ContinentList[comboBoxCityContinent.SelectedIndex]
                        .CountryList[comboBoxCityCountry.SelectedIndex]
                        .CityList[comboBoxCity.SelectedIndex]
                        .Edit(textBoxCityName.Text,
                            new double[] { Convert.ToDouble(textBoxLongitude.Text), Convert.ToDouble(textBoxLatitude.Text) },
                            Convert.ToDouble(textBoxCityArea.Text),
                            Convert.ToInt32(textBoxCityArea.Text),
                            checkBoxIsCapital.Checked);
                }
                Main.Helper.Update();
                Main.UpdateInfo();
                Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Не корректно заполнены поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Закрыть форму.
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Изменение списка стран, при выборе соответствующего континента на панели изменения городов.
        private void comboBoxCityContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCountryInfo();
        }

        // Изменение списка городов, при выборе соответствующей страны на панели изменения городов.
        private void comboBoxCityCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCityInfo();
        }

        // Изменение списка стран, при выборе соответствующего континента на панели изменения стран.
        private void comboBoxCountryContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCountryInfo();
        }
    }
}
