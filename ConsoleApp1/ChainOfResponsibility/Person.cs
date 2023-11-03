using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Person
    {
        public string Name { get; set; }
        public bool Gender { get; set; }
        public int Tall { get; set; }
        public int Age { get; set; }
        public bool Drug { get; set; }
        public bool Deferment { get; set; }
        public bool CanCatch { get; set; }
        public bool ThaiNationality { get; set; }
    }
}
