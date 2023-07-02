/* Extension methods are static methods which add extra functionalityto a class, struct or
interface without modifying it. They are created by adding “this” to the first parameter type,
and then calling the method on an object of this type. Extension methods can be added to
any class: custom(your own) or built-in (.NET).
*/
using System;
namespace Ex_03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Quidquid Latine dictum sit, altum videtur.";
            text.CountSymbol('u');
            // You can call many methods in one go
            string textNew = text.ToLower().ReverseString().Replace('.', '!');
            Console.WriteLine(textNew);
        }
    }
    /**********************************************************************/
    static class StringExtentionMethods
    {
        public static void CountSymbol(this string str, char symbol)
        {
            int count = 0;
            foreach (char c in str)
                if (c == symbol)
                    count++;
            Console.WriteLine($"{count} {symbol}");
        }
        public static string ReverseString(this string str)
        {
            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);
            string reversed = new string(charArr);
            return reversed;
        }
    }
}
