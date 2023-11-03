using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{

    public class ChampionsAttribute
    {
        public string Name;
        public string[] Abilities;
        public ChampionsAttribute() { }
        public ChampionsAttribute(string name, string[] abilitites)
        {
            Name = name;
            Abilities = abilitites;
        }

        public string PickAttribute(string role)
        {
            string playForpostion = string.Empty;
            string dataChampion = string.Empty;
            StringBuilder abilitites = new StringBuilder();
            if (!string.IsNullOrEmpty(role))
            {
                switch (role)
                {
                    case "J":
                        playForpostion += "Jungle";
                        break;
                    case "M":
                        playForpostion += "Mid Lane";
                        break;
                    case "S":
                        playForpostion += "Support";
                        break;
                    case "A":
                        playForpostion += "Carry";
                        break;
                    case "T":
                        playForpostion += "TOP";
                        break;

                }

            }

            for (int i = 0; i < Abilities.Length; i++)
            {
                abilitites.Append($"{i + 1} {Abilities[i]}\n");

            }

            dataChampion = $"Champion Name : {this.Name}\nRolePlay : {playForpostion}  \nABILITIES : \n{abilitites} \n";
            return dataChampion;
        }


    }
}
