using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoHelper
{
    class Country
    {
        public string Name { get; private set; }
        public double Area { get; private set; }
        public int Population { get; private set; }
        public List<City> CityList { get; private set; }
        public City Capital { get; private set; }
        public GovernmentForm Government { get; private set; }
        public Country(string name, GovernmentForm gov)
        {
            Name = name;
            Government = gov;
            CityList = new List<City> { };
        }

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

        public void Add(string name, double x, double y, double area, int population, bool setCapital)
        {
            CityList.Add(new City(name, x, y, area, population, setCapital));
        }

        public City Remove(City city)
        {
            CityList.Remove(city);
            return city;
        }
    }
}
