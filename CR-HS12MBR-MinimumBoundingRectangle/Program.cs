using System;

class Program
{
    static void Main(string[] args)
    {
        Solve();
    }

    static void Solve()
    {
        int T = int.Parse(Console.ReadLine()); // liczba testów

        for (int t = 0; t < T; t++)
        {
            string[] firstLine = Console.ReadLine().Split();
            int n = int.Parse(firstLine[0]); // liczba obiektów w teście

            // Ustawienie wartości początkowych na ekstremalne
            int maxX = int.MinValue, maxY = int.MinValue;
            int minX = int.MaxValue, minY = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                char obj = input[0][0];

                if (obj == 'p') // Punkt
                {
                    int x = int.Parse(input[1]);
                    int y = int.Parse(input[2]);

                    maxX = Math.Max(maxX, x);
                    minX = Math.Min(minX, x);
                    maxY = Math.Max(maxY, y);
                    minY = Math.Min(minY, y);
                }
                else if (obj == 'c') // Koło
                {
                    int x = int.Parse(input[1]);
                    int y = int.Parse(input[2]);
                    int r = int.Parse(input[3]);

                    int left = x - r;
                    int right = x + r;
                    int bottom = y - r;
                    int top = y + r;

                    maxX = Math.Max(maxX, right);
                    minX = Math.Min(minX, left);
                    maxY = Math.Max(maxY, top);
                    minY = Math.Min(minY, bottom);
                }
                else if (obj == 'l') // Linia
                {
                    int x1 = int.Parse(input[1]);
                    int y1 = int.Parse(input[2]);
                    int x2 = int.Parse(input[3]);
                    int y2 = int.Parse(input[4]);

                    maxX = Math.Max(maxX, Math.Max(x1, x2));
                    minX = Math.Min(minX, Math.Min(x1, x2));
                    maxY = Math.Max(maxY, Math.Max(y1, y2));
                    minY = Math.Min(minY, Math.Min(y1, y2));
                }
            }

            // Wypisanie wyniku dla danego przypadku testowego
            Console.WriteLine($"{minX} {minY} {maxX} {maxY}");
        }
    }
}
