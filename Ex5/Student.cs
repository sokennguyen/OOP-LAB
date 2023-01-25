using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class Student
    {
        string name;
        int studentNr;
        int birthYear;
        public Student( int studentNr, string name, int birthYear)
        {
            this.name = name;
            this.studentNr = studentNr;
            this.birthYear = birthYear;
        }
        public string GetName()
        {
            return name;
        }
        public string ToString()
        {
            return $"{studentNr}: {name}, age: {DateTime.Now.Year-birthYear} years";
        }
    }
}
