using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GeoHelper
{
    // Главная форма справочника.
    public partial class MainForm : Form
    {
        // Ссылка на справочник.
        public Companion Helper { get; set; }
        public MainForm()
        {
            InitializeComponent();
            Helper = new Companion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {    
            UpdateInfo();
        }

        // Обновление источников данных элементов формы и отображение информации о выбраных элементах.
        public void UpdateInfo()
        {
                Continent continent = UpdateContinentInfo();
                Country country = UpdateCountryInfo(continent);
                UpdateCityInfo(continent, country);
        }

        // Обновление информации о континентах.
        public Continent UpdateContinentInfo()
        {
            listBoxContinent.DataSource = new List<Continent> { };

            if (Helper.ContinentList.Count > 0)
            {
                if (checkBoxFilter.Checked)
                {
                    if (radioButtonAphaSort.Checked)
                        Helper.ContinentList.Sort((emp1, emp2) => emp1.Name.CompareTo(emp2.Name));
                    else if (radioButtonAreaSort.Checked)
                        Helper.ContinentList.Sort((emp1, emp2) => emp1.Area.CompareTo(emp2.Area));
                    else if (radioButtonPopualtionSort.Checked)
                        Helper.ContinentList.Sort((emp1, emp2) => emp1.Population.CompareTo(emp2.Population));
                }

                listBoxContinent.DataSource = Helper.ContinentList;
                Continent continent = Helper.ContinentList[listBoxContinent.SelectedIndex];
                continentName.Text = continent.Name;
                continentArea.Text = $"{continent.Area} км²";
                continentPopulation.Text = $"{continent.Population} чел.";

                return continent;
            }

            return null;
        }

        // Обновление информации о странах.
        public Country UpdateCountryInfo(Continent continent)
        {
            listBoxCountry.DataSource = new List<Country> { };

            if (continent != null && continent.CountryList.Count > 0)
            {
                if (checkBoxFilter.Checked)
                {
                    if (radioButtonAphaSort.Checked)
                        continent.CountryList.Sort((emp1, emp2) => emp1.Name.CompareTo(emp2.Name));
                    else if (radioButtonAreaSort.Checked)
                        continent.CountryList.Sort((emp1, emp2) => emp1.Area.CompareTo(emp2.Area));
                    else if (radioButtonPopualtionSort.Checked)
                        continent.CountryList.Sort((emp1, emp2) => emp1.Population.CompareTo(emp2.Population));
                }

                listBoxCountry.DataSource = continent.CountryList;
                Country country = continent.CountryList[listBoxCountry.SelectedIndex];
                countryName.Text = country.Name;
                countryCapital.Text = country.Capital != null ? country.Capital.Name : "-";
                countryArea.Text = $"{country.Area} км²";
                countryPopulation.Text = $"{country.Population} чел.";
                countryGovernment.Text = country.Government;

                return country;
            }

            return null;  
        }

        // Обновление информации о городах.
        public void UpdateCityInfo(Continent continent, Country country)
        {
            listBoxCity.DataSource = new List<City> { };

            if (continent != null && country != null && country.CityList.Count > 0)
            {
                if (checkBoxFilter.Checked)
                {
                    if (radioButtonAphaSort.Checked)
                        country.CityList.Sort((emp1, emp2) => emp1.Name.CompareTo(emp2.Name));
                    if (radioButtonAreaSort.Checked)
                        country.CityList.Sort((emp1, emp2) => emp1.Area.CompareTo(emp2.Area));
                    if (radioButtonPopualtionSort.Checked)
                        country.CityList.Sort((emp1, emp2) => emp1.Population.CompareTo(emp2.Population));
                }

                listBoxCity.DataSource = country.CityList;
                City city = country.CityList[listBoxCity.SelectedIndex];
                cityName.Text = city.Name;
                string longitude = city.Coordinates[0] > 0 ? "з.д." : "в.д.";
                string latitude = city.Coordinates[1] > 0 ? "с.ш." : "ю.ш.";
                cityCoordinates.Text =
                    $"{Math.Abs(city.Coordinates[0])}° {longitude} " +
                    $"{Math.Abs(city.Coordinates[1])}° {latitude} ";
                cityArea.Text = $"{city.Area} км²";
                cityPopulation.Text = $"{city.Population} чел.";
                cityIsCapital.Text = city.IsCapital ? "Да" : "Нет";

                int x = Convert.ToInt32((pictureBoxMap.Width + pictureBoxMap.Width / 2
                    - 1.5 * city.Coordinates[0] + 3) % pictureBoxMap.Width);
                int y = Convert.ToInt32((pictureBoxMap.Height + pictureBoxMap.Height / 2
                    - 1.5 * city.Coordinates[1]) % pictureBoxMap.Height) + 8;
                pictureBoxMarker.Location = new Point(x, y);
                pictureBoxMarker.Visible = true;
            }
            else
            {
                cityName.Text = "-";
                cityCoordinates.Text = "-";
                cityArea.Text = "-";
                cityPopulation.Text = "-";
                cityIsCapital.Text = "-";

                pictureBoxMarker.Visible = false;
            }
            
        }

        // Отображение панели с информацией о городе.
        private void radioButtonCity_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCountryInfo.Visible = false;
            groupBoxCityInfo.Visible = true;
            groupBoxContinentInfo.Visible = false;
        }

        // Отображение панели с информацией о стране.
        private void radioButtonCountry_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCityInfo.Visible = false;
            groupBoxCountryInfo.Visible = true;
            groupBoxContinentInfo.Visible = false;
        }

        // Отображение панели с информацией о континенте.
        private void radioButtonContinent_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCityInfo.Visible = false;
            groupBoxCountryInfo.Visible = false;
            groupBoxContinentInfo.Visible = true;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.Save("save_1");
        }

        // Применит фильтры и обновить информацию.
        private void checkBoxFilter_CheckedChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        // Изменение отображения информации при выборе континента.
        private void listBoxContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        // Изменение отображения информации при выборе города.
        private void listBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        // Изменение отображения информации при выборе страны.
        private void listBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        // Изменение фильтров на сортировку по площади.
        private void radioButtonAreaSort_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxFilter.Checked)
                UpdateInfo();
        }

        // Изменение фильтров на сортировку по количеству населения.
        private void radioButtonPopualtionSort_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFilter.Checked)
                UpdateInfo();
        }

        // Изменение фильтров на сортировку по алфавиту.
        private void radioButtonAphaSort_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFilter.Checked)
                UpdateInfo();
        }

        // Открыть форму добавления новых элементов в справочник.
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this);
            addForm.ShowDialog();
        }

        // Загрузить данные из файла.
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.Open("save_1");
            Helper.Update();
            UpdateInfo();
        }

        // При выходе из программы открыть форму закрытия, которая предлагает сохранить данные перед закрытием.
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitForm exitForm = new ExitForm(this);
            DialogResult res = exitForm.ShowDialog();
            if (res == DialogResult.Cancel)
                e.Cancel = true;
            else if (res == DialogResult.Yes)
                Helper.Save("save_1");
        }

        // Выход из программы.
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Открыть форму удаления элементов справочника.
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm(this);
            deleteForm.ShowDialog();
        }

        // Открыть форму изменения элементов справочника.
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this);
            editForm.ShowDialog();
        }
    }
}
