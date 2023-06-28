/*
You can create custom collections, where you define how to work with a group of objects.
If you only need to iterate through a collection, use the IEnumerable interface. If you also
want to include methods for modification (Add, Remove, Clear, CopyTo), use the
ICollection interface instead.
The IEnumerable.GetEnumerator() method is kept for compatibility with old C# code, when
there was no generic collections.Also, in older C# versions, the CollectionBase class was
used instead of GetEnumerator().
Links:
• https://stackoverflow.com/questions/13903426/what-is-a-custom-collection
• https://stackoverflow.com/questions/560678/ienumerablet-provides-twogetenumerator-methods-what-is-the-difference-betwe
• https://stackoverflow.com/questions/10113244/why-use-icollection-and-notienumerable-or-listt-on-many-many-one-many-relatio
• https://stackoverflow.com/a/31190058
*/
using System;
using System.Collections; // needed for List
using System.Collections.Generic; // needed for IEnumerable.GetEnumerator
namespace Ex_03_07
{
    class Program
    {
        static void Main()
        {
            List<string> list = new List<string>() { "a", "b", null, "c" };
            // Generic example
            GoodList<string> gList = new GoodList<string>(list);
            // This foreach uses GetEnumerator()
            foreach (var s in gList)
                Console.WriteLine(s);
            Console.WriteLine();
            // Non-generic example, for older code
            IEnumerable oldList = gList; // casts generic to non-generic
                                         // This foreach uses IEnumerable.GetEnumerator()
            foreach (var s in oldList)
                Console.WriteLine(s);
        }
    }
    /**********************************************************************/
    class GoodList<T> : IEnumerable<T>
    {
        List<T> myList = new List<T>();
        // Constructor, adds only non-null elements
        public GoodList(List<T> source)
        {
            foreach (T element in source)
                if (!(element is null)) // or if (element is not null) in newer C#
                    myList.Add(element);
        }
        // This method defines how foreach iterates through the class
        public IEnumerator<T> GetEnumerator()
        {
            Console.WriteLine("GetEnumerator");
            return myList.GetEnumerator();
        }
        // Needed for IEnumerable<T>, for compatibility with old, non-generic code
        IEnumerator IEnumerable.GetEnumerator()
        {
            Console.WriteLine("Deprecated GetEnumerator");
            return GetEnumerator();
        }
    }
}