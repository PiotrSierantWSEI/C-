using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        const int MAX_VALUE = 1_000_000;

        /*
        R - promień podstawy stożka
        L - odległość między wierzchołkiem a środkiem podstawy
        h - wysokość stożka
        V - objętość stożka

        h = sqrt(L^2 - R^2)
        V = π * R^2 * h / 3
        */

        try
        {
            if (input == null || input.Length != 2)
            {
                Console.WriteLine("obiekt nie istnieje");
                return;
            }

            if (!int.TryParse(input[0], out int R) || !int.TryParse(input[1], out int L))
            {
                Console.WriteLine("obiekt nie istnieje");
                return;
            }

            if (R < 0 || L < 0)
            {
                Console.WriteLine("ujemny argument");
                return;
            }

            if (R > MAX_VALUE || L > MAX_VALUE)
            {
                Console.WriteLine("obiekt nie istnieje");
                return;
            }

            if (L < R)
            {
                Console.WriteLine("obiekt nie istnieje");
                return;
            }

            if (R == 0 || L == 0 || L == R)
            {
                Console.WriteLine("0 0");
                return;
            }

            checked
            {
                if ((long)L * L < (long)R * R)
                {
                    Console.WriteLine("obiekt nie istnieje");
                    return;
                }
            }

            decimal h;
            decimal V;

            checked
            {
                h = (decimal)Math.Sqrt((long)L * L - (long)R * R);
                V = (decimal)Math.PI * R * R * h / 3;
            }

            if(h == 0 || V == 0)
            {
                Console.WriteLine("0 0");
                return;
            }

            decimal V_floor = Math.Floor(V);
            decimal V_ceil = Math.Ceiling(V);

            Console.WriteLine($"{V_floor} {V_ceil}");
        }
        catch (OverflowException)
        {
            Console.WriteLine("obiekt nie istnieje");
        }
        catch (Exception)
        {
            Console.WriteLine($"obiekt nie istnieje");
        }
    }
}
