using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace GeoHelper
{
    class Companion
    {
        public List<Continent> ContinentList { get; set; }

        public Companion()
        {
            ContinentList = new List<Continent> { };
        }
        public void Add(string name)
        {
            ContinentList.Add(new Continent(name));
        }

        public Continent Remove(Continent continent)
        {
            ContinentList.Remove(continent);
            return continent;
        }

        public void Update()
        {
            foreach(Continent continent in ContinentList)
            {
                continent.Update();
            }
        }

        public void Save(string fileName)
        {
            Update();
            string json = JsonConvert.SerializeObject(this.ContinentList);
            using (TextWriter writer = new StreamWriter($"..\\..\\Data\\{fileName}.json"))
            {
                writer.WriteLine(json);
            }
        }

        public void Open(string fileName)
        {
            string json;
            using (StreamReader sr = new StreamReader($"..\\..\\Data\\{fileName}.json"))
            {
                json = sr.ReadToEnd();
            }
            ContinentList = JsonConvert.DeserializeObject<List<Continent>>(json);
        }
    }
}
