using System;
using System.Globalization;

// Ustawienie kultury na en-US
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

// Wczytanie danych
string input = Console.ReadLine() ?? string.Empty;
string[] parts = input.Split(["; "], StringSplitOptions.None);

// Parsowanie boków trójkąta
if (parts.Length != 3 ||
    !double.TryParse(parts[0], out double a) ||
    !double.TryParse(parts[1], out double b) ||
    !double.TryParse(parts[2], out double c))
{
    Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
    return;
}

// Walidacja długości boków
if (a <= 0 || b <= 0 || c <= 0)
{
    Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
    return;
}

// Walidacja trójkąta
if (a + b < c || a + c < b || b + c < a)
{
    Console.WriteLine("Błędne dane. Trójkąta nie można zbudować!");
    return;
}

// Obliczanie obwodu
double perimeter = a + b + c;

// Obliczanie pola trójkąta za pomocą wzoru Herona
double s = perimeter / 2; // Półobwód
double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

// Ustalanie typu trójkąta
string triangleType = "";


// Sprawdzanie, czy trójkąt jest prostokątny, ostrokątny czy rozwartokątny
double a2 = a * a;
double b2 = b * b;
double c2 = c * c;

if (Math.Abs(a2 + b2 - c2) < 1e-10 || Math.Abs(a2 + c2 - b2) < 1e-10 || Math.Abs(b2 + c2 - a2) < 1e-10)
{
    triangleType += "prostokątny";
}
else if (a2 + b2 > c2 && a2 + c2 > b2 && b2 + c2 > a2)
{
    triangleType += "ostrokątny";

    if (a == b && b == c)
    {
        triangleType += "\ntrójkąt równoboczny";
    }
    else if (a == b || a == c || b == c)
    {
        triangleType += "\ntrójkąt równoramienny";
    }
}
else
{
    triangleType += "rozwartokątny";
    if (a == b || a == c || b == c)
    {
        triangleType += "\ntrójkąt równoramienny";
    }
}

// Wypisywanie wyników
Console.WriteLine($"obwód = {perimeter:F2}");
Console.WriteLine($"pole = {area:F2}");
Console.WriteLine($"trójkąt jest {triangleType}");
