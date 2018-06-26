namespace GeoHelper
{
    // Класс, що описує елемент типу міста.
    public class City
    {
        // Назва міста.
        public string Name { get; private set; }
        // Координати міста.
        public double[] Coordinates { get; private set; }
        // Площа міста.
        public double Area { get; private set; }
        // Кількість населення міста.
        public int Population { get; private set; }
        // Чи є місто столицею.
        public bool IsCapital { get; private set; }
        // Країна, до якої відноситься місто.
        public string Parent { get; set; }

        public City(string name, double[] coordinates, double area, int population, bool isCapital, string parent)
        {
            Name = name;
            Coordinates = coordinates;
            Area = area;
            Population = population;
            IsCapital = isCapital;
            Parent = parent;
        }

        // Зміна параметрів міста. За замовчуванням не змінювати.
        public void Edit(string name = "", double[] coordinates = null, double area = -1, int population = -1, bool isCapital = false)
        {
            Name = name == "" ? Name : name;
            Coordinates[0] = coordinates[0] == 404 ? Coordinates[0] : coordinates[0];
            Coordinates[1] = coordinates[1] == 404 ? Coordinates[1] : coordinates[1];
            Area = area == -1 ? Area : area;
            Population = population == -1 ? Population : population;
            IsCapital = isCapital;
        }

        // Представлення об'єкту за його назвою.
        public override string ToString()
        {
            return Name;
        }
    }
}
