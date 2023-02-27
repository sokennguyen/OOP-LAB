using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    public class Manager: Employee
    {
        public Employee subordinate;
        public Manager():base()
        {
            salary = 1500;
        }
        public Employee Subordinate
        {
            get { return subordinate; }
            set 
            {
                if (this.subordinate != null)
                {
                    this.DropSubordinate();
                }
                this.subordinate = value;
                this.salary += 0.1 * subordinate.Salary;
            }
        }
        public void DropSubordinate()
        {
            this.salary -= subordinate.Salary * 0.1;
            this.subordinate = null;
        }
    }
}
