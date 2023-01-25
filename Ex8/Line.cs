using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class Line:GraphicalObject
    {
        Point startPoint, endPoint;
        public Line(string color, Point startPoint, Point endPoint):base(color)
        {
            this.startPoint= startPoint;
            this.endPoint= endPoint;
        }
        public override void Display()
        {
            startPoint.Display();
            endPoint.Display();
        }

       
    }
}
