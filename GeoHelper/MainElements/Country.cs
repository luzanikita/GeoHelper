using System;
using System.Collections.Generic;

namespace GeoHelper
{
    // Класс, що описує елемент типу країни.
    public class Country
    {
        // Назва країни.
        public string Name { get; private set; }
        // Площа країни.
        public double Area { get; private set; }
        // Кількість населення країни.
        public int Population { get; private set; }
        // Столиця країни.
        public City Capital { get; set; }
        // Форма дкржавного управління країни.
        public string Government { get; private set; }
        // Список міст, що відносяться до цієї країни.
        public List<City> CityList { get; private set; }
        // Континент, до якого відноситься ця країна.
        public string Parent { get; set; }

        public Country(string name, string government, string parent)
        {
            Name = name;
            Government = government;
            CityList = new List<City> { };
            Parent = parent;
        }

        // Оновити інформацію про країну на основі інформації про її міста.
        public void Update()
        {
            Area = 0;
            Population = 0;
            foreach (City city in CityList)
            {
                Area = Math.Round(Area + city.Area, 2);
                Population += city.Population;
                Capital = city.IsCapital ? city : Capital;
            }
        }

        // Додати до списку міст цієї країни нове місто.
        public void Add(string name, double[] coordinates, double area, int population, bool isCapital)
        {
            CityList.Add(new City(name, coordinates, area, population, isCapital, this.ToString()));
        }

        // Видалити місто зі списку міст цієї країни.
        public City Remove(City city)
        {
            CityList.Remove(city);
            return city;
        }

        // Змінити інформіцію про країну. За замовчуванням не змінювати.
        public void Edit(string name = "", string government = "")
        {
            Name = name == "" ? Name : name;
            Government = government == "" ? Government : government;
        }

        // Представлення об'єкту за його назвою.
        public override string ToString()
        {
            return Name;
        }
    }
}
