// int[] schedule = [800, 1200, 1600, 2000];

// DisplayAdjustedTimes(schedule, 6, -6);

// void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
// {
//     int diff = 0;
//     if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//     {
//         Console.WriteLine("Invalid GMT");
//         return;
//     }
//     else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//     {
//         diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     }
//     else
//     {
//         diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     }

//     for (int i = 0; i < times.Length; i++)
//     {
//         int newTime = ((times[i] + diff)) % 2400;
//         Console.WriteLine($"{times[i]} -> {newTime}");
//     }
// }

// string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

// DisplayStudents(students);
// DisplayStudents(new string[] { "Robert", "Vanya" });

// void DisplayStudents(string[] students)
// {
//     foreach (string student in students)
//     {
//         Console.Write($"{student}, ");
//     }
//     Console.WriteLine();
// }

// double pi = 3.14159;
// PrintCircleArea(12);
// PrintCircleCircumference(50);
// PrintCircleInfo(12);
// PrintCircleInfo(24);

// void PrintCircleArea(int radius)
// {
//     // double pi = 3.14159;
//     double area = pi * (radius * radius);
//     Console.WriteLine($"Area = {area}");
// }

// void PrintCircleCircumference(int radius)
// {
//     // double pi = 3.14159;
//     double circumference = 2 * pi * radius;
//     Console.WriteLine($"Circumference = {circumference}");
// }

// void PrintCircleInfo(int radius)
// {
//     Console.WriteLine($"Circle with radius {radius}");
//     PrintCircleArea(radius);
//     PrintCircleCircumference(radius);
// }

// int a = 3;
// int b = 4;
// int c = 0;

// Multiply(a, b, c);
// Console.WriteLine($"global statement: {a} x {b} = {c}");

// void Multiply(int a, int b, int c)
// {
//     c = a * b;
//     Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
// }

// int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//     {
//         Console.Write($"{item}, ");
//     }
//     Console.WriteLine();
// }

// void Clear(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = 0;
//     }
// }

// string status = "Healthy";

// Console.WriteLine($"Start: {status}");
// // SetHealth(status, false);
// SetHealth(false);
// Console.WriteLine($"End: {status}");

// // void SetHealth(string status, bool isHealthy) 
// // {
// //     status = (isHealthy ? "Healthy" : "Unhealthy");
// //     Console.WriteLine($"Middle: {status}");
// // }

// void SetHealth(bool isHealthy)
// {
//     status = (isHealthy ? "Healthy" : "Unhealthy");
//     Console.WriteLine($"Middle: {status}");
// }

// string[] guestList = { "Jenna", "Ayesha", "Carlos", "Viktor" };
// string[] rsvps = new string[10];

// int count = 0;

// // RSVP("Rebecca", 1, "none", true);
// // RSVP("Nadia", 2, "Nuts", true);
// // RSVP("Linh", 2, "none", false);
// // // RSVP("Tony", 1, "Jackfruit", true);
// // RSVP("Tony", inviteOnly: true, allergies: "Jackfruit",  partySize: 1);
// // RSVP("Noor", 4, "none", false);
// // RSVP("Jonte", 2, "Stone fruit", false);
// // RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
// RSVP("Rebecca");
// RSVP("Nadia", 2, "Nuts");
// RSVP(name: "Linh", partySize: 2, inviteOnly: false);
// RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
// RSVP("Noor", 4, inviteOnly: false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();

// void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
// {
//     if (inviteOnly)
//     {
//         bool found = false;
//         foreach (string guest in guestList)
//         {
//             if (guest.Equals(name))
//             {
//                 found = true;
//                 break;
//             }
//         }
//         if (!found)
//         {
//             Console.WriteLine($"Sorry, {name} is not on the guest list");
//             return;
//         }
//     }

//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }

// void ShowRSVPs()
// {
//     Console.WriteLine("Total rsvps:");
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(rsvps[i]);
//     }
// }


