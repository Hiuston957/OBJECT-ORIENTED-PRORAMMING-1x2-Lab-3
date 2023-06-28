/* An indexer is a special property that allows a class / struct to be accessed like an array,
with the [ ] notation.
Links:
• https://www.tutorialsteacher.com/csharp/csharp-indexer
*/
using System;
namespace Ex_03_08
{
    class Program
    {
        static void Main()
        {
            SafeArray<int> tab = new SafeArray<int>(10);
            // Regular loop to fill the array
            for (int i = 0; i < tab.Length; i++)
                tab[i] = i;
            // Not so regular, still ok
            tab[-1] = -15;
            tab[100000] = -25;
            // Print the array
            for (int i = 0; i < tab.Length; i++)
                Console.WriteLine(tab[i]);
        }
    }
    /**********************************************************************/
    class SafeArray<T>
    {
        T[] arr;
        public int Length { get => arr.Length; }
        // Constructor
        public SafeArray(int n)
        {
            arr = new T[n];
        }
        // Indexer
        public T this[int i]
        {
            get
            {
                if (i < 0)
                    return arr[0]; // get first element instead
                else if (i >= Length)
                    return arr[Length - 1]; // get last element instead
                else
                    return arr[i];
            }
            set
            {
                if (i < 0)
                    arr[0] = value; // set first element instead
                else if (i >= Length)
                    arr[Length - 1] = value; // set last element instead
                else
                    arr[i] = value;
            }
        }
    }
}