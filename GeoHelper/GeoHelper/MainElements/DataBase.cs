using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace GeoHelper
{
    class DataBase
    {
        public List<Continent> Data { get; set; }

        public DataBase()
        {
            Data = new List<Continent> { };
        }
        public void Add(string name)
        {
            Data.Add(new Continent(name));
        }

        public Continent Remove(Continent continent)
        {
            Data.Remove(continent);
            return continent;
        }

        public void Update()
        {
            foreach(Continent continent in Data)
            {
                continent.Update();
            }
        }

        public void Save(string fileName)
        {
            Update();
            string json = JsonConvert.SerializeObject(this);
            using (TextWriter writer = new StreamWriter($"..\\..\\Data\\{fileName}.txt"))
            {
                writer.WriteLine(json);
            }
        }
    }
}