// string[,] corporate =
// {
//     {"Robert", "Bavin"}, {"Simon", "Bright"},
//     {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
//     {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
// };

// string[,] external =
// {
//     {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//     {"Shay", "Lawrence"}, {"Daren", "Valdes"}
// };

// // for (int i = 0; i < corporate.GetLength(0); i++) 
// // {
// // display internal email addresses
// // }
// DisplayEmails(corporate);
// DisplayEmails(corporate, external: true);
// DisplayEmails(external, "hayworth.com", true);
// // for (int i = 0; i < external.GetLength(0); i++) 
// // {
// // display external email addresses
// // }

// void DisplayEmails(string[,] names, string domain = "contoso.com", bool external = false)
// {
//     for (int i = 0; i < names.GetLength(0); i++)
//     {
//         Console.WriteLine(
//             $"{names[i, 0]
//             .Substring(0, 2)
//             .ToLower()}{names[i, 1]
//             .ToLower()}{(external ? $"@{domain}" : "")}");
//     }
// }

// double total = 0;
// double minimumSpend = 30.00;

// double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
// double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

// for (int i = 0; i < items.Length; i++)
// {
//     total += GetDiscountedPrice(i);
// }

// total -= TotalMeetsMinimum() ? 5.00 : 0.00;

// Console.WriteLine($"Total: ${FormatDecimal(total)}");

// double GetDiscountedPrice(int itemIndex)
// {
//     // Calculate the discounted price of the item
//     return items[itemIndex] * (1 - discounts[itemIndex]);
// }

// bool TotalMeetsMinimum()
// {
//     return total >= minimumSpend;
//     // Check if the total meets the minimum
// }

// string FormatDecimal(double input)
// {
//     return input.ToString().Substring(0, 5);
//     // Format the double so only 2 decimal places are displayed
// }

// double usd = 23.73;
// int vnd = UsdToVnd(usd);

// Console.WriteLine($"${usd} USD = ${vnd} VND");
// Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

// int UsdToVnd(double usd)
// {
//     int rate = 23500;
//     return (int)(usd * rate);
// }

// double VndToUsd(int vnd)
// {
//     double rate = 23500;
//     return vnd / rate;
// }

// string input = "there are snakes at the zoo";

// Console.WriteLine(input);
// Console.WriteLine(ReverseSentence(input));

// string ReverseSentence(string input)
// {
//     string result = "";
//     string[] words = input.Split(" ");
//     foreach (string word in words)
//     {
//         result += ReverseWord(word) + " ";
//     }
//     return result.Trim();
// }

// string ReverseWord(string word)
// {
//     string result = "";
//     for (int i = word.Length - 1; i >= 0; i--)
//     {
//         result += word[i];
//     }
//     return result;
// }

// string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

// Console.WriteLine("Is it a palindrome?");
// foreach (string word in words)
// {
//     Console.WriteLine($"{word}: {IsPalindrome(word)}");
// }

// bool IsPalindrome(string word)
// {
//     int start = 0;
//     int end = word.Length - 1;

//     while (start < end)
//     {
//         if (word[start] != word[end])
//         {
//             return false;
//         }
//         start++;
//         end--;
//     }

//     return true;
// }

// // int target = 60;
// // int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
// // int[] result = TwoCoins(coins, target);

// int target = 30;
// int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
// int[,] result = TwoCoins(coins, target);

// // if (result.Length == 0)
// // {
// //     Console.WriteLine("No two coins make change");
// // }
// // else
// // {
// //     Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
// // }

// if (result.Length == 0)
// {
//     Console.WriteLine("No two coins make change");
// }
// else
// {
//     Console.WriteLine("Change found at positions:");
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         if (result[i, 0] == -1)
//         {
//             break;
//         }
//         Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
//     }
// }

// // int[] TwoCoins(int[] coins, int target)
// // {
// //     for (int curr = 0; curr < coins.Length; curr++)
// //     {
// //         for (int next = curr + 1; next < coins.Length; next++)
// //         {
// //             if (coins[curr] + coins[next] == target)
// //             {
// //                 return new int[] { curr, next };
// //             }

