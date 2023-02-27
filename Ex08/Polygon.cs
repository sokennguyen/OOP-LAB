using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class Polygon:GraphicalObject
    {
        Line[] lines;
        public Polygon(string color, Point[] points):base(color) 
        {
            lines = new Line[points.Length];
            if (points != null&&points.Length>=3 ) 
            {
                int i;
                for(i = 0; i < points.Length - 1; i++)
                    lines[i] = new Line(color, points[i], points[i + 1]);
                lines[i] = new Line(color, points[points.Length - 1], points[0]);
            }
        }
        public override void Display()
        {
            foreach(Line line in lines) 
            {
                line.Display();
            }
        }

    }
}
