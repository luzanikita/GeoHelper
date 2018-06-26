using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GeoHelper
{
    // Головна форма довідника.
    public partial class MainForm : Form
    {
        // Посилання на довідник.
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

        // Оновлення джерел даних елементів форми та відображення інформації вибраних елементів.
        public void UpdateInfo()
        {
            UpdateContinentSource();
        }

        // Оноволення інформації про континенти.
        public void UpdateContinentInfo(Continent continent)
        {
            if(continent == null)
            {
                continentName.Text = "-";
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

        // Оновлення джерел даних континентів.
        public void UpdateContinentSource()
        {
            listBoxContinent.DataSource = new List<Continent> { };

            if (Helper.ContinentList.Count > 0)
            {
                if (Filter)
                {
                    if (comboBoxSort.Text == "Абетка")
                        Helper.ContinentList.Sort((emp1, emp2) => emp1.Name.CompareTo(emp2.Name));
                    else if (comboBoxSort.Text == "Площа")
                        Helper.ContinentList.Sort((emp1, emp2) => emp1.Area.CompareTo(emp2.Area));
                    else if (comboBoxSort.Text == "Населення")
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

        // Оновлення джерел даних країн.
        public void UpdateCountrySource(Continent continent)
        {
            listBoxCountry.DataSource = new List<Country> { };

            if (continent != null && continent.CountryList.Count > 0)
            {
                if (Filter)
                {
                    if (comboBoxSort.Text == "Абетка")
                        Helper.ContinentList.Sort((emp1, emp2) => emp1.Name.CompareTo(emp2.Name));
                    else if (comboBoxSort.Text == "Площа")
                        Helper.ContinentList.Sort((emp1, emp2) => emp1.Area.CompareTo(emp2.Area));
                    else if (comboBoxSort.Text == "Населення")
                        Helper.ContinentList.Sort((emp1, emp2) => emp1.Population.CompareTo(emp2.Population));
                }
                
                listBoxCountry.DataSource = (Filter && comboBoxGeoType.Text == "Країна") ?
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

        // Оноволення інформації про міста.
        public void UpdateCityInfo(City city)
        {
            if(city != null)
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

        // Оновлення джерел даних міст.
        public void UpdateCitySource(Country country)
        {
            listBoxCity.DataSource = new List<City> { };

            if (country != null && country.CityList.Count > 0)
            {
                if (Filter)
                {
                    if (comboBoxSort.Text == "Абетка")
                        Helper.ContinentList.Sort((emp1, emp2) => emp1.Name.CompareTo(emp2.Name));
                    else if (comboBoxSort.Text == "Площа")
                        Helper.ContinentList.Sort((emp1, emp2) => emp1.Area.CompareTo(emp2.Area));
                    else if (comboBoxSort.Text == "Населення")
                        Helper.ContinentList.Sort((emp1, emp2) => emp1.Population.CompareTo(emp2.Population));
                }

                listBoxCity.DataSource = (Filter && comboBoxGeoType.Text == "Місто") ?
                    CityFilter(country) : country.CityList;
                if(listBoxCity.Items.Count > 0)
                    listBoxCity.SelectedIndex = 0;
                else
                    UpdateCityInfo(null);
            }
            else
                UpdateCityInfo(null);
        }

        // Відображення панелі з інформацією про місто.
        private void radioButtonCity_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCountryInfo.Visible = false;
            groupBoxCityInfo.Visible = true;
            groupBoxContinentInfo.Visible = false;
        }

        // Відображення панелі з інформацією про країну.
        private void radioButtonCountry_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCityInfo.Visible = false;
            groupBoxCountryInfo.Visible = true;
            groupBoxContinentInfo.Visible = false;
        }

        // Відображення панелі з інформацією про континент.
        private void radioButtonContinent_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCityInfo.Visible = false;
            groupBoxCountryInfo.Visible = false;
            groupBoxContinentInfo.Visible = true;
        }

        // Вибор файлу для збереження.
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
       
        // Збереження інформації.
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        // Зміна відображення інформації та оновлення джерел даних при виборі континента.
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

        // Зміна відображення інформації та оновлення джерел даних при виборі міста.
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

        // Зміна відображення інформації та оновлення джерел даних при виборі країни.
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

        // Завантажити дані з файла.
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Неможливо завантажити дані з цього файлу!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Перед виходом з програми відкрити форму збереження даних.
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitForm exitForm = new ExitForm(this);
            DialogResult res = exitForm.ShowDialog();
            if (res == DialogResult.Cancel)
                e.Cancel = true;
            else if (res == DialogResult.Yes)
                SaveFile();
        }

        // Вихід з програми.
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Відкрити форму додавання нових елементів довідника.
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter = false;
            UpdateInfo();
            AddForm addForm = new AddForm(this);
            addForm.ShowDialog();
        }

        // Відкрити форму видалення елементів довідника.
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
                MessageBox.Show("Неможливо видалити елементи, яких не існує!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Відкрити форму зміни елементів довідника.
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Filter = false;
                UpdateInfo();
                listBoxContinent.SelectedIndex = 0;
                EditForm editForm = new EditForm(this);
                editForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неможливо змінити елементи, яких не існує!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Відображення континентів відповідно фільтрам.
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

        // Відображення країн відповідно фільтрам.
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

        // Відображення міст відповідно фільтрам.
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

        // Застосувати фільтри.
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

        // Скасувати фільтри.
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

        private void пошукToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm(this);
            form.ShowDialog();
        }
    }
}
