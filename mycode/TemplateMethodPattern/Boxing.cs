using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public abstract class Boxing
    {
        protected void FindPartnerFight()
        {
            Console.WriteLine("Find Partner to Fight");
        }
        protected abstract void Regearsal();
        protected abstract void WeighUp();
        protected abstract void Punch();
        protected virtual void WaiKhruMuay() { }

        public void BoxingFightProgrom()
        {
            FindPartnerFight();
            Regearsal();
            WeighUp();
            WaiKhruMuay();
            Punch();
        
        }
    }
    public class MMABoxing : Boxing
    {
       
        protected override void Regearsal()
        {
            Console.WriteLine("Regearsal MMA");
        }

        protected override void WeighUp()
        {
            Console.WriteLine("WeighUp MMA");
        }
        protected override void Punch()
        {
            Console.WriteLine("Punch MMA");
        }
    }
    public class MuayThai : Boxing
    {
        //public MuayThai()
        //{
        //    //WaiKhruMuay();
        //}
        protected override void WaiKhruMuay()
        {
            Console.WriteLine(" WaiKhruMuay MuayThai");
        }
        protected override void Regearsal()
        {
            Console.WriteLine("MuayThai Regearsal");


        }

        protected override void WeighUp()
        {
            Console.WriteLine("WeighUp MuayThai");
        }
        protected override void Punch()
        {
           
            Console.WriteLine("Punch MuayThai");
        }
    }
}
