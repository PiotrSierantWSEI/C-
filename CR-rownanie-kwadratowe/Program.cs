class Program
{
    public static void QuadraticEquation(int a, int b, int c)
    {
        if (a == 0 && b == 0 && c == 0)
        {
            Console.WriteLine("infinity");
            return;
        }

        if (a == 0 && b == 0)
        {
            Console.WriteLine("empty");
            return;
        }


        double aDouble = (double)a;
        double bDouble = (double)b;
        double cDouble = (double)c;

        if (a == 0)
        {
            double x = -cDouble / bDouble;
            double roundedX = Math.Round(x, 2);
            string result = roundedX.ToString("F2");
            Console.WriteLine($"x={result}");
            return;
        }

        double delta = bDouble * bDouble - 4 * aDouble * cDouble;

        if (delta < 0)
        {
            Console.WriteLine("empty");
            return;
        }

        if (delta == 0)
        {
            double x = -bDouble / (2 * aDouble);
            double roundedX = Math.Round(x, 2);
            string result = roundedX.ToString("F2");
            Console.WriteLine($"x={result}");
            return;
        }

        double x1 = (-bDouble - Math.Sqrt(delta)) / (2 * aDouble);
        double x2 = (-bDouble + Math.Sqrt(delta)) / (2 * aDouble);

        double roundedX1 = Math.Round(x1, 2);
        double roundedX2 = Math.Round(x2, 2);

        string result1 = roundedX1.ToString("F2");
        string result2 = roundedX2.ToString("F2");

        if (x1 < x2)
        {
            Console.WriteLine($"x1={result1}");
            Console.WriteLine($"x2={result2}");
        }
        else
        {
            Console.WriteLine($"x1={result2}");
            Console.WriteLine($"x2={result1}");
        }
    }
}
