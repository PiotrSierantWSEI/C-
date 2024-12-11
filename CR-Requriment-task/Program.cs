using System;
namespace CR_Requriment_task {
    class Program {
        static void Main() {
            string[] input = Console.ReadLine().Split(" ");
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            Console.WriteLine(LastDigit(n, m));
        }

        static int LastDigit(int n, int m) {
            if (m == 0) return 1;
            if (n == 0) return 0;

            int[] lastDigits = new int[4] { n % 10, (n * n) % 10, (n * n * n) % 10, (n * n * n * n) % 10 };
            return lastDigits[(m - 1) % 4];
        }
    }
}