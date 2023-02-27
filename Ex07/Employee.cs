using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    public class Employee
    {
        public enum rank {Private=1000,Corporal=1200,Sergeant=1300,Officer=1500};
        protected double salary;
        public Employee()
        {
            this.salary = 1000;
        }
        public double Salary
        {
            get { return this.salary; }
        }
    }
}
