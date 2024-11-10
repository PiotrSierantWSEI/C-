using System;
using System.Collections.Generic;
namespace Zadania_petle
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("empty");
                return;
            }
            int[] dane = Array.ConvertAll<string, int>(input.Split(" "), int.Parse);
            short a = (short)dane[0];
            short b = (short)dane[1];
            short c = (short)dane[2];

            if (a == b)
            {
                Console.WriteLine("empty");
                return;
            }

            if(c <= 0) {
                return;
            }

            int min = Math.Min(a, b) + 1;
            int max = Math.Max(a, b) - 1;

            List<int> divisibleNumbers = new List<int>();
            for (int i = min; i <= max; i++)
            {
                if (i % c == 0)
                {
                    divisibleNumbers.Add(i);
                }
            }

            if (min > max)
            {
                Console.WriteLine("empty");
                return;
            }

            if (divisibleNumbers.Count == 0)
            {
                Console.WriteLine("empty");
            }

            else if (divisibleNumbers.Count <= 10)
            {
                Console.WriteLine("Tablica: " + string.Join(", ", divisibleNumbers));
            }
            else
            {
                Console.WriteLine(string.Join(", ", divisibleNumbers[0], divisibleNumbers[1], divisibleNumbers[2]) +
                                  ", ..., " + string.Join(", ", divisibleNumbers[divisibleNumbers.Count - 2], divisibleNumbers[divisibleNumbers.Count - 1]));
            }

            // int[] array = new int[max - min + 1];

            //  for (int i = 0; i < array.Length; i++)
            // {
            //     array[i] = min + i;
            // }

            // if (array.Length <= 10)
            // {
            //     Console.WriteLine(string.Join(", ", array));
            // }
            // else
            // {
            //     Console.WriteLine(string.Join(", ", array[0], array[1], array[2]) + ", ..., " + string.Join(", ", array[array.Length - 2], array[array.Length - 1]));
            // }
        }
    }
}

// Napisz program wczytujący ze standardowego wejścia dwie liczby całkowite (zakres typu short: od -32 768 do 32 767) a oraz b 
// i wypisujący na standardowe wyjście wszystkie liczby pomiędzy a i b, uporządkowane rosnąco, oddzielone od siebie przecinkiem i spacją (patrz przykłady).

// Jeśli wyprowadzanych wartości miałoby być więcej niż 10, należy wypisać trzy pierwsze liczby, następnie wielokropek (trzy kropki) i następnie dwie ostatnie wartości.

// Jeśli ciąg wartości wyjściowych miałby być pusty, należy wypisać na standardowe wyjście słowo empty.

// Rozwiązanie zadania jest testowane na podanych przykładach, jak również na innych, nie podanych zestawach testowych.

// Napisz program wczytujący ze standardowego wejścia trzy liczby całkowite (zakres typu short: od -32 768 do 32 767) a, b 
// oraz c (c > 0) i wypisujący na standardowe wyjście wszystkie liczby pomiędzy a i b podzielne bez reszty przez c, 
// uporządkowane rosnąco, oddzielone od siebie przecinkiem i spacją (patrz przykłady).

// Jeśli wyprowadzanych wartości miałoby być więcej niż 10, należy wypisać trzy pierwsze liczby, następnie wielokropek (trzy kropki) i następnie dwie ostatnie wartości spełniające warunki zadania.

// Jeśli ciąg wartości wyjściowych miałby być pusty, należy wypisać na standardowe wyjście słowo empty.

// Rozwiązanie zadania jest testowane na podanych przykładach, jak również na innych, nie podanych zestawach testowych.