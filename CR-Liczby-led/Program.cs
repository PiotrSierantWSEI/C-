/*

Napisz program, który dla wczytanej ze standardowego wejścia liczby całkowitej bez znaku wypisze ją (na standardowe wyjście) przy użyciu cyfr LED. Do zapisu cyfr LED użyto tylko trzech znaków: spacji, podkreślenia _ oraz pionowej kreski |. Cyfry zawsze mają tę samą wysokość (3) oraz szerokość (3). Między cyframi nie ma dodatkowych odstępów.

Sugeruj się poniższymi przykładami.

232095
 _  _  _  _  _  _ 
 _| _| _|| ||_||_ 
|_  _||_ |_|  | _|

164610
    _     _     _ 
  ||_ |_||_   || |
  ||_|  ||_|  ||_|


799518
 _  _  _  _     _ 
  ||_||_||_   ||_|
  |  |  | _|  ||_|
Wejście:

liczba całkowita bez znaku
Wyjście:

zapis liczby przy użyciu cyfr LED
Jeśli rozwiązałeś to zadanie, nie powinien sprawić Ci kłopotu problem "odwrotny" - opublikowany na SPOJ: DIGNUM - Digital LED Number.

Rozwiązanie zadania jest testowane na podanych przykładach, jak również na innych, nie podanych zestawach testowych.


*/

using System;

namespace LedNumbers
{
    class Program
    {
        static void Main()
        {
            string[][] ledNumbers = new string[10][]
            {
                new string[] {" _ ", "| |", "|_|"}, // 0
                new string[] {"   ", "  |", "  |"}, // 1
                new string[] {" _ ", " _|", "|_ "}, // 2
                new string[] {" _ ", " _|", " _|"}, // 3
                new string[] {"   ", "|_|", "  |"}, // 4
                new string[] {" _ ", "|_ ", " _|"}, // 5
                new string[] {" _ ", "|_ ", "|_|"}, // 6
                new string[] {" _ ", "  |", "  |"}, // 7
                new string[] {" _ ", "|_|", "|_|"}, // 8
                new string[] {" _ ", "|_|", "  |"}  // 9
            };

            string number = Console.ReadLine();
            for (int i = 0; i < 3; i++) // 3 rows
            {
                for (int j = 0; j < number.Length; j++) // liczba kolumn/numerow
                {
                    int digit = (int)char.GetNumericValue(number[j]); // char.GetNumericValue('3') zwraca 3.
                    Console.Write(ledNumbers[digit][i]); // wypisujemy po indexie liczby z arrayki led numbers
                }
                Console.WriteLine();
            }
        }
    }
}