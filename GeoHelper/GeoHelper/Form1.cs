using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GeoHelper
{
    // Главная форма справочника.
    public partial class MainForm : Form
    {
        // Ссылка на справочник.
        public Companion Helper { get; set; }
        private bool Filter { get; set; }
        public MainForm()
        {
            InitializeComponent();
            Helper = new Companion();
            Filter = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {    
            UpdateInfo();
        }

        // Обновление источников данных элементов формы и отображение информации о выбраных элементах.
        public void UpdateInfo()
        {
            UpdateContinentSource();
        }

        // Обновление информации о континентах.
        public void UpdateContinentInfo(Continent continent)
        {
            if(continent is null)
            {
                continentName.Text = "-";
                continentArea.Text = "-";
                continentPopulation.Text = "-";
            }
            else
            {
                continentName.Text = continent.Name;
                continentArea.Text = $"{continent.Area} км²";
                continentPopulation.Text = $"{continent.Population} чел.";
            }
        }

        public void UpdateContinentSource()
        {
            listBoxContinent.DataSource = new List<Continent> { };

            if (Helper.ContinentList.Count > 0)
            {
                if (Filter)
                {
                    if (comboBoxSort.Text == "Алфавит")
                        Helper.ContinentList.Sort((emp1, emp2) => emp1.Name.CompareTo(emp2.Name));
                    else if (comboBoxSort.Text == "Площадь")
                        Helper.ContinentList.Sort((emp1, emp2) => emp1.Area.CompareTo(emp2.Area));
                    else if (comboBoxSort.Text == "Население")
                        Helper.ContinentList.Sort((emp1, emp2) => emp1.Population.CompareTo(emp2.Population));
                }
                listBoxContinent.DataSource = (Filter && comboBoxGeoType.Text == "Континент") ?
                    ContinentFilter() : Helper.ContinentList;
                if (listBoxContinent.Items.Count > 0)
                    listBoxContinent.SelectedIndex = 0;
                else
                {
                    UpdateContinentInfo(null);
                    UpdateCountrySource(null);
                }
            }
            else
            {
                UpdateContinentInfo(null);
                UpdateCountrySource(null);
            }
        }

        // Обновление информации о странах.
        public void UpdateCountryInfo(Country country)
        {
            if (country is null)
            {
                countryName.Text = "-";
                countryCapital.Text = "-";
                countryArea.Text = "-";
                countryPopulation.Text = "-";
                countryGovernment.Text = "-";
            }
            else
            {
                countryName.Text = country.Name != null ? country.Name : "-";
                countryCapital.Text = country.Capital != null ? country.Capital.Name : "-";
                countryArea.Text = $"{country.Area} км²";
                countryPopulation.Text = $"{country.Population} чел.";
                countryGovernment.Text = country.Government;
            }
                
        }

        public void UpdateCountrySource(Continent continent)
        {
            listBoxCountry.DataSource = new List<Country> { };

            if (continent != null && continent.CountryList.Count > 0)
            {
                if (Filter)
                {
                    if (comboBoxSort.Text == "Алфавит")
                        Helper.ContinentList.Sort((emp1, emp2) => emp1.Name.CompareTo(emp2.Name));
                    else if (comboBoxSort.Text == "Площадь")
                        Helper.ContinentList.Sort((emp1, emp2) => emp1.Area.CompareTo(emp2.Area));
                    else if (comboBoxSort.Text == "Население")
                        Helper.ContinentList.Sort((emp1, emp2) => emp1.Population.CompareTo(emp2.Population));
                }
                
                listBoxCountry.DataSource = (Filter && comboBoxGeoType.Text == "Страна") ?
                    CountryFilter(continent) : continent.CountryList;
                if(listBoxCountry.Items.Count > 0)
                    listBoxCountry.SelectedIndex = 0;
                else
                {
                    UpdateCountryInfo(null);
                    UpdateCitySource(null);
                }
            }
            else
            {
                UpdateCountryInfo(null);
                UpdateCitySource(null);
            }
        }

        // Обновление информации о городах.
        public void UpdateCityInfo(City city)
        {
            if(city != null)
            { 
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

        public void UpdateCitySource(Country country)
        {
            listBoxCity.DataSource = new List<City> { };

            if (country != null && country.CityList.Count > 0)
            {
                if (Filter)
                {
                    if (comboBoxSort.Text == "Алфавит")
                        Helper.ContinentList.Sort((emp1, emp2) => emp1.Name.CompareTo(emp2.Name));
                    else if (comboBoxSort.Text == "Площадь")
                        Helper.ContinentList.Sort((emp1, emp2) => emp1.Area.CompareTo(emp2.Area));
                    else if (comboBoxSort.Text == "Население")
                        Helper.ContinentList.Sort((emp1, emp2) => emp1.Population.CompareTo(emp2.Population));
                }

                listBoxCity.DataSource = (Filter && comboBoxGeoType.Text == "Город") ?
                    CityFilter(country) : country.CityList;
                if(listBoxCity.Items.Count > 0)
                    listBoxCity.SelectedIndex = 0;
                else
                    UpdateCityInfo(null);
            }
            else
                UpdateCityInfo(null);
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

        // Выбор файла для сохранения.
        private void SaveFile()
        {
            SaveFileDialog save = new SaveFileDialog();
            string path = Path.GetFullPath("x");
            path = path.Substring(0, path.Length - 11) + "Data";
            save.Filter = "json files (*.json)|*.json";
            save.InitialDirectory = path;
            DialogResult res = save.ShowDialog();
            save.FileName =  res == DialogResult.Cancel ? path + @"\default.json" : save.FileName;
            Helper.Save(save.FileName);
            save.RestoreDirectory = false;
        }
       
        // Сохранить информацию.
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        // Изменение отображения информации при выборе континента.
        private void listBoxContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxContinent.Items.Count > 0)
            {
                UpdateContinentInfo((Continent)(listBoxContinent.Items[listBoxContinent.SelectedIndex]));
                UpdateCountrySource((Continent)(listBoxContinent.Items[listBoxContinent.SelectedIndex]));
            }
            else
            {
                UpdateContinentInfo(null);
                UpdateCountrySource(null);
            }
        }

        // Изменение отображения информации при выборе города.
        private void listBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCity.Items.Count > 0)
            {
                UpdateCityInfo((City)(listBoxCity.Items[listBoxCity.SelectedIndex]));
            }
            else
            {
                UpdateCityInfo(null);
            }
            
        }

        // Изменение отображения информации при выборе страны.
        private void listBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxCountry.Items.Count > 0)
            {
                UpdateCountryInfo((Country)(listBoxCountry.Items[listBoxCountry.SelectedIndex]));
                UpdateCitySource((Country)(listBoxCountry.Items[listBoxCountry.SelectedIndex]));
            }
            else
            {
                UpdateCountryInfo(null);
                UpdateCitySource(null);
            }
            
        }

        // Загрузить данные из файла.
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            string path = Path.GetFullPath("x");
            path = path.Substring(0, path.Length - 11) + "Data";
            open.Filter = "json files (*.json)|*.json";
            open.InitialDirectory = path;
            open.ShowDialog();
            Helper.Open(open.FileName);
            open.RestoreDirectory = false;
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
                SaveFile();
        }

        // Выход из программы.
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Открыть форму добавления новых элементов в справочник.
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter = false;
            UpdateInfo();
            AddForm addForm = new AddForm(this);
            addForm.ShowDialog();
        }

        // Открыть форму удаления элементов справочника.
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Filter = false;
                UpdateInfo();
                listBoxContinent.SelectedIndex = 0;
                DeleteForm deleteForm = new DeleteForm(this);
                deleteForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вы не можете удалить элементы, которых нет!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Открыть форму изменения элементов справочника.
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
                Filter = false;
                UpdateInfo();
                listBoxContinent.SelectedIndex = 0;
                EditForm editForm = new EditForm(this);
                editForm.ShowDialog();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Вы не можете изменить элементы, которых нет!",
            //        "Ошибка",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //}
        }

        private List<Continent> ContinentFilter()
        {
            double minArea = textBoxMinArea.Text == "" ? -2 : Convert.ToDouble(textBoxMinArea.Text);
            double maxArea = textBoxMaxArea.Text == "" ? -1 : Convert.ToDouble(textBoxMaxArea.Text);
            int minPopulation = textBoxMinPopulation.Text == "" ? -2 : Convert.ToInt32(textBoxMinPopulation.Text);
            int maxPopulation = textBoxMaxPopulation.Text == "" ? -1 : Convert.ToInt32(textBoxMaxPopulation.Text);
            List<Continent> filtered = new List<Continent> { };

            foreach(Continent c in Helper.ContinentList)
            {
                if ((c.Area >= minArea || minArea == -2) &&
                    (c.Area <= maxArea || maxArea == -1) &&
                    (c.Population >= minPopulation || minPopulation == -2) &&
                    (c.Population <= maxPopulation || maxPopulation == -1))
                {
                    filtered.Add(c);
                }
            }
            return filtered;
        }

        private List<Country> CountryFilter(Continent continent)
        {
            double minArea = textBoxMinArea.Text == "" ? -2 : Convert.ToDouble(textBoxMinArea.Text);
            double maxArea = textBoxMaxArea.Text == "" ? -1 : Convert.ToDouble(textBoxMaxArea.Text);
            int minPopulation = textBoxMinPopulation.Text == "" ? -2 : Convert.ToInt32(textBoxMinPopulation.Text);
            int maxPopulation = textBoxMaxPopulation.Text == "" ? -1 : Convert.ToInt32(textBoxMaxPopulation.Text);
            List<Country> filtered = new List<Country> { };

            foreach(Country c in continent.CountryList)
            {
                if ((c.Area >= minArea || minArea == -2) &&
                    (c.Area <= maxArea || maxArea == -1) &&
                    (c.Population >= minPopulation || minPopulation == -2) &&
                    (c.Population <= maxPopulation || maxPopulation == -1))
                {
                    filtered.Add(c);
                }
            } 

            return filtered;
        }

        private List<City> CityFilter(Country country)
        {
            double minArea = textBoxMinArea.Text == "" ? -2 : Convert.ToDouble(textBoxMinArea.Text);
            double maxArea = textBoxMaxArea.Text == "" ? -1 : Convert.ToDouble(textBoxMaxArea.Text);
            int minPopulation = textBoxMinPopulation.Text == "" ? -2 : Convert.ToInt32(textBoxMinPopulation.Text);
            int maxPopulation = textBoxMaxPopulation.Text == "" ? -1 : Convert.ToInt32(textBoxMaxPopulation.Text);
            List<City> filtered = new List<City> { };

            foreach (City c in country.CityList)
            {
                if ((c.Area >= minArea || minArea == -2) &&
                    (c.Area <= maxArea || maxArea == -1) &&
                    (c.Population >= minPopulation || minPopulation == -2) &&
                    (c.Population <= maxPopulation || maxPopulation == -1))
                {
                    filtered.Add(c);
                }
            }

            return filtered;
        }

        private void buttonFilterOn_Click(object sender, EventArgs e)
        {
            if (Validator.ValidIntMinMaxTextBox(textBoxMinPopulation, textBoxMaxPopulation) &&
                Validator.ValidDoubleMinMaxTextBox(textBoxMinArea, textBoxMaxArea)
            )
            {
                Filter = true;
                UpdateInfo();
            }
        }

        private void buttonFilterOff_Click(object sender, EventArgs e)
        {
            comboBoxGeoType.Text = "";
            comboBoxSort.Text = "";
            textBoxMinArea.Text = "";
            textBoxMinArea.BackColor = Color.White;
            textBoxMaxArea.Text = "";
            textBoxMaxArea.BackColor = Color.White;
            textBoxMinPopulation.Text = "";
            textBoxMinPopulation.BackColor = Color.White;
            textBoxMaxPopulation.Text = "";
            textBoxMaxPopulation.BackColor = Color.White;
            Filter = false;
            UpdateInfo();
        }
    }
}
