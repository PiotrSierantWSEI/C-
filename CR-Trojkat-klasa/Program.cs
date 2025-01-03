using System;

namespace CR_Trojkat_klasa
{
    class Program
    {
        static void Main(string[] args)
        {
            // ImmutableTriangle();
            // MutableTriangle();
           
           int[] variables = LoadTriangleSides();

            TrojkatMutable trojkat3 = new TrojkatMutable(variables[0], variables[1], variables[2]);
            trojkat3.C = 6;
            Console.WriteLine(trojkat3);

            // Program prosi o zmianę długości boku a (analogicznie dla b oraz c).
            int newSideA = ChangeSide("A");
            // int newSideB = ChangeSide("B");
            // int newSideC = ChangeSide("C");

            trojkat3.A = newSideA;
            // trojkat3.B = newSideB;
            // trojkat3.C = newSideC;
            // Console.WriteLine(trojkat3);

            try {
                int scale = AmountOfScale();
                trojkat3.ScaleTriangle(scale);
                Console.WriteLine(trojkat3);
            } catch (ArgumentOutOfRangeException e) {
                Console.WriteLine(e.Message);
            }
        }

        public static int AmountOfScale()
        {
            Console.Write("Podaj skalę o którą zmienimy trójkąt: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int scale) || scale <= 0)
            {
                Console.WriteLine("Niepoprawna wartość. Podaj dodatnią liczbę całkowitą.");
                return AmountOfScale();
            }
            else
            {
                Console.WriteLine($"Trójkąt powiększony o {scale}.");
                return scale;
            }
        }
       
        public static int ChangeSide(string side)
        {
            Console.Write($"Podaj nową długość boku {side}: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int newSide) || newSide <= 0)
            {
                Console.WriteLine("Niepoprawna wartość. Podaj dodatnią liczbę całkowitą.");
                return ChangeSide(side);
            }
            else
            {
                Console.WriteLine($"Nowa długość boku {side}: {newSide}");
                return newSide;
            }
        }

        // public static void MutableTriangle() 
        // {
            
        // }

        public static void ImmutableTriangle()
        {
            try
            {
                int[] variables = LoadTriangleSides();

                TrojkatImmutable trojkat = new TrojkatImmutable(variables[0], variables[1], variables[2]);
                Console.WriteLine(trojkat);
                // TrojkatImmutable trojkat2 = new TrojkatImmutable();
                // Console.WriteLine(trojkat2);
                // Console.WriteLine(trojkat2.C);
                // // trojkat2.C = 5; // immutable 
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }

        public static int AskForTriangleSide(string question)
        {
            Console.Write($"{question}: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int side) || side <= 0)
            {
                Console.WriteLine("Niepoprawna wartość. Podaj dodatnią liczbę całkowitą.");
                return AskForTriangleSide(question);
            }
            return side;
        }

        public static int[] LoadTriangleSides()
        {
            Console.WriteLine("===============Podaj długości boków trójkąta===============");
            int a = AskForTriangleSide("Podaj długość boku a");
            int b = AskForTriangleSide("Podaj długość boku b");
            int c = AskForTriangleSide("Podaj długość boku c");
            return [a, b, c];
        }
    }
}