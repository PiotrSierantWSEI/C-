using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        const int MAX_VALUE = 1_000_000;
        try
        {
            if (input.Length != 2)
            {
                Console.WriteLine("obiekt nie istnieje");
                return;
            }

            int R, L;
            checked
            {
                if (!int.TryParse(input[0], out R) || !int.TryParse(input[1], out L))
                {
                    Console.WriteLine("obiekt nie istnieje");
                    return;
                }

                if (R > MAX_VALUE || L > MAX_VALUE)
                {
                    Console.WriteLine("obiekt nie istnieje");
                    return;
                }

                if (R < 0 || L < 0)
                {
                    Console.WriteLine("ujemny argument");
                    return;
                }

                if (L < R)
                {
                    Console.WriteLine("obiekt nie istnieje");
                    return;
                }

                if (R == 0 || L == 0)
                {
                    Console.WriteLine("0 0");
                    return;
                }

                decimal L2 = (decimal)L * L;
                decimal R2 = (decimal)R * R;
                if (L2 < R2) 
                {
                    Console.WriteLine("obiekt nie istnieje");
                    return;
                }

                decimal h = (decimal)Math.Sqrt((double)(L2 - R2));
                decimal V = (decimal)Math.PI * R2 * h / 3.0M;

                int lowerBound = (int)Math.Floor(V);
                int upperBound = (int)Math.Ceiling(V);

                Console.WriteLine($"{lowerBound} {upperBound}");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("obiekt nie istnieje");
        }
    }
}