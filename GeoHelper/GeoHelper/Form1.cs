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
    public partial class MainForm : Form
    {
        Companion Helper { get; set; }
        public MainForm()
        {
            InitializeComponent();
            Helper = new Companion();
            Helper.Open("save_1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxContinent.DataSource = Helper.ContinentList;
            listBoxCountry.DataSource = Helper.ContinentList[listBoxContinent.SelectedIndex].CountryList;
            listBoxCity.DataSource = Helper.ContinentList[listBoxContinent.SelectedIndex].CountryList[listBoxCountry.SelectedIndex].CityList;
        }

        private void ContinentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CountryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxNavigator_Enter(object sender, EventArgs e)
        {

        }

        private void listBoxContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCountry.DataSource = Helper.ContinentList[listBoxContinent.SelectedIndex].CountryList;
            listBoxCity.DataSource = Helper.ContinentList[listBoxContinent.SelectedIndex].CountryList[listBoxCountry.SelectedIndex].CityList;
        }

        private void listBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCity.DataSource = Helper.ContinentList[listBoxContinent.SelectedIndex].CountryList[listBoxCountry.SelectedIndex].CityList;
        }
    }
}
