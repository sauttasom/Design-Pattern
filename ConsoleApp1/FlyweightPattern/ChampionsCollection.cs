using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FlyweightPattern
{
    public class ChampionsCollection
    {
        private List<Champion> _championsList = new List<Champion>();

        //public ChampionsCollection()
        //{
        //    _championsCollection = new List<Champion>();
        //}
        public void AddChampion(string roleplay, string skin, string name ,string[] abilitites, ChampionsFactory factory)
        {
            var attribute = factory.SelectChampionAttribute(name, abilitites);

            Champion champion = new Champion(skin, roleplay, attribute);
            _championsList.Add(champion);

        }

        public string ShowInfoChampions()
        {
            string info = string.Empty;
            foreach (var champion in _championsList)
            {
                info += champion.PickChampions();
           
            }
            return info;
        }
    }

}
