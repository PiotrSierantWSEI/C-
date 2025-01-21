/* 

Dane są dwie niepuste tablice liczb całkowitych int[] a oraz int[] b. Liczby zapamiętane w tych tablicach są posortowane w porządku niemalejącym.

Napisz procedurę o sygnaturze

public static void Print(int[] a, int[] b)
wypisującą na standardowe wyjście, w porządku rosnącym, te liczby z tablicy a, których nie ma w tablicy b oraz te liczby w tablicy b których nie ma w tablicy a.

Nie wypisuj duplikatów.
Liczby wypisz w jednej linii, oddzielając je pojedynczą spacją.
W przypadku braku liczb spełniających warunki zadania wypisz słowo empty.
⚠️ Rozwiąż zadanie wykorzystując standardowe kolekcje z przestrzeni nazw System.Collections.Generic. Zabronione jest używanie pętli (for, foreach, while) oraz technologii LINQ. Aby przygotować wynik do wydruku użyj metody string.Join().

*/
namespace SIMPSEQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5, 6, 7 });
            Print(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 });
            Print(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 8, 9, 10 });
            Print(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        }

        public static void Print(int[] a, int[] b)
        {
            var A = new SortedSet<int>(a);
            var B = new SortedSet<int>(b);
            A.SymmetricExceptWith(B);
            if (A.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            Console.WriteLine(string.Join(" ", A));
        }

        // public static void Print(int[] a, int[] b)
        // {
        //     var A = new SortedSet<int>(a);
        //     A.IntersectWith(b);
        //     if (A.Count == 0)
        //     {
        //         Console.WriteLine("empty");
        //         return;
        //     }
        //     Console.WriteLine(string.Join(" ", A));
        // }
        // public static void Print(int[] a, int[] b)
        // {
        //     var A = new SortedSet<int>(a);
        //     A.ExceptWith(b);
        //     if(A.Count == 0)
        //     {
        //         Console.WriteLine("empty");
        //         return;
        //     }
        //     Console.WriteLine(string.Join(" ", A));
        // }
    }
}



