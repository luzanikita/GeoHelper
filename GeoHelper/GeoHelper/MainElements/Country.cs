using System;
using System.Collections.Generic;

namespace GeoHelper
{
    // Класс описывающий элемент типа страны.
    public class Country
    {
        // Название страны.
        public string Name { get; private set; }
        // Площадь страны.
        public double Area { get; private set; }
        // Количество населения страны.
        public int Population { get; private set; }
        // Столица страны типа город.
        public City Capital { get; private set; }
        // Форма государственного управления страны.
        public string Government { get; private set; }
        // Список городов, которые относятся к данной стране.
        public List<City> CityList { get; private set; }

        public Country(string name, string government)
        {
            Name = name;
            Government = government;
            CityList = new List<City> { };

        }

        // Обновить информацию о площади и количестве населения,
        // посчитав сумму площади и населения всех городов, которые относятся к этой стране.
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

        // Добавить в список городов новый город. 
        public void Add(string name, double[] coordinates, double area, int population, bool isCapital)
        {
            CityList.Add(new City(name, coordinates, area, population, isCapital));
        }

        // Удалить город из списка городов этой страны.
        public City Remove(City city)
        {
            CityList.Remove(city);
            return city;
        }

        // Изменить названия и форму государственного управления страны,
        // если не указаны параметры, то не изменять.
        public void Edit(string name = "", string government = "")
        {
            Name = name == "" ? Name : name;
            Government = government == "" ? Government : government;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
