using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
  
    public abstract class State
    {

        protected Water water { get; set; }
        protected string stateName { get; set; }
        public abstract void Rain(string isLongtime);
        public abstract void EnterChlorine();
        public abstract void Sewage();

        public void SetWater(Water w) 
        { 
            water = w;
        }
        public string GetStateName() { return stateName; }
    }
    public class Water
    {
        private State _state;
        public Water(State state)
        {
            
            ChangeState(state);
        }

        public void ChangeState(State s)
        {
            string stateName = s.GetStateName();
            Console.WriteLine($"State : {stateName}");
            _state = s;
            _state.SetWater(this);
        }
        public  void Rain(string isLongtime) 
        {
            _state.Rain(isLongtime);
        }
        public  void EnterChlorine() {
            _state.EnterChlorine();
        }
        public  void Sewage() {
            _state.Sewage();
        }



    }
}
