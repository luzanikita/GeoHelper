using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GeoHelper
{
    // Класс, що описує довідник, з яким працює користувач.
    public class Companion
    {
        // Список континентів, які містить цей довідник.
        public List<Continent> ContinentList { get; set; }
        
        public Companion()
        {
            ContinentList = new List<Continent> { };
        }

        // Додати у довідник новий континент.
        public void Add(string name)
        {
            ContinentList.Add(new Continent(name));
        }

        // Видалити з довідник континент.
        public Continent Remove(Continent continent)
        {
            ContinentList.Remove(continent);
            return continent;
        }

        // Оновити інформацію континентів, які містяться у цьому довіднику.
        public void Update()
        {
            foreach(Continent continent in ContinentList)
            {
                continent.Update();
            }
        }

        // Зберегти інформацію довідника у файл.
        public void Save(string fileName)
        {
            Update();
            string json = JsonConvert.SerializeObject(ContinentList);
            File.WriteAllText(fileName, json);
        }

        // Завантажити інформацію у довідник з файлу.
        public void Open(string fileName)
        {
            if (fileName != "")
            { 
                string json = File.ReadAllText(fileName);
                ContinentList = JsonConvert.DeserializeObject<List<Continent>>(json);
            }
        }
    }
}
