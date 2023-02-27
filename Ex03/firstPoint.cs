using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class firstPoint
    {
        public int xPos, yPos;
        public firstPoint()
        {
            xPos = 10;
            yPos = 20;
        }
        public firstPoint(int _x,int _y)
        {
            xPos = _x;
            yPos = _y;
        }

        public void SetPoint(int x,int y)
        {
            xPos = x; yPos = y;
        }
        public void ShowPoint()
        {
            Console.WriteLine($"{xPos}, {yPos}");
        }
    }
}
