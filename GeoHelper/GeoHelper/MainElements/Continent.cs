using System;
using System.Collections.Generic;

namespace GeoHelper
{
    // Класс описывающий элемент типа континента. Класс, що описує елемент типу континента.
    public class Continent
    {
        // Назва континента.
        public string Name { get; private set; }
        // Площа континента.
        public double Area { get; private set; }
        // Кількість населення континента.
        public int Population { get; private set; }
        // Список країн, що відносяться до цього континента.
        public List<Country> CountryList { private set; get; }

        public Continent(string name)
        {
            Name = name;
            CountryList = new List<Country> { };
        }

        // Оновити інформацію про континент на основі інформації про його країни.
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

        // Додати до списку країн цього континенту нову країну.
        public void Add(string name, string government)
        {
            CountryList.Add(new Country(name, government, this.ToString()));
        }

        // Видалити зі списку країн цього континенту країну.
        public Country Remove(Country country)
        {
            CountryList.Remove(country);
            return country;
        }

        // Змінити країну зі списку країн цього континенту. За замовчуванням не змінювати.
        public void Edit(string name = "")
        {
            Name = name == "" ? Name : name;
        }

        // Представлення об'єкту за його назвою.
        public override string ToString()
        {
            return Name;
        }
    }
}
