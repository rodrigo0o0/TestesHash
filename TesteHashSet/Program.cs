using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() {0,2,4,5,6,8,10 };
            SortedSet<int> b = new SortedSet<int>() { 5,6,7,8,9,10 };

            

            Console.ReadKey();
        }

        static void PrintColection<T>(IEnumerable<T> collection)
        {

        }
    }
}
