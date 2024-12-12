using System;
using System.Linq;

class JaggedArrayUtils
{
    static void Main(string[] args)
    {
        char[][] jagged = ReadJaggedArrayFromStdInput();
        PrintJaggedArrayToStdOutput(jagged);
        jagged = TransposeJaggedArray(jagged);
        Console.WriteLine();
        PrintJaggedArrayToStdOutput(jagged);
    }

    // Wczytuje tablicę postrzępioną ze standardowego wejścia
    public static char[][] ReadJaggedArrayFromStdInput()
    {
        // Wczytanie liczby wierszy
        int rowCount = int.Parse(Console.ReadLine());

        // Utworzenie tablicy postrzępionej
        char[][] jaggedArray = new char[rowCount][];

        // Wczytanie wierszy tablicy
        for (int i = 0; i < rowCount; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            jaggedArray[i] = new char[input.Length];
            for (int j = 0; j < input.Length; j++)
            {
                jaggedArray[i][j] = input[j][0];
            }
        }

        return jaggedArray;
    }

    // Transponuje tablicę postrzępioną
    public static char[][] TransposeJaggedArray(char[][] tab)
    {
        // Znalezienie maksymalnej liczby kolumn w tablicy
        int maxCols = 0;
        for (int i = 0; i < tab.Length; i++)
        {
            if (tab[i].Length > maxCols)
            {
                maxCols = tab[i].Length;
            }
        }

        // Utworzenie nowej tablicy postrzępionej dla wyniku
        char[][] transposed = new char[maxCols][];

        for (int col = 0; col < maxCols; col++)
        {
            // Długość każdego wiersza transponowanego to liczba oryginalnych wierszy
            transposed[col] = new char[tab.Length];

            for (int row = 0; row < tab.Length; row++)
            {
                // Jeśli wiersz w oryginalnej tablicy jest za krótki, uzupełnij pustym znakiem
                transposed[col][row] = col < tab[row].Length ? tab[row][col] : ' ';
            }
        }

        return transposed;
    }

    // Wypisuje tablicę postrzępioną na standardowe wyjście
    public static void PrintJaggedArrayToStdOutput(char[][] tab)
    {
        for (int i = 0; i < tab.Length; i++)
        {
            for (int j = 0; j < tab[i].Length; j++)
            {
                Console.Write(tab[i][j]);
                if (j < tab[i].Length - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}