using Assignment.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.BuilderPatterns
{
    // Interface
    public interface IBuilder
    {
        public void reset();
        public void BuildType(string swordType);
        public void BuildMaterial();
        public void BuildDecoration();
        public void BuildTemplate();
        public void BuildPerformCasting();
        public void BuildEngraveAndCoat();
        public Sword GetSword();
    }

    public class SwordBuilder : IBuilder
    {

        private Sword _sword = new Sword();



        public void BuildEngraveAndCoat()
        {
            _sword.setEngraveAndCoat();
        }
        public void BuildDecoration()
        {
            _sword.setDecoration();
        }

        public void BuildMaterial()
        {
            _sword.setMaterial(false,true);
        }

        public void BuildPerformCasting()
        {
            _sword.setPerformCasting();
        }

        public void BuildTemplate()
        {
            _sword.setTemplate();
        }

        public void BuildType(string swordType)
        {
            _sword.setSwordType(swordType);
        }

        public Sword GetSword()
        {
            var sword = _sword;
            this.reset();
            return sword;
        }

        public void reset()
        {
            _sword = new Sword();
        }
    }

    public class ToySwordBuilder : IBuilder
    {
        private Sword _toy = new Sword();
 
        public void BuildEngraveAndCoat()
        {
            _toy.setEngraveAndCoat();
        }
        public void BuildDecoration()
        {
            _toy.setDecoration();
        }

        public void BuildMaterial()
        {
            _toy.setMaterial(true, false);
        }

        public void BuildPerformCasting()
        {
            _toy.setPerformCasting();
        }

        public void BuildTemplate()
        {
            _toy.setTemplate();
        }

        public void BuildType(string swordType)
        {
            _toy.setSwordType(swordType);
        }

        public Sword GetSword()
        {
            var toy  = _toy;
            this.reset();
            return toy;
        }

        public void reset()
        {
            _toy = new Sword();
        }

    }



}
