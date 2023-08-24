using Assignment.PrototyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Adapter
{
    public abstract class Vehicle
    {

      

        protected string Whlee;
        protected string Body;
        protected string Color;
        protected string Mirror;
        protected Guid Id;
        
        public Vehicle(string w , string bodyValue , string colorValue ,string MirrorValue)
        {
            Id = Guid.NewGuid();
            Whlee = w; 
            Body = bodyValue; 
            Color = colorValue;
            Mirror = MirrorValue;
        }
        public abstract void MoveCar();
        public abstract void SoundSystem();
        public abstract Vehicle Clone();
        public virtual void Show()
        {
        
            Console.WriteLine($"Whlee: {Whlee}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Mirror: {Mirror}");

        }
    }
}
