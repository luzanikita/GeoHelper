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
    // Форма удаления элементов из формы.
    public partial class DeleteForm : Form
    {
        // Ссылка на главную форму.
        private MainForm Main { get; set; }
        public DeleteForm(MainForm main)
        {
            InitializeComponent();
            Main = main;
        }

        // Привязка источников данных к элементам формы.
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

        // Привязка данных о странах.
        private void UpdateCountryInfo()
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

        // Привязка данных о городах.
        private void UpdateCityInfo()
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

        // Изменение списка стран, при выборе соответствующего континента.
        private void comboBoxContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCountryInfo();
        }

        // Изменение списка городов, при выборе соответсвующей страны.
        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCityInfo();
        }

        // Обработка и удаление введенных данных из справочника.
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonContinent.Checked)
                {
                
                        Main.Helper.Remove(Main.Helper.ContinentList[comboBoxContinent.SelectedIndex]);
                        Main.Helper.Update();
                        Main.UpdateInfo();
                        Close();
                }
                else if(radioButtonCountry.Checked)
                {
                    Main.Helper.ContinentList[comboBoxContinent.SelectedIndex].Remove(Main.Helper
                        .ContinentList[comboBoxContinent.SelectedIndex]
                        .CountryList[comboBoxCountry.SelectedIndex]);
                    Main.Helper.Update();
                    Main.UpdateInfo();
                    Close();
                }
                else if (radioButtonCity.Checked)
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
            catch (Exception)
            {
                MessageBox.Show("Введенного элемента не существет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
