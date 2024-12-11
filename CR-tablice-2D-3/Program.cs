using System;
using System.Collections.Generic;
using System.Linq;


// using System;
// using System.Collections.Generic;
// using System.Linq;
// namespace CR_tablice_2D_3
// {
//     class Program
//     {
//     static void Main(string[] args)
//     {
//         List<int[]> rows = new List<int[]>();

//         string line;
//         while ((line = Console.ReadLine()) != null && line.Trim() != "")
//         {
//             int[] row = line.Split(' ').Select(int.Parse).ToArray();
//             rows.Add(row);
//         }

//         if (rows.Count == 0)
//         {
//             Console.WriteLine("Brak danych");
//             return;
//         }

//         int columnCount = rows[0].Length;

//         int[] columnSums = new int[columnCount];

//         foreach (var row in rows)
//         {
//             for (int j = 0; j < row.Length; j++)
//             {
//                 columnSums[j] += row[j];
//             }
//         }

//         int maxSum = columnSums.Max();
//         int minIndex = Array.IndexOf(columnSums, maxSum);

//         Console.WriteLine(minIndex);
//         }
//     }
// }

namespace CR_tablice_2D_3
{
    class Program
    {
        static void Main()
        {
            List<int[]> rows = new List<int[]>();

            // Wczytanie danych wejściowych ze standardowego wejścia
            string line;
            while ((line = Console.ReadLine()) != null && line.Trim() != "")
            {
                int[] row = line.Split(' ').Select(int.Parse).ToArray();
                rows.Add(row);
            }

            if (rows.Count == 0)
            {
                Console.WriteLine("Brak danych");
                return;
            }

            // Konwersja listy wierszy na tablicę 2D
            int rowsCount = rows.Count;
            int colsCount = rows[0].Length;
            int[,] matrix = new int[rowsCount, colsCount];

            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    matrix[i, j] = rows[i][j];
                }
            }

            // Transponowanie macierzy i obliczanie sum kolumn (wierszy transponowanej macierzy)
            int[,] transposedMatrix = MatrixTranspose(matrix);
            SumRows(transposedMatrix);
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] MatrixTranspose(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] transposed = new int[cols, rows];

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    transposed[i, j] = matrix[j, i];
                }
            }

            return transposed;
        }

        static void SumRows(int[,] matrix)
        {
            int maxSum = int.MinValue;
            int maxIndex = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxIndex = i;
                }
            }

            Console.WriteLine(maxIndex);
        }
    }
}