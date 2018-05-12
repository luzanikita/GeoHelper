using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoHelper
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            //Companion save_1 = new Companion();
            //save_1.Add("Европа");
            //save_1.ContinentList[0].Add("Украина", GovernmentForm.Демократия);
            //save_1.ContinentList[0].CountryList[0].Add("Харьков", -36.5, 50, 350.0, 1450082, false);
            //save_1.ContinentList[0].CountryList[0].Add("Киев", -30.31, 50.27, 847.66, 2934522, true);

            //save_1.ContinentList[0].Add("Россия", GovernmentForm.Диктатура);
            //save_1.ContinentList[0].CountryList[1].Add("Санкт-Петербург", -30.19, 59.57, 1403.0, 5351935, false);
            //save_1.ContinentList[0].CountryList[1].Add("Москва", -37.37, 55.45, 2561.5, 12506468, true);
            //save_1.Save("save_1");

            //save_1.Add("Северная-Америка");
            //save_1.ContinentList[1].Add("США", GovernmentForm.Демократия);
            //save_1.ContinentList[1].CountryList[0].Add("Вашингтон", 77.02, 38.53, 177.0, 601723, true);

            //save_1.Save("save_1");
        }
    }
}
