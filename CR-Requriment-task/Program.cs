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

            
            long lastDigitOfN = n % 10;
            long[] lastDigits = new long[4];
            lastDigits[0] = lastDigitOfN;
            for (int i = 1; i < 4; i++) {
                lastDigits[i] = (lastDigits[i - 1] * lastDigitOfN) % 10;
            }
            return (int)lastDigits[(m - 1) % 4];

            // int[] lastDigits = new int[4] { n % 10, (n * n) % 10, (n * n * n) % 10, (n * n * n * n) % 10 };
            // return lastDigits[(m - 1) % 4];
        }
    }
}