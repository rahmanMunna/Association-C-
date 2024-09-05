using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssociation
{
    internal static class XYZOrganization
    {
        //private static string name;
        private static Person[] persons = new Person[100]; ////to make sure ,if there is any different copy or obj ,person array has still 1 copy
        private static byte index = 0; //to make sure ,if there is any different copy or obj ,index has still 1 copy

       /* internal  XYZOrganization(string name)
        {
            Name  = name;
        }*/

        internal static string Name
        {
            get;set;
        }

        internal static void AddPerson(Person p)
        {
           XYZOrganization.persons[index] = p;
            index++;
        }

        internal static void ShowAllPersonDetails()
        {
            for(byte c =0; c<index; c++)
            {
                persons[c].ShowInfo();
                Console.WriteLine();
            }
        }
    }
}
