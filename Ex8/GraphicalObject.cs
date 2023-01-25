using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal abstract class GraphicalObject
    {
        protected string color="";
        public GraphicalObject(string color)
        {
            this.color = color;
        }
        public abstract void Display();
        public void DispType()
        {
            Console.WriteLine($"type: {this.GetType().Name}, color: {this.color}");
            Display();
            Console.WriteLine("\n");
        }
    }
}
