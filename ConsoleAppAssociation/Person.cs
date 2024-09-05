using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssociation
{
    internal class Person
    {
        private protected string id;
        //private string id;
        private static int serialNumber = 0;
        private string name;
        private string bloodGroup;
        private AddressFormat address;

        internal Person(string name, string bloodGroup, AddressFormat address)
        {
            
            this.ID = (++serialNumber).ToString();
            this.Name = name;
            this.BloodGroup = bloodGroup;
            this.Address = address;
        }

        internal virtual string ID
        {
            get { return this.id; }
            set { this.id =  value; }
        }

        internal string Name
        {
            get; set;
        }

        internal string BloodGroup
        {
            get;set;
        }

        internal AddressFormat Address
        {
            get; set;
        }

        internal virtual void ShowInfo()
        {
            Console.WriteLine("ID : {0}",this.ID);
            Console.WriteLine("Name : {0}",this.Name);
            Console.WriteLine("BloodGroup : {0}",this.BloodGroup);
            /*Console.WriteLine("ID : {0}",this.ID);*/
            this.Address.ShowInfo();
        }
    }
}
