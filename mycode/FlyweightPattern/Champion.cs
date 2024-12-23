using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class Champion
    {
     
        private string _Skin;
        private string _RolePlay;
        private ChampionsAttribute _ChampionsAttribute;
        public Champion(string skin, string rolePlay , ChampionsAttribute attribute) 
        {
            _Skin = skin;
            _RolePlay = rolePlay;
            _ChampionsAttribute = attribute;
        }
        public string PickChampions()
        {
            var dataChampions = _ChampionsAttribute.PickAttribute(this._RolePlay);
           
            return dataChampions;
        }
    }
}
