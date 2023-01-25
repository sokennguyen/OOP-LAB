using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    public class Manager: Employee2
    {
        public Employee2 subordinate;
        public Manager()
        {
            salary = 1500;
        }
        public void SetSubordiate(Employee2 subordinate)
        {
            if (this.subordinate != null)
            {
                this.DropSubordinate();
            }
            this.subordinate = subordinate;
            salary += subordinate.salary * 0.1;
        }
        public Employee2 GetSubordiate()
        {
            return this.subordinate;
        }
        public void DropSubordinate()
        {
            this.salary-= subordinate.salary*0.1;
            this.subordinate = null;
        }
    }
}
