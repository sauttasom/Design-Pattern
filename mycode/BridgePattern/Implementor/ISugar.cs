using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Implementor
{
    public interface ISugar
    {
        public string GetDetail();
        public string GetSugarType();
        public string GetSugarName();
        public string GetProcess();
    }
    public class SugarFree : ISugar
    {
        private readonly string name = "SugarsFree";
        private readonly string sugarType = "Sugars Weetness Type";
        private readonly string detail = "Sugar free foods use sugar substitutes for sweetness.";
        private readonly string process = "A sugar substitute is a food additive that provides a sweetness like that of sugar while " +
                "containing significantly less food energy than sugar-based sweeteners, making it a zero-calorie (non-nutritive)";
        public string GetDetail()
        {
      
           return detail;
        }
        public string GetSugarName()
        {
            return name;
        }

        public string GetProcess()
        {

            return process;
        }

        public string GetSugarType()
        {
            return sugarType;
        }
    }

    public class SugarWhite : ISugar
    {
        private readonly string name = "SugarWhite";
        private readonly string sugarType = "SugarWhite  Type";
        private readonly string detail = "White sugar, also called table sugar, granulated sugar is a commonly used type of sugar, made either of beet sugar or cane sugar";
        private readonly string process = "A sugar refinery is a refinery which processes raw sugar from cane or sugar extracted from beets into white refined sugar.";
        public string GetDetail()
        {

            return detail;
        }
        public string GetSugarName()
        {
            return name;
        }

        public string GetProcess()
        {

            return process;
        }

        public string GetSugarType()
        {
            return sugarType;
        }
    }

}
