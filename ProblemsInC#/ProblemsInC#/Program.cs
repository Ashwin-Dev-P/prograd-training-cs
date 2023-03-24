namespace ProblemsInC_
{
    using System;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Program to calculate the total number of repeated elements
             
             */
            int[] arr = new int[] {2,1,3,5,2,2,1};
            int repeatedElementsCount = 0;
            HashSet<int> myhash1 = new HashSet<int>();

            foreach (int i in arr)
            {
                if (! myhash1.Contains(i))
                {
                    myhash1.Add(i);
                }
                else
                {
                    repeatedElementsCount++;
                }
            }


            Console.WriteLine("Total number of repeated elements: "+repeatedElementsCount);
        }
    }
}