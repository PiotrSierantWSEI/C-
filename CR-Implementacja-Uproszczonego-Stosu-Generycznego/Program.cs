using System;
using StrukturaStos;

namespace Program
{
    class Program
    {
        static void Main()
        {
            // Test1();
            // Test2();
            // Test3();
            Test4();
        }
        static void Test4()
        {
            /* Peek zwraca ostatnio wstawiony element 
                s.Peek( s.Push(e) ) == e */
            var s = new Stos<string>();
            s.Push("aaa");
            Console.WriteLine(s.Peek, "aaa");
        }
        static void Test3()
        {

            /* Peek dla pustego stosu zwraca wyjątek
            s.create.Peek ====> throw StosEmptyException */
            var s = new Stos<double>();
            Console.WriteLine(s.IsEmpty);
            try
            {
                var x = s.Peek;
            }
            catch (StosEmptyException)
            {
                Console.WriteLine("StosEmptyException");
            }
        }
        static void Test2()
        {
            /* weryfikacja, czy implementowany jest interfejs IStos
*/
            var stos = new Stos<char>();
            if (stos is StrukturaStos.IStos<char>)
                Console.WriteLine("Stos<T> implemented");
            else
                Console.WriteLine("Stos<T> not implemented");
        }
        static void Test1()
        {
            var s = new Stos<string>();
            s.Push("aaa");
            s.Push("bbb");
            s.Push("ccc");
            foreach (var x in s.ToArray())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine($"na szczycie jest: {s.Peek}");
            Console.WriteLine($"liczba elementów na stosie: {s.Count}");
            while (!s.IsEmpty)
            {
                Console.WriteLine($"zdejmuje: {s.Pop()}");
            }
            if (s.IsEmpty)
                Console.WriteLine("stos jest pusty");
        }
    }
}