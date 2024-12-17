// using System;

// namespace FlowChart
// {
//     class Program
//     {
//         static void Main()
//         {
//             string[] input = Console.ReadLine().Split(' ');
// int x = int.Parse(input[0]);
// int y = int.Parse(input[1]);
// int z = int.Parse(input[2]);

//             Start:
//             if (x > 0)
//             {
//                 if (y > 0)
//                 {
//                     x--;
//                     y--;
//                     Console.Write("C");
//                     goto Start;
//                 }
//                 else
//                 {
//                     Console.Write("D");
//                     goto End;
//                 }
//             }

//             if(x <= 0) {
//                 Console.Write("E");
//                 Console.Write("G");
//                 Console.WriteLine();
//                 return;
//             }

//             End:
//             if (z > 0)
//             {
//                 Console.WriteLine();
//                 return;
//             } else {
//                 Console.WriteLine("G");
//             }
//             Console.WriteLine();
//         }
//     }
// }


using System;

namespace FlowChart
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            int z = int.Parse(input[2]);

            bool endReached = false;

            // Główna pętla, która powtarza kroki aż osiągnie "End"
            // while (!endReached)
            // {
            //     if (x > 0)
            //     {
            //         if (y > 0)
            //         {
            //             Console.Write("C");
            //             x--;
            //             y--;
            //         }
            //         else
            //         {
            //             Console.Write("D");
            //             endReached = true;
            //         }
            //     }
            //     else
            //     {
            //         Console.Write("E");
            //         endReached = true;
            //     }
            // }

            for (; !endReached;)
            {
                if (x > 0)
                {
                    if (y > 0)
                    {
                        Console.Write("C");
                        x--;
                        y--;
                    }
                    else
                    {
                        Console.Write("D");
                        endReached = true;
                    }
                }
                else
                {
                    Console.Write("E");
                    endReached = true;
                }
            }

            if(x <= 0) {
                Console.Write("G");
                Console.WriteLine();
                return;
            }

            if (z > 0)
            {
                Console.WriteLine();
                return;
            }
            else
            {
                Console.WriteLine("G");
            }
            Console.WriteLine();
        }
    }
}

// 1 2 3
// CEG
// -2 0 2
// EG
// 1 -1 2
// D
// 2 2 0
// CCEG

// 1 2 3 CEG // CE
// -2 0 2 EG // E