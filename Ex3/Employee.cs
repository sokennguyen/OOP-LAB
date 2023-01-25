using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class Employee
    {
        string FirstName;
        string lastName;
        int idNumber;
        double salary;
        public void SetName(string first, string last)
        {
            FirstName= first; 
            lastName= last;
        }
        public string GetName()
        {
            return FirstName + " " + lastName;
        }
        public double CalcTax()
        {
            return salary*0.3;
        }
        public void SetSalary(double p)
        {
            salary = p;
        }
        public void AddSalary(double p)
        {
            salary += p;
        }
        public void PrintSalary()
        {
            Console.WriteLine("The salary" + "of the employee " + FirstName + " " + lastName + " is " + salary);
        }
        public double GetSalary()
        {
            return salary;
        }
    }
}
