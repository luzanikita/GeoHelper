using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeoHelper
{
    public partial class SearchForm : Form
    {
        // Посилання на головну форму.
        private MainForm Main { get; set; }
        public SearchForm(MainForm main)
        {
            InitializeComponent();
            Main = main;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            Main.Helper.ContinentList.Sort((emp1, emp2) => emp1.Name.CompareTo(emp2.Name));
            listBoxSearch.DataSource = Main.Helper.ContinentList;
        }

        // Пошук континентів, що задовільнюють запит.
        private List<Continent> SearchContinet(string name)
        {
            List<Continent> result = new List<Continent>();
            foreach(var continent in Main.Helper.ContinentList)
            {
                if(continent.ToString().Contains(name))
                    result.Add(continent);
            }

            result.Sort((emp1, emp2) => emp1.Name.CompareTo(emp2.Name));
            return result;
        }

        // Пошук країн, що задовільнюють запит.
        private List<Country> SearchCountry(string name)
        {
            List<Country> result = new List<Country>();
            foreach (var continent in Main.Helper.ContinentList)
            {
                foreach (var country in continent.CountryList)
                if (country.ToString().Contains(name))
                    result.Add(country);
            }

            result.Sort((emp1, emp2) => emp1.Name.CompareTo(emp2.Name));
            return result;
        }

        // Пошук міст, що задовільнюють запит.
        private List<City> SearchCity(string name)
        {
            List<City> result = new List<City>();
            foreach (var continent in Main.Helper.ContinentList)
            {
                foreach(var country in continent.CountryList)
                {
                    foreach(var city in country.CityList)
                    {
                        if (city.ToString().Contains(name))
                            result.Add(city);
                    }
                }
            }

            result.Sort((emp1, emp2) => emp1.Name.CompareTo(emp2.Name));
            return result;
        }

        // Вивід результатів пошуку.
        private void ShowResults(string name)
        {
            if (radioButtonCity.Checked)
                listBoxSearch.DataSource = SearchCity(name);
            else if(radioButtonCountry.Checked)
                listBoxSearch.DataSource = SearchCountry(name);
            else
                listBoxSearch.DataSource = SearchContinet(name);
        }

        // Оновлення інформації
        private void UpdateInfo()
        {
            if (radioButtonCity.Checked)
            {
                if (listBoxSearch.Items.Count > 0)
                    UpdateCityInfo((City)(listBoxSearch.Items[listBoxSearch.SelectedIndex]));
                else
                    UpdateCityInfo(null);
            }
            else if (radioButtonCountry.Checked)
            {
                if (listBoxSearch.Items.Count > 0)
                    UpdateCountryInfo((Country)(listBoxSearch.Items[listBoxSearch.SelectedIndex]));
                else
                    UpdateCountryInfo(null);
            }
            else
            {
                if (listBoxSearch.Items.Count > 0)
                    UpdateContinentInfo((Continent)(listBoxSearch.Items[listBoxSearch.SelectedIndex]));
                else
                    UpdateContinentInfo(null);
            }
        }

        // Оноволення інформації про континенти.
        public void UpdateContinentInfo(Continent continent)
        {
            if (continent == null)
            {
                continentArea.Text = "-";
                continentArea.Text = "-";
                continentPopulation.Text = "-";
            }
            else
            {
                continentName.Text = continent.Name;
                continentArea.Text = $"{continent.Area} км²";
                continentPopulation.Text = $"{continent.Population} ос.";
            }
        }

        // Оноволення інформації про країни.
        public void UpdateCountryInfo(Country country)
        {
            if (country == null)
            {
                countryName.Text = "-";
                countryCapital.Text = "-";
                countryArea.Text = "-";
                countryPopulation.Text = "-";
                countryGovernment.Text = "-";
            }
            else
            {
                countryName.Text = $"{country.Name} ({country.Parent})";
                countryCapital.Text = country.Capital.Name;
                countryArea.Text = $"{country.Area} км²";
                countryPopulation.Text = $"{country.Population} ос.";
                countryGovernment.Text = country.Government;
            }
        }

        // Оноволення інформації про міста.
        public void UpdateCityInfo(City city)
        {
            if (city != null)
            {
                cityName.Text = $"{city.Name} ({city.Parent})";
                string longitude = city.Coordinates[0] > 0 ? "з.д." : "с.д.";
                string latitude = city.Coordinates[1] > 0 ? "пн.ш." : "пд.ш.";
                cityCoordinates.Text =
                    $"{Math.Abs(city.Coordinates[0])}° {longitude} " +
                    $"{Math.Abs(city.Coordinates[1])}° {latitude} ";
                cityArea.Text = $"{city.Area} км²";
                cityPopulation.Text = $"{city.Population} ос.";
                cityIsCapital.Text = city.IsCapital ? "Так" : "Ні";
            }
            else
            {
                cityName.Text = "-";
                cityCoordinates.Text = "-";
                cityArea.Text = "-";
                cityPopulation.Text = "-";
                cityIsCapital.Text = "-";
            }
        }

        // Оновлення пошуку при зміні тексту у полі вводу.
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ShowResults(textBoxSearch.Text);
            UpdateInfo();
        }

        // Оновлення пошуку при зміні параметрів пошуку континента.
        private void radioButtonContinent_CheckedChanged(object sender, EventArgs e)
        {
            ShowResults(textBoxSearch.Text);
            UpdateInfo();

            groupBoxCountryInfo.Visible = false;
            groupBoxCityInfo.Visible = false;
            groupBoxContinentInfo.Visible = true;
        }

        // Оновлення пошуку при зміні параметрів пошуку країни.
        private void radioButtonCountry_CheckedChanged(object sender, EventArgs e)
        {
            ShowResults(textBoxSearch.Text);
            UpdateInfo();

            groupBoxCountryInfo.Visible = true;
            groupBoxCityInfo.Visible = false;
            groupBoxContinentInfo.Visible = false;
        }

        // Оновлення пошуку при зміні параметрів пошуку міста.
        private void radioButtonCity_CheckedChanged(object sender, EventArgs e)
        {
            ShowResults(textBoxSearch.Text);
            UpdateInfo();

            groupBoxCountryInfo.Visible = false;
            groupBoxCityInfo.Visible = true;
            groupBoxContinentInfo.Visible = false;
        }

        // Оновлення інформації про обраний елемент пошуку.
        private void listBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }
    }
}
