using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssociation
{
    internal class Employee : Person
    {
        private double salary;
        internal Employee(string name, string bloodGroup, AddressFormat address,double salary) : base(name, bloodGroup, address)
        {
            this.Salary = salary;
        }

        internal override string ID
        {
            get { return this.id; }
            //set { base.id = "P-" + value + "-S"; }
            set { this.id = "P-" + value + "-E"; }
        }
        internal double Salary
        {
            get { return this.salary; }
            set
            {
                if (value >0)
                {
                    this.salary = value;
                }
                else
                {
                    this.salary = -1;
                }
            }
        }
        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Salary : {0}", this.Salary);

        }
    }
}
