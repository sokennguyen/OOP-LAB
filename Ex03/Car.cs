using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB.Ex3
{
    internal class Car
    {
        string register;
        string color;
        public int speed;
        public void SetCar(string reg, string col)
        {
            register = reg;
            color = col;
        }
        public int GetSpeed()
        {
            return speed;
        }
        public void ShowCar()
        {
            Console.WriteLine($"{register}, {color}, {speed}");
        }
        public void Accelerate(int accel)
        {
            if (speed + accel > 120) return;
            speed += accel;
        }
        public void BreakALittle() 
        {
            if (speed < 5) return;
            speed -= 5;
        }
        public void BreakALot()
        {
            if (speed < 10) return;
            speed -= 10;
        }
    }
}
