using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssociation
{
    struct AddressFormat
    {
        private byte roadNo;
        private byte houseNo;
        private string district;

        internal AddressFormat(byte roadNo, byte houseNo, string district)
        {
            this.roadNo = roadNo;
            this.houseNo = houseNo;
            this.district = district;
        }

        internal void ShowInfo()
        {
            Console.WriteLine("Road-No : {0}", this.roadNo);
            Console.WriteLine("House-No : {0}", this.houseNo);
            Console.WriteLine("District : {0}", this.district);
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            /*Person person1 = new Person("Bruce","B+",new AddressFormat(12,67,"Cumilla"));
            Person person2 = new Person("Diana","B+",new AddressFormat(12,67,"Cumilla"));
            Person person3 = new Person("Hafiz","B+",new AddressFormat(12,67,"Cumilla"));
            person1.ShowInfo();
            person2.ShowInfo();
            person3.ShowInfo();*/
            /*person.ID = 1;
            Console.WriteLine(person.ID);*/

            //Polymorphic Object
           
            
            XYZOrganization.AddPerson(new Student("Bruce", "B+", new AddressFormat(12, 67, "Cumilla"), 3.94));
            XYZOrganization.AddPerson(new Student("Diana", "A+", new AddressFormat(12, 67, "Barishal"), 2.94));
            XYZOrganization.AddPerson(new Employee("Forck", "O+", new AddressFormat(12, 67, "Rangpur"), 30000));
            XYZOrganization.AddPerson(new Employee("Diana", "A+", new AddressFormat(12, 67, "Dhaka"), 20000));

            XYZOrganization.ShowAllPersonDetails();
            

        }
    }
}
