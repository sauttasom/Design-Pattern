using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class ChampionsFactory
    {
        private List<ChampionsAttribute> _ChampionsFactory;

        public ChampionsFactory()
        {
            _ChampionsFactory = new List<ChampionsAttribute>();

        }
        public ChampionsAttribute SelectChampionAttribute(string name , string[] abilitites)
        {
            ChampionsAttribute championsAttribute = new ChampionsAttribute();
            foreach (var data in _ChampionsFactory)
            {
                if (data.Name.Equals(name))
                {
                    championsAttribute = data;
                    break;
                }
            }
            if (string.IsNullOrEmpty(championsAttribute.Name))
            {
                championsAttribute = new ChampionsAttribute(name, abilitites);
                _ChampionsFactory.Add(championsAttribute);

            }


            return championsAttribute;
        }
      
    }
}
