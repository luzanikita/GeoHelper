namespace GeoHelper
{
    // Класс описывающий элемент типа города.
    public class City
    {
        // Название города.
        public string Name { get; private set; }
        // Координаты города.
        public double[] Coordinates { get; private set; }
        // Площадь города.
        public double Area { get; private set; }
        // Количество населения города.
        public int Population { get; private set; }
        // Является ли город столицей.
        public bool IsCapital { get; private set; }

        public City(string name, double[] coordinates, double area, int population, bool isCapital)
        {
            Name = name;
            Coordinates = coordinates;
            Area = area;
            Population = population;
            IsCapital = isCapital;
        }

        // Изменения полей обьекта, если параметры не были указаны, то изменение не происходит. 
        public void Edit(string name = "", double[] coordinates = null, double area = -1, int population = -1, bool isCapital = false)
        {
            Name = name == "" ? Name : name;
            Coordinates[0] = coordinates[0] == 404 ? Coordinates[0] : coordinates[0];
            Coordinates[1] = coordinates[1] == 404 ? Coordinates[1] : coordinates[1];
            Area = area == -1 ? Area : area;
            Population = population == -1 ? Population : population;
            IsCapital = isCapital;
        }
    }
}
