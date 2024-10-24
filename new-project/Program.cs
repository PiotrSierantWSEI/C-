﻿// int first = 2;
// string second = "4";
// // int result = first + second; // Error: Cannot implicitly convert type 'string' to 'int' 
// string result = first + second; 

// Console.WriteLine(result);

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

// string value = "102";
// int result = 0;

// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }

// string value = "102";
// string value = "bad";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }
// Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// if (result > 0)
//    Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// string[] values = ["12.3", "45", "ABC", "11", "DEF"];

// decimal total = 0m;
// string message = "";
// foreach (var value in values)
// {
//     Console.WriteLine($"Processing '{value}'");
//     decimal number;
//     Console.WriteLine($"{decimal.TryParse(value, out number)}");
//     if (decimal.TryParse(value, out number))
//     {
//         total += number;
//     }
//     else
//     {
//         message = message + value;
//     }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");

// string[] values = { "12,3", "45", "ABC", "11", "DEF" }; // zmienic na przecinek lub rozwiązanie poniżej

// decimal total = 0m;
// string message = "";

// foreach (var value in values)
// {
//     decimal number;
//     if (decimal.TryParse(value, out number))
//     {
//         total += number;
//     } 
//     else
//     {
//         message += value;
//     }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");

// using System;
// using System.Globalization; // Dodaj to, aby używać CultureInfo

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// decimal total = 0m;
// string message = "";

// foreach (var value in values)
// {
//     decimal number;
//     // Użycie InvariantCulture dla poprawnego parsowania liczb z kropką jako separatorem dziesiętnym
//     if (decimal.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out number))
//     {
//         total += number;
//     }
//     else
//     {
//         message += value;
//     }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");