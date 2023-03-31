using System.ComponentModel;
using System;
using System.Collections;

namespace NewLicense
{
    //Complexity
    internal class Program
    {
        private static int LicenseTime(string name , int availableAgents, string otherPeople)
        {
            otherPeople = otherPeople + " " + name;
            string[] names =   otherPeople.Split(' ') ;
            Array.Sort(names);


            int position = Array.IndexOf(names, name) + 1;

            
            int group =(position / availableAgents) + 1;

            if (group > 5)
            {
                group = 5 ;
            }

            return group * 20;
            

        }
        static void Main(string[] args)
        {
            Console.WriteLine(LicenseTime("Aaron", 3, "Jane Max Olivia Sam"));
        }
    }
}