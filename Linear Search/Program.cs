using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int>() { 3, 5, 2, 1, 7, 4, 19, 4, 5, 9, 10, 11 }; //The list being searched through
            int X = 19;
            int itemFound = 0;


            for (int i = 0; i < A.Count - 1; i++) //Loops through every itm in the list.
            {
                if (A[i] == X) //Checks if the current item is the same as 'X'.
                {
                    itemFound = i;
                }
            }

            Console.WriteLine($"The number {X} was found in position {itemFound}.");
        }
    }
}