using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoHelper
{
    class Continent
    {
        public string Name { get; private set; }
        public double Area { get; private set; }
        public int Population { get; private set; }
        public List<Country> CountryList { private set; get; }

        public Continent(string name)
        {
            Name = name;
            CountryList = new List<Country> { };
        }

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

        public void Add(string name, GovernmentForm gov)
        {
            CountryList.Add(new Country(name, gov));
        }

        public Country Remove(Country country)
        {
            CountryList.Remove(country);
            return country;
        }
    }
}
