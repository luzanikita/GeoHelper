using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoHelper
{
    // Форма видалення елементів довідника.
    public partial class DeleteForm : Form
    {
        // Посилання на головну форму.
        private MainForm Main { get; set; }
        public DeleteForm(MainForm main)
        {
            InitializeComponent();
            Main = main;
        }

        // Додавання джерел даних до елементів форми.
        private void DeleteForm_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxContinent.DataSource = Main.Helper.ContinentList;
                UpdateCountryInfo();
                UpdateCityInfo();
            }
            catch(Exception)
            {

            }
        }

        // Додавання джерел даних країн.
        private void UpdateCountryInfo()
        {
            if (radioButtonCountry.Checked || radioButtonCity.Checked)
            {
                if (Main.Helper
                        .ContinentList.Count > 0 &&
                    Main.Helper
                        .ContinentList[comboBoxContinent.SelectedIndex]
                        .CountryList.Count > 0)
                {
                    comboBoxCountry.DataSource = new List<Country> { };
                    comboBoxCountry.DataSource = Main.Helper
                        .ContinentList[comboBoxContinent.SelectedIndex]
                        .CountryList;
                    UpdateCityInfo();
                }
                else
                {
                    comboBoxCountry.DataSource = new List<Country> { };
                    comboBoxCountry.Text = "";
                    comboBoxCity.DataSource = new List<City> { };
                    comboBoxCity.Text = "";
                }
            }
        }

        // Додавання джерел даних міст.
        private void UpdateCityInfo()
        {
            if (radioButtonCity.Checked)
            {
                if (Main.Helper
                        .ContinentList[comboBoxContinent.SelectedIndex]
                        .CountryList[comboBoxCountry.SelectedIndex]
                        .CityList.Count > 0)
                {
                    comboBoxCity.DataSource = new List<City> { };
                    comboBoxCity.DataSource = Main.Helper
                        .ContinentList[comboBoxContinent.SelectedIndex]
                        .CountryList[comboBoxCountry.SelectedIndex]
                        .CityList;
                }
                else
                {
                    comboBoxCity.DataSource = new List<City> { };
                    comboBoxCity.Text = "";
                }
            }
        }

        // Зміна списку країн та міст, при виборі відповідного континента.
        private void comboBoxContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCountryInfo();
        }

        // Зміна списку міст, при виборі відповідної країни.
        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCityInfo();
        }

        // Обробка та видалення обраних даних довідника.
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonContinent.Checked && Validator.ValidComboBox<Continent>(comboBoxContinent))
                {
                    Main.Helper.Remove(Main.Helper.ContinentList[comboBoxContinent.SelectedIndex]);
                    Main.Helper.Update();
                    Main.UpdateInfo();
                    Close();
                }
                else if (radioButtonCountry.Checked &&
                    Validator.ValidComboBox<Continent>(comboBoxContinent) &&
                    Validator.ValidComboBox<Country>(comboBoxCountry))
                {
                    Main.Helper.ContinentList[comboBoxContinent.SelectedIndex].Remove(Main.Helper
                        .ContinentList[comboBoxContinent.SelectedIndex]
                        .CountryList[comboBoxCountry.SelectedIndex]);
                    Main.Helper.Update();
                    Main.UpdateInfo();
                    Close();
                }
                else if (radioButtonCity.Checked &&
                    Validator.ValidComboBox<Continent>(comboBoxContinent) &&
                    Validator.ValidComboBox<Country>(comboBoxCountry) &&
                    Validator.ValidComboBox<City>(comboBoxCity))
                {
                    Main.Helper
                        .ContinentList[comboBoxContinent.SelectedIndex]
                        .CountryList[comboBoxCountry.SelectedIndex]
                        .CityList.Remove(Main.Helper
                            .ContinentList[comboBoxContinent.SelectedIndex]
                            .CountryList[comboBoxCountry.SelectedIndex]
                            .CityList[comboBoxCity.SelectedIndex]);
                    Main.Helper.Update();
                    Main.UpdateInfo();
                    Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Переконайтесь, що всі поля заповнені правильно.\nУ списках повинні бути вказані тільки існуючі елементи.",
               "Неправильно заполнены поля",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
            }
        }

        // Відображення відповідних полів для видалення країни.
        private void radioButtonCountry_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxCity.Visible = false;
            comboBoxCountry.Visible = true;
            labelCity.Visible = false;
            labelCountry.Visible = true;
        }

        // Відображення відповідних полів для видалення міста.
        private void radioButtonCity_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxCity.Visible = true;
            comboBoxCountry.Visible = true;
            labelCity.Visible = true;
            labelCountry.Visible = true;
        }

        // Відображення відповідних полів для видалення континента.
        private void radioButtonContinent_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxCity.Visible = false;
            comboBoxCountry.Visible = false;
            labelCity.Visible = false;
            labelCountry.Visible = false;
        }
    }
}
