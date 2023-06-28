/*Generic methods work on any type T. You can put additional restrictions on type T by
specyfing which interface(s) it should implement.
*/
using System;
namespace Ex_03_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(1.0);
            Print('t');
            Print(true);
            Console.WriteLine();
            Console.WriteLine(Bigger(8, 9));
            Console.WriteLine(Bigger(8.0, 9.0));
            Console.WriteLine(Bigger("eight", "nine"));
        }
        /**********************************************************************/
        // A method which works on any type, here named as T
        public static void Print<T>(T obj)
        {
            Console.WriteLine(obj.GetType() + ", " + obj.ToString());
        }
        // A method which works on any type T if T implements IComparable
        // If T implements IComparable, we can use CompareTo on obj1 and obj2
        public static T Bigger<T>(T obj1, T obj2) where T : IComparable
        {
            int sign = obj1.CompareTo(obj2);
            T output = sign >= 0 ? obj1 : obj2;
            return output;
        }
    }
}
