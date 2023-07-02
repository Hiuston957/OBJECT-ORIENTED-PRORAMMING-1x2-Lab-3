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
           
            Console.WriteLine(output);

            Console.WriteLine("xdd");
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


/*
 Kod, który podałeś, zawiera przykład użycia słowa kluczowego yield, które jest uproszczeniem składniowym (syntactic sugar) służącym do zwracania kolekcji.

yield służy do zwracania kolekcji wartości, połączonych w jedną grupę. To słowo kluczowe zwraca kolekcję implementującą interfejs IEnumerable i może być używane np. w pętli foreach.

W funkcji Main mamy przykład użycia yield. Zmienna output jest zadeklarowana jako zmienna typu var, co oznacza, że jej typ jest wnioskowany przez kompilator na podstawie przypisanej wartości.

Następnie używamy pętli foreach, aby przeiterować przez elementy zwracane przez funkcję CalculatePowers i wyświetlić je na konsoli za pomocą Console.WriteLine.

Funkcja CalculatePowers jest zadeklarowana jako metoda, która zwraca kolekcję liczb całkowitych (IEnumerable<int>). Przyjmuje dwa parametry: number (liczba, która ma być podnoszona do potęgi) oraz howMany (określa ile potęg ma być obliczonych).

Wewnątrz funkcji znajduje się pętla for, która iteruje howMany razy. W każdej iteracji wynik jest obliczany przez podniesienie number do odpowiedniej potęgi i przekazywany do kolekcji wynikowej za pomocą yield return. Oznacza to, że w każdej iteracji wynik zostanie dodany do kolekcji, ale zamiast zwracać całą kolekcję od razu, funkcja CalculatePowers będzie zwracać kolejne elementy jednocześnie, gdy zostanie wywołane yield return.

W efekcie, gdy wywołamy tę funkcję, dostaniemy kolekcję kolejnych potęg liczby number, które będą iterowane i wyświetlane w pętli foreach w funkcji Main.
*/