using System;

namespace CR_tablice_2D_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Podaj liczby N1 i M1 oddzielone spacją: ");
            string[] input = Console.ReadLine().Split(" ");
            int n1 = int.Parse(input[0]);
            int m1 = int.Parse(input[1]);

            int[,] array = new int[n1, m1];

            // Console.Write("Podaj liczby oddzielone spacją: ");
            string[] numbers = Console.ReadLine().Split(" ");
            int index = 0;
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m1; j++)
                {
                    array[i, j] = int.Parse(numbers[index++]);
                }
            }
            // PrintMatrix(array);

            // Console.Write("Podaj liczby N2 i M2 oddzielone spacją: ");
            string[] input2 = Console.ReadLine().Split(" ");
            int n2 = int.Parse(input2[0]);
            int m2 = int.Parse(input2[1]);

            int[,] array2 = new int[n2, m2];

            // Console.Write("Podaj liczby oddzielone spacją: ");
            string[] numbers2 = Console.ReadLine().Split(" ");
            index = 0;
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    array2[i, j] = int.Parse(numbers2[index++]);
                }
            }

            // PrintMatrix(array2);
            if(m1 != n2)
            {
                Console.WriteLine("impossible");
                return;
            }

            // Mnożenie macierzy
            int[,] result = new int[n1, m2];
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    for (int k = 0; k < m1; k++)
                    {
                        result[i, j] += array[i, k] * array2[k, j];
                    }
                }
            }

            PrintMatrix(result);
        }

        static void PrintMatrix(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
