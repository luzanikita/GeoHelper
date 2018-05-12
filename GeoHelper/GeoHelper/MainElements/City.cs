using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoHelper
{
    class City
    {
        public string Name { get; private set; }
        public double[] Coordinates { get; private set; }
        public double Area { get; private set; }
        public int Population { get; private set; }
        public bool IsCapital { get; private set; }

        public City(string name, double x, double y, double area, int population, bool setCapital)
        {
            Name = name;
            Coordinates = new double[] { x, y };
            Area = area;
            Population = population;
            IsCapital = setCapital;
        }
    }
}
