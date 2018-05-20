using System;
using System.Collections.Generic;

namespace GeoHelper
{
    // Класс описывающий элемент типа континента.
    public class Continent
    {
        // Название континента.
        public string Name { get; private set; }
        // Площадь континента.
        public double Area { get; private set; }
        // Количество населения континента.
        public int Population { get; private set; }
        // Список стран, которые относятся к этому континенту.
        public List<Country> CountryList { private set; get; }

        public Continent(string name)
        {
            Name = name;
            CountryList = new List<Country> { };
        }

        // Обновить значения площади и населения, посчитав сумму площадей и населения стран этого континета.
        public void Update()
        {
            Area = 0;
            Population = 0;
            foreach (Country country in CountryList)
            {
                country.Update();
                Area = Math.Round(Area + country.Area, 2);
                Population += country.Population;
            }
        }

        // Добавить в список стран этого континента новую страну.
        public void Add(string name, string government)
        {
            CountryList.Add(new Country(name, government));
        }

        // Удалить из списка стран этого континента указанную страну.
        public Country Remove(Country country)
        {
            CountryList.Remove(country);
            return country;
        }

        // Изменить название континента, если параметры не заданы, то не изменять.
        public void Edit(string name = "")
        {
            Name = name == "" ? Name : name;
        }
    }
}
