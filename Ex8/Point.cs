using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class Point:GraphicalObject
    {
        int x, y;
        public Point(string color, int x, int y) : base(color)
        {
            this.x = x;
            this.y = y;
        }
        public override void Display()
        {
            Console.WriteLine($", {x}, {y}");
        }
    }
}
