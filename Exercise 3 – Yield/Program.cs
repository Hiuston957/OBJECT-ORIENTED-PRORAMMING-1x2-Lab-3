/*
Yield is a syntactic sugar(a language simplification) for returning a collection.Yield returns
a number of values, combined into a single group.It returns a collection which implements
the IEnumerable interface, and therefore can be used e.g. in a foreach statement.
*/
using System;
using System.Collections.Generic;
namespace Ex_03_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = CalculatePowers(2, 20);
            foreach (int x in output)
                Console.WriteLine(x);
        }
        /**********************************************************************/
        static IEnumerable<int> CalculatePowers(int number, int howMany)
        {
            int result = 1;
            for (int i = 0; i < howMany; i++)
            {
                result *= number;
                yield return result; // add result to the output collection
            }
        }
    }
}
