using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class Teacher
    {
        string name;
        public Teacher(string name)
        {
            this.name = name;
        }
        public string ToString()
        {
            return name;
        }
    }
}
