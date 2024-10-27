// part two
// int a = 15;
// int b = 7;

// int i = 0;
// int r = a;

// do {
//     r = r -b;
//     i = i + 1;
// } while (r > 0);

// Console.WriteLine($"{i}, {r}");

// part 3
// int k = 1;
// int i = 7;

// while(i < 3) {
//     k = k++;
//     i++;
// }

// Console.WriteLine($"{k}, {i}");

// part 4
// n

// int n = 8;
// for(int i = 1; i <= 5; i++) {
//     for(int j = 1; j <=8; j++) {
//         if(i !=j) {
//             n--;
//         }
//     }
// }

// Console.WriteLine(n);

// int i = 3;
// int n = 7;

// while (!(i > 4)) 
// {
//   n += i;
//   i++;
// }

// Console.WriteLine(n);

using System;

class Program
{
    public static void Main()
    {
        int i = 2;
        bool number = int.TryParse(Console.ReadLine(), out int n);
        if (!number)
        {
            Console.WriteLine("Błędne dane");
            return;
        }

        while (true)
        {
            if(i >= n) {
                Console.WriteLine("TAK");
                break;
            }

            if(n % i == 0) {
                Console.WriteLine("NIE");
                break;
            }

            i++;
        }
    }
}