// //         }
// //     }
// //     return new int[0];
// // }
// int[,] TwoCoins(int[] coins, int target)
// {
//     int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
//     int count = 0;

//     for (int curr = 0; curr < coins.Length; curr++)
//     {
//         for (int next = curr + 1; next < coins.Length; next++)
//         {
//             if (coins[curr] + coins[next] == target)
//             {
//                 result[count, 0] = curr;
//                 result[count, 1] = next;
//                 count++;
//             }
//             if (count == result.GetLength(0))
//             {
//                 return result;
//             }
//         }
//     }
//     return (count == 0) ? new int[0, 0] : result;
// }


// Random random = new Random();

// Console.WriteLine("Would you like to play? (Y/N)");
// if (ShouldPlay())
// {
//     PlayGame();
// }

// bool ShouldPlay()
// {
//     string response = Console.ReadLine() ?? "";
//     return response.ToLower().Equals("y");
// }

// void PlayGame()
// {
//     var play = true;

//     while (play)
//     {
//         var target = GetTarget();
//         var roll = RollDice();

//         Console.WriteLine($"Roll a number greater than {target} to win!");
//         Console.WriteLine($"You rolled a {roll}");
//         Console.WriteLine(WinOrLose(roll, target));
//         Console.WriteLine("\nPlay again? (Y/N)");

//         play = ShouldPlay();
//     }
// }

// int GetTarget()
// {
//     return random.Next(1, 6);
// }

// int RollDice()
// {
//     return random.Next(1, 7);
// }

// string WinOrLose(int roll, int target)
// {
//     if (roll > target)
//     {
//         return "You win!";
//     }
//     return "You lose!";
// }


// string[] pettingZoo =
// {
//     "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
//     "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
//     "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
// };

// // Random random = new Random();

// // for (int i = 0; i < pettingZoo.Length; i++) 
// // {
// //     int r = random.Next(pettingZoo.Length);

// //     string temp = pettingZoo[i];
// //     pettingZoo[i] = pettingZoo[r];
// //     pettingZoo[r] = temp;
// // }

// // RandomizeAnimals();
// // string[,] group = AssignGroup();
// // Console.WriteLine("School A");
// // PrintGroup(group);
// // foreach (string animal in pettingZoo)
// // {
// //     Console.WriteLine(animal);
// // }

// PlanSchoolVisit("School A");
// PlanSchoolVisit("School B", 3);
// PlanSchoolVisit("School C", 2);

// void PlanSchoolVisit(string schoolName, int groups = 6) 
// {
//     RandomizeAnimals(); 
//     string[,] group1 = AssignGroup(groups);
//     Console.WriteLine(schoolName);
//     PrintGroup(group1);
// }

// void RandomizeAnimals()
// {
//     Random random = new Random();

//     for (int i = 0; i < pettingZoo.Length; i++)
//     {
//         int r = random.Next(i, pettingZoo.Length);

//         string temp = pettingZoo[r];
//         pettingZoo[r] = pettingZoo[i];
//         pettingZoo[i] = temp;
//     }
// }

// string[,] AssignGroup(int groups = 6) 
// {
//     string[,] result = new string[groups, pettingZoo.Length/groups];
//     int start = 0;

//     for (int i = 0; i < groups; i++) 
//     {
//         for (int j = 0; j < result.GetLength(1); j++) 
//         {
//             result[i,j] = pettingZoo[start++];
//         }
//     }

//     return result;
// }

// void PrintGroup(string[,] groups) 
// {
//     for (int i = 0; i < groups.GetLength(0); i++) 
//     {
//         Console.Write($"Group {i + 1}: ");
//         for (int j = 0; j < groups.GetLength(1); j++) 
//         {
//             Console.Write($"{groups[i,j]}  ");
//         }
//         Console.WriteLine();
//     }
// }