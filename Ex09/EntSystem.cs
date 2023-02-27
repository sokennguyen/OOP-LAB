using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class EntSystem
    {
        static EntSystem entSystem;
        string model;
        string type;
        private int serialNumber = 0;
        private static int prodNr = 0;        
        private EntSystem(string model, string type)
        {
            this.model = model;
            this.type = type;
            this.serialNumber=++prodNr;
        }
        public static EntSystem GetEntSystem(string model, string type)
        {
            if (entSystem == null)
                entSystem = new EntSystem(model, type);
            return entSystem;
        }
        public static int ProdAmount()
        {
            return prodNr;
        }
        public override string ToString()
        {
            return $"PopMyMachine, Model: {this.model}, Type: {this.type}, Serial No.: PMMNDe1{this.serialNumber.ToString("D6")}";
        }
    }
}
