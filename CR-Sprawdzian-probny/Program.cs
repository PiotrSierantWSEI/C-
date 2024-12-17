// /*
// Przyjmij, że argument n jest nie mniejszy niż 3. Jeśli n jest parzyste, to narysuj wzorek dla n-1.

// ⚠️ nie piszesz programu, tylko treść procedury! Możesz (ale nie musisz) umieścić kod pomocniczy, który można wykorzystać w procedurze Wzorek.

// Na przykład:

// Dane wejściowe	Wynik
// 7
// *******
//  *****
//   ***
//    *
// 8
// *******
//  *****
//   ***
//    *
// 3
// ***
//  *


//  */

// using System;

// namespace CR_Sprawdzian_probny {
//     class Program {

//         static void Main(string[] args) {
//             Wzorek(7);
//             Wzorek(8);
//             Wzorek(3);
//         }
//         public static void Wzorek(int n) {
//             if(n < 3) {
//                 throw new ArgumentException();
//             }
//             if(n % 2 == 0) {
//                 n--;
//             }

//             for(int i = 0; i < n; i += 2) {
//                 for(int j = 0; j < i / 2; j++) {
//                     Space();
//                 }
//                 for(int j = 0; j < n - i; j++) {
//                     Star();
//                 }
//                 Console.WriteLine();
//             }
//         }

//         static void Star() => Console.Write("*");
//         static void Space() => Console.Write(" ");
//     }
// }

using System;

/*
/// <summary>
/// Oblicza pole trójkąta dowolnego dla zadanych długości boków, zaokrąglając wynik do podanej liczby cyfr po przecinku
/// </summary>
/// <param name="a">długość pierwszego boku, liczba całkowita nieujemna</param>
/// <param name="b">długość drugiego boku, liczba całkowita nieujemna</param>
/// <param name="c">długość trzeciego boku, liczba całkowita nieujemna</param>
/// <param name="precision">dokładność obliczeń (zaokrąglenie), liczba cyfr po przecinku (od 2 do 8)</param>
/// <returns>pole trójkąta obliczone z zadaną dokładnością</returns>
/// <exception cref="ArgumentOutOfRangeException">z komunikatem "wrong arguments", 
///     gdy <c>precision</c> jest poza przedziałem od 2 do 8 lub którakolwiek z długości jest ujemna</exception>    
/// <exception cref="ArgumentException">z komunikatem "object not exist", gdy trójkąta nie można utworzyć</exception>
public static double TriangleArea(int a, int b, int c, int precision=2)

*/

// namespace CR_Sprawdzian_probny {
//     class Program {

//         static void Main(string[] args) {
//             Console.WriteLine(TriangleArea(3, 4, 5));
//             Console.WriteLine(TriangleArea(3, 4, 5, 3));
//             Console.WriteLine(TriangleArea(3, 4, 5, 8));
//             Console.WriteLine(TriangleArea(3, 4, 5, 9));
//             Console.WriteLine(TriangleArea(3, 4, 5, 1));
//             Console.WriteLine(TriangleArea(3, 4, 5, 0));
//             Console.WriteLine(TriangleArea(3, 4, 5, -1));
//             Console.WriteLine(TriangleArea(3, 4, 5, 10));
//             Console.WriteLine(TriangleArea(3, 4, 5, 2));
//             Console.WriteLine(TriangleArea(3, 4, 5, 4));
//             Console.WriteLine(TriangleArea(3, 4, 5, 5));
//             Console.WriteLine(TriangleArea(3, 4, 5, 6));
//             Console.WriteLine(TriangleArea(3, 4, 5, 7));
//             Console.WriteLine(TriangleArea(3, 4, 5, 8));
//             Console.WriteLine(TriangleArea(3, 4, 5, 9));
//             Console.WriteLine(TriangleArea(3, 4, 5, 10));
//             Console.WriteLine(TriangleArea(3, 4, 5, 11));
//             Console.WriteLine(TriangleArea(3, 4, 5, 12));
//             Console.WriteLine(TriangleArea(3, 4, 5, 13));
//             Console.WriteLine(TriangleArea(3, 4, 5, 14));
//             Console.WriteLine(TriangleArea(3, 4, 5, 15));
//             Console.WriteLine(TriangleArea(3, 4, 5, 16));
//             Console.WriteLine(TriangleArea(3, 4, 5, 17));
//             Console.WriteLine(TriangleArea(3, 4, 5, 18));
//             Console.WriteLine(TriangleArea(3, 4, 5, 19));
//             Console.WriteLine(TriangleArea(3, 4, 5, 20));
//             Console.WriteLine(TriangleArea(3, 4, 5, 21));
//             Console.WriteLine(TriangleArea(3, 4, 5, 22));
//         }

