using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GeoHelper
{
    // Класс описывающий справочник, с которым работает пользователь.
    public class Companion
    {
        // Список континентов, которые содержит справочник.
        public List<Continent> ContinentList { get; set; }
        
        public Companion()
        {
            ContinentList = new List<Continent> { };
        }

        // Добавть в список континентов новый континент с указанным названием.
        public void Add(string name)
        {
            ContinentList.Add(new Continent(name));
        }

        // Удалить из списка континентов указанный континент
        public Continent Remove(Continent continent)
        {
            ContinentList.Remove(continent);
            return continent;
        }

        // Обновить всю информацию о континентах.
        public void Update()
        {
            foreach(Continent continent in ContinentList)
            {
                continent.Update();
            }
        }

        // Сохранить информацию справочника в файл.
        public void Save(string fileName)
        {
            Update();
            string json = JsonConvert.SerializeObject(ContinentList);
            File.WriteAllText($"..\\..\\Data\\{fileName}.json", json);
        }

        // Загрузить информацию в справочник из файла.
        public void Open(string fileName)
        {
            string json = File.ReadAllText($"..\\..\\Data\\{fileName}.json");
            ContinentList = JsonConvert.DeserializeObject<List<Continent>>(json);
        }
    }
}
