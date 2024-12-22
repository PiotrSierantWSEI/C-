// using System;

// class Program
// {
//     const char CHAR = '*';
//     static void Star() => Console.Write(CHAR);
//     static void Space() => Console.Write(" ");
//     static void NewLine() => Console.WriteLine();

//     static void Wzorek(int n)
//     {
//         if (n < 3) throw new ArgumentException("zbyt mały rozmiar");

//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 if (i == 0)
//                 {
//                     Star();
//                 }
//                 else if (j == n - 1 - i)
//                 {
//                     Star();
//                 }
//                 else
//                 {
//                     Space();
//                 }
//             }
//             NewLine();
//         }
//     }
//     public static void Main(string[] args)
//     {
//         int n = int.Parse(Console.ReadLine());
//         Wzorek(n);
//     }
// }

// /*
// Na przykład:

// Dane wejściowe	Wynik
// 7
// *******
//      *
//     *
//    *
//   *
//  *
// *
// 8
// ********
//       *
//      *
//     *
//    *
//   *
//  *
// *
// 3
// ***
//  *
// *

// */


/// <summary>
/// Oblicza obwód trójkąta równoramiennego dla zadanych długości: podstawy oraz wysokości opuszczonej na podstawę, zaokrąglając wynik do podanej liczby cyfr po przecinku
/// </summary>
/// <param name="basis">długość podstawy, liczba całkowita nieujemna</param>
/// <param name="height">długość wysokości opuszczonej na podstawę, liczba całkowita nieujemna</param>
/// <param name="precision">dokładność obliczeń (zaokrąglenie), liczba cyfr po przecinku (od 2 do 8)</param>
/// <returns>obwód trójkąta obliczone z zadaną dokładnością</returns>
/// <exception cref="ArgumentOutOfRangeException">z komunikatem "wrong arguments", 
///     gdy <c>precision</c> jest poza przedziałem od 2 do 8 lub którakolwiek z długości jest ujemna</exception>    
/// <exception cref="ArgumentException">z komunikatem "object not exist", gdy trójkąta nie można utworzyć</exception>
// static double TriangleIsoscelesPerimeter(int basis, int height, int precision=2)
// {
//     if (precision < 2 || precision > 8 || basis < 0 || height < 0) {
//         throw new ArgumentOutOfRangeException("wrong arguments");
//     }

//     if (basis == 0 || height == 0) {
//         throw new ArgumentException("object not exist");
//     }

//     double obwod = basis + 2 * Math.Sqrt(Math.Pow(basis / 2.0, 2) + Math.Pow(height, 2));
//     return Math.Round(obwod, precision);
// }


/* 
Napisz program, który:

ze standardowego wejścia wczyta 4 napisy, podane w oddzielnych liniach,
przekonwertuje te napisy na liczby całkowite typu int
sprawdzi, czy z 4 liczb można wybrać dwie, których suma będzie równa sumie pozostałych dwóch liczb - wtedy wpisze yes, w przeciwnym przypadku wypisze no.
Twój program nie może zostać przerwany z powodu wyjątków, które mogą zostać zgłoszone podczas jego działania. Przechwyć je i wypisz na standardowe wyjście stosowny komunikat:

gdy zgłoszony zostanie inny wyjątek niż podane poniżej, wypisz tekst non supported exception, exit
gdy zgłoszony zostanie wyjątek FormatException wypisz tekst format exception, exit
gdy zgłoszony zostanie wyjątek ArgumentException wypisz tekst argument exception, exit
gdy zgłoszony zostanie wyjątek OverflowException wypisz tekst overflow exception, exit
*/

// namespace W_Sprawdzian
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string[] lines = new string[4];
//             for (int i = 0; i < 4; i++)
//             {
//                 lines[i] = Console.ReadLine();
//             }
//             try
//             {
//                 checked
//                 {
//                     int a = int.Parse(lines[0]);
//                     int b = int.Parse(lines[1]);
//                     int c = int.Parse(lines[2]);
//                     int d = int.Parse(lines[3]);
//                     if (a + b == c + d || a + c == b + d || a + d == b + c)
//                     {
//                         Console.WriteLine("yes");
//                     }
//                     else
//                     {
//                         Console.WriteLine("no");
//                     }
//                 }
//             }
//             catch (FormatException)
//             {
//                 Console.WriteLine("format exception, exit");
//             }
//             catch (ArgumentException)
//             {
//                 Console.WriteLine("argument exception, exit");
//             }
//             catch (OverflowException)
//             {
//                 Console.WriteLine("overflow exception, exit");
//             }
//             catch (Exception)
//             {
//                 Console.WriteLine("non supported exception, exit");
//             }
//         }
//     }
// }

/*
Dane są dwie niepuste tablice liczb całkowitych int[] a oraz int[] b.

Napisz procedurę o sygnaturze

public static void Print(int[] a, int[] b)
wypisującą na standardowe wyjście, w porządku malejącym, te indeksy i, dla których wartości a[i] oraz b[i] są równe.

Tablice indeksowane są od 0.
Liczby wypisz w jednej linii, oddzielając je pojedynczą spacją.
W przypadku braku liczb spełniających warunki zadania wypisz słowo empty.
⚠️ Rozwiąż zadanie wykorzystując metody przeglądania tablic. Zabronione jest używanie kolekcji oraz technologii LINQ.
*/
static void Print(int[] a, int[] b)
{
    bool empty = true;
    for (int i = a.Length - 1; i >= 0; i--)
    {
        if (a[i] == b[i])
        {
            Console.Write(i + " ");
            empty = false;
        }
    }
    if (empty)
    {
        Console.WriteLine("empty");
    }
    else
    {

        Console.WriteLine();
    }
}

int[] a = new int[] {-2, -1, 0, 1, 4};
int[] b = new int[] {-2, -1, 0, 1, 4, 5, 6};
Print(a, b);