//         public static double TriangleArea(int a, int b, int c, int precision=2)
//         {
//             if(precision < 2 || precision > 8 || a < 0 || b < 0 || c < 0)
//             {
//                 throw new ArgumentOutOfRangeException("wrong arguments");
//             }
//             if(a + b <= c || a + c <= b || b + c <= a)
//             {
//                 throw new ArgumentException("object not exist");
//             }
//             double p = (a + b + c) / 2.0;
//             double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
//             return Math.Round(area, precision);
//         }
//     }
// }

/*

Napisz program, który:

ze standardowego wejścia wczyta 3 napisy, podane w oddzielnych liniach,
przekonwertuje te napisy na liczby całkowite (typu int)
obliczy sumę tych trzech liczb całkowitych i wypisze wynik na standardowe wyjście (o ile nie zostaną zgłoszone wyjątki).
Twój program nie może zostać przerwany z powodu wyjątków, które mogą zostać zgłoszone podczas jego działania. Przechwyć je i wypisz na standardowe wyjście stosowny komunikat:

gdy zgłoszony zostanie inny wyjątek niż podane poniżej, wypisz tekst non supported exception, exit
gdy zgłoszony zostanie wyjątek FormatException wypisz tekst format exception, exit
gdy zgłoszony zostanie wyjątek ArgumentException wypisz tekst argument exception, exit
gdy zgłoszony zostanie wyjątek OverflowException wypisz tekst overflow exception, exit

*/
// namespace CR_Sprawdzian_probny {
//     class Program {

//         static void Main(string[] args) {
//             string[] lines = new string[3];
//             for(int i = 0; i < 3; i++) {
//                 lines[i] = Console.ReadLine();
//             }
//             try {
//                 checked {
//                     int a = int.Parse(lines[0]);
//                     int b = int.Parse(lines[1]);
//                     int c = int.Parse(lines[2]);
//                     Console.WriteLine(a + b + c);
//                 }
//             } catch(FormatException) {
//                 Console.WriteLine("format exception, exit");
//             } catch(ArgumentException) {
//                 Console.WriteLine("argument exception, exit");
//             } catch(OverflowException) {
//                 Console.WriteLine("overflow exception, exit");
//             } catch(Exception) {
//                 Console.WriteLine("non supported exception, exit");
//             }
//         }
//     }
// }

/* 

Napisz funkcję, która dla przekazanej jako parametr dwuwymiarowej regularnej tablicy liczb całkowitych obliczy średnią arytmetyczną zawartych w niej liczb dodatnich, 
zaokrąglając wynik do 2 miejsc po przecinku. Jeśli jako argument przekazano null lub tablicę pustą, zwróć 0.00. Jeśli nie ma liczb spełniających wymagania, zwróć 0.00.

*/
namespace CR_Sprawdzian_probny {
    class Program {
        static void Main(string[] args) {
            int[,] arr = new int[,] {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            Console.WriteLine(AveragePositive(arr));
        }

        public static double AveragePositive(int[,] arr) {
            if(arr == null || arr.Length == 0) {
                return 0.00;
            }
            int sum = 0;
            int count = 0;
            foreach(int i in arr) {
                if(i > 0) {
                    sum += i;
                    count++;
                }
            }
            if(count == 0) {
                return 0.00;
            }
            return Math.Round((double)sum / count, 2);
        }
    }
}