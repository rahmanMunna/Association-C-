using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssociation
{
    internal class Student : Person
    {
        private double cgpa;
        internal Student(string name, string bloodGroup, AddressFormat address,double cgpa) : base(name, bloodGroup, address) 
        {
            this.Cgpa = cgpa;
            
        }

        internal override string ID
        {
            get { return this.id; }
            //set { base.id = "P-" + value + "-S"; }
            set { this.id = "P-" + value + "-S"; }
        }
        internal double Cgpa
        {
            get { return this.cgpa; }
            set { 
                if(value <= 4 && value >= 0)
                {
                    this.cgpa = value;  
                }
                else
                {
                    this.cgpa = -1;
                }
            }
        }
        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("CGPA : {0}",this.Cgpa);

        }

    }

    
}
