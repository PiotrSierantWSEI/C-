/*

Dane wejściowe	Wynik
a = new int[] {-2, -1, 0, 1, 4};
b = new int[] {-3, -2, -1, 1, 2, 3};
0 4

a = new int[] {-2, -1, 0, 1, 4};
b = new int[] {-2, -1, 0, 1, 4, 5, 6};
empty

wypisującą na standardowe wyjście, w porządku rosnącym, te liczby z tablicy a, których nie ma w tablicy b.

Nie wypisuj duplikatów.
Liczby wypisz w jednej linii, oddzielając je pojedynczą spacją.
W przypadku braku liczb spełniających warunki zadania wypisz słowo empty. 

*/

using System.Collections.Generic;
using System;

int[] a = [ -2, -1, 0, 1, 4];
int[] b = [ -3, -2, -1, 1, 2, 3];

int[] c = [ 2, -1, 0, 1, 4];
int[] d = [ 2, -1, 0, 1, 4, 5, 6];

int[] e = [ 0, 1, 1, 2, 3, 3, 3 ];
int[] f = [ 0, 2, 2, 3, 4 ];

Print(a, b);
Print(c, d);
Print(e, f);

// string resultTest = "1 4 5 ";              
// Console.WriteLine($"{resultTest.Contains("1 ")}");

static void Print(int[] a, int[] b)
{
    string result = "";
    for (int i = 0; i < a.Length; i++)
    {
        for (int j = 0; j < b.Length; j++)
        {
            if (a[i] == b[j])
            {
                break;
            }
            if (j == b.Length - 1)
            {
                if(!result.Contains($"{a[i]} ")) {
                    result += a[i] + " ";
                };
            }
        }
    }
    Console.WriteLine(result.Length == 0 ? "empty" : result);
}
