using OOP_LAB.Ex3;
using OOP_LAB.Ex6;
using System;
using System.Data;
using System.Diagnostics;
using System.Security.Cryptography;

namespace OOP_LAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1= new Employee();
            Employee emp2= new Employee();
            Manager man1=new Manager();
            Manager man2=new Manager();
            Manager man3=new Manager();
            man1.Subbordinate = emp1;
            man2.Subbordinate = emp2;
            man3.Subbordinate = man2;
            Console.WriteLine(man3.Salary);
            man2.DropSubordinate();
            Console.WriteLine(man3.Salary);
            Console.WriteLine(man2.Salary);

        }
    }
}