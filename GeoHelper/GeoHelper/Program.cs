using System;
using System.Windows.Forms;

namespace GeoHelper
{
    static class Program
    {
        /// <summary>
        /// Головна точка входу.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            //Test();
        }

        public static void Test()
        {
            Companion save_1 = new Companion();
            save_1.Add("Європа");
            save_1.ContinentList[0].Add("Україна", "Демократія");
            save_1.ContinentList[0].CountryList[0].Add("Харків", new double[] { -36.5, 50 }, 350.0, 1450082, false);
            save_1.ContinentList[0].CountryList[0].Add("Київ", new double[] { -30.31, 50.27 }, 847.66, 2934522, true);

            save_1.ContinentList[0].Add("Росія", "Диктатура");
            save_1.ContinentList[0].CountryList[1].Add("Санкт-Петербург", new double[] { -30.19, 59.57 }, 1403.0, 5351935, false);
            save_1.ContinentList[0].CountryList[1].Add("Москва", new double[] { -37.37, 55.45 }, 2561.5, 12506468, true);
            save_1.Save("save_1");

            save_1.Add("Північна-Америка");
            save_1.ContinentList[1].Add("США", "Демократія");
            save_1.ContinentList[1].CountryList[0].Add("Вашингтон", new double[] { 77.02, 38.53 }, 177.0, 601723, true);

            save_1.Add("Атлантида");
            save_1.ContinentList[2].Add("Нептуландія", "Монархія");
            save_1.ContinentList[2].CountryList[0].Add("Дно", new double[] { 22.02, -18.53 }, 17327.0, 60123723, true);
            save_1.Save("save_1");
        }
    }
}
