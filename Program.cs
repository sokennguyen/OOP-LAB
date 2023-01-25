using OOP_LAB.Ex3;
using OOP_LAB.Ex6;
using System;
using System.Data;
using System.Security.Cryptography;

namespace OOP_LAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Words testWord = new Words("hehe");
            Console.WriteLine(testWord.ThisIs());
        }
    }
}