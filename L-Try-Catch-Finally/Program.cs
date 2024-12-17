// // // double float1 = 3000.0;
// // // double float2 = 0.0;
// // // int number1 = 3000;
// // // int number2 = 0;

// // // try {
// // //     Console.WriteLine(float1 / float2);
// // //     Console.WriteLine(number1 / number2);
// // // }
// // // catch {
// // //       Console.WriteLine("An exception has been caught");
// // // }
// // // Console.WriteLine("Exit program");

// // // try
// // // {
// // //     Process1();
// // // }
// // // catch
// // // {
// // //     Console.WriteLine("An exception has occurred");
// // // }

// // // Console.WriteLine("Exit program");

// // // static void Process1()
// // // {
// // //     try
// // //     {
// // //         WriteMessage();
// // //     }
// // //     catch (DivideByZeroException ex)
// // //     {
// // //         Console.WriteLine($"Exception caught in Process1: {ex.Message}");
// // //     }
// // // }

// // // static void WriteMessage()
// // // {
// // //     double float1 = 3000.0;
// // //     double float2 = 0.0;
// // //     int number1 = 3000;
// // //     int number2 = 0;
// // //     byte smallNumber;

// // //     try
// // //     {
// // //         Console.WriteLine(float1 / float2);
// // //         Console.WriteLine(number1 / number2);
// // //     }
// // //     catch (DivideByZeroException ex)
// // //     {
// // //         Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
// // //     }
// // //     checked
// // //     {
// // //         smallNumber = (byte)number1;
// // //     }
// // // }


// // checked
// // {
// //     try
// //     {
// //         int num1 = int.MaxValue;
// //         int num2 = int.MaxValue;
// //         int result = num1 + num2;
// //         Console.WriteLine("Result: " + result);
// //     }
// //     catch (OverflowException ex)
// //     {
// //         Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
// //     }
// // }
// // try
// // {
// //     string str = null;
// //     int length = str.Length;
// //     Console.WriteLine("String Length: " + length);

// // }
// // catch (NullReferenceException ex)
// // {
// //     Console.WriteLine("Error: The reference is null." + ex.Message);
// // }

// // try
// // {
// //     int[] numbers = new int[5];
// //     numbers[5] = 10;
// //     Console.WriteLine("Number at index 5: " + numbers[5]);

// // }
// // catch (IndexOutOfRangeException ex)
// // {
// //     Console.WriteLine("Error: Index out of range." + ex.Message);
// // }

// // try
// // {
// //     int num3 = 2147483647;
// //     int num4 = 0;
// //     int result2 = num3 / num4;
// //     Console.WriteLine("Result: " + result2);

// // }
// // catch (DivideByZeroException ex)
// // {
// //     Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
// // }

// // Console.WriteLine("Exiting program.");

// // // Error: The number is too large to be represented as an integer. Arithmetic operation resulted in an overflow.
// // // Error: The reference is null. Object reference not set to an instance of an object.
// // // Error: Index out of range. Index was outside the bounds of the array.
// // // Error: Cannot divide by zero. Attempted to divide by zero.
// // // Exiting program.

// // string[][] userEnteredValues = new string[][]
// // {
// //         new string[] { "1", "two", "3"},
// //         new string[] { "0", "1", "2"}
// // };

// // foreach (string[] userEntries in userEnteredValues)
// // {
// //     try
// //     {
// //         BusinessProcess1(userEntries);
// //     }
// //     catch (Exception ex)
// //     {
// //         if (ex.StackTrace.Contains("BusinessProcess1") && (ex is FormatException))
// //         {
// //             Console.WriteLine(ex.Message);
// //         }
// //     }
// // }

// // static void BusinessProcess1(string[] userEntries)
// // {
// //     int valueEntered;

// //     foreach (string userValue in userEntries)
// //     {
// //         try
// //         {
// //             valueEntered = int.Parse(userValue);

// //             // completes required calculations based on userValue
// //             // ...
// //         }
// //         catch (FormatException)
// //         {
// //             FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
// //             throw invalidFormatException;
// //         }
// //     }
// // }

// // Prompt the user for the lower and upper bounds
// // Console.Write("Enter the lower bound: ");
// // int lowerBound = int.Parse(Console.ReadLine());

// // Console.Write("Enter the upper bound: ");
// // int upperBound = int.Parse(Console.ReadLine());

// // decimal averageValue = 0;

// // // Calculate the sum of the even numbers between the bounds
// // averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

// // // Display the value returned by AverageOfEvenNumbers in the console
// // Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

// // // Wait for user input
// // Console.ReadLine();

// // static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
// // {
// //     int sum = 0;
// //     int count = 0;
// //     decimal average = 0;

// //     for (int i = lowerBound; i <= upperBound; i++)
// //     {
// //         if (i % 2 == 0)
// //         {
// //             sum += i;
// //             count++;
// //         }
// //     }

// //     average = (decimal)sum / count;

// //     return average;
// // }

// string[][] userEnteredValues = new string[][]
// {
//             new string[] { "1", "2", "3"},
//             new string[] { "1", "two", "3"},
//             new string[] { "0", "1", "2"}
// };

// try
// {
//     Workflow1(userEnteredValues);
//     Console.WriteLine("'Workflow1' completed successfully.");

// }
// catch (DivideByZeroException ex)
// {
//     Console.WriteLine("An error occurred during 'Workflow1'.");
//     Console.WriteLine(ex.Message);
// }

// static void Workflow1(string[][] userEnteredValues)
// {
//     foreach (string[] userEntries in userEnteredValues)
//     {
//         try
//         {
//             Process1(userEntries);
//             Console.WriteLine("'Process1' completed successfully.");
//             Console.WriteLine();
//         }
//         catch (FormatException ex)
//         {
//             Console.WriteLine("'Process1' encountered an issue, process aborted.");
//             Console.WriteLine(ex.Message);
//             Console.WriteLine();
//         }
//     }
// }

// static void Process1(String[] userEntries)
// {
//     int valueEntered;

//     foreach (string userValue in userEntries)
//     {
//         bool integerFormat = int.TryParse(userValue, out valueEntered);

//         if (integerFormat == true)
//         {
//             if (valueEntered != 0)
//             {
//                 checked
//                 {
//                     int calculatedValue = 4 / valueEntered;
//                 }
//             }
//             else
//             {
//                 throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
//             }
//         }
//         else
//         {
//             throw new FormatException("Invalid data. User input values must be valid integers.");
//         }
//     }
// }

/*
This application manages transactions at a store check-out line. The
check-out line has a cash register, and the register has a cash till
that is prepared with a number of bills each morning. The till includes
bills of four denominations: $1, $5, $10, and $20. The till is used
to provide the customer with change during the transaction. The item 
cost is a randomly generated number between 2 and 49. The customer 
offers payment based on an algorithm that determines a number of bills
in each denomination. 

Each day, the cash till is loaded at the start of the day. As transactions
occur, the cash till is managed in a method named MakeChange (customer 
payments go in and the change returned to the customer comes out). A 
separate "safety check" calculation that's used to verify the amount of
money in the till is performed in the "main program". This safety check
is used to ensure that logic in the MakeChange method is working as 
expected.
*/

// string? readResult = null;
// bool useTestData = true;

// Console.Clear();

// int[] cashTill = new int[] { 0, 0, 0, 0 };
// int registerCheckTillTotal = 0;

// // registerDailyStartingCash: $1 x 50, $5 x 20, $10 x 10, $20 x 5 => ($350 total)
// int[,] registerDailyStartingCash = new int[,] { { 1, 50 }, { 5, 20 }, { 10, 10 }, { 20, 5 } };

// int[] testData = new int[] { 6, 10, 17, 20, 31, 36, 40, 41 };
// int testCounter = 0;

// LoadTillEachMorning(registerDailyStartingCash, cashTill);

// registerCheckTillTotal = registerDailyStartingCash[0, 0] * registerDailyStartingCash[0, 1] + registerDailyStartingCash[1, 0] * registerDailyStartingCash[1, 1] + registerDailyStartingCash[2, 0] * registerDailyStartingCash[2, 1] + registerDailyStartingCash[3, 0] * registerDailyStartingCash[3, 1];

// // display the number of bills of each denomination currently in the till
// LogTillStatus(cashTill);

// // display a message showing the amount of cash in the till
// Console.WriteLine(TillAmountSummary(cashTill));

// // display the expected registerDailyStartingCash total
// Console.WriteLine($"Expected till value: {registerCheckTillTotal}\n\r");

// var valueGenerator = new Random((int)DateTime.Now.Ticks);

// int transactions = 10;

// if (useTestData)
// {
//     transactions = testData.Length;
// }

// while (transactions > 0)
// {
//     transactions -= 1;
//     int itemCost = valueGenerator.Next(2, 20);

//     if (useTestData)
//     {
//         itemCost = testData[testCounter];
//         testCounter += 1;
//     }

//     int paymentOnes = itemCost % 2;                 // value is 1 when itemCost is odd, value is 0 when itemCost is even
//     int paymentFives = (itemCost % 10 > 7) ? 1 : 0; // value is 1 when itemCost ends with 8 or 9, otherwise value is 0
//     int paymentTens = (itemCost % 20 > 13) ? 1 : 0; // value is 1 when 13 < itemCost < 20 OR 33 < itemCost < 40, otherwise value is 0
//     int paymentTwenties = (itemCost < 20) ? 1 : 2;  // value is 1 when itemCost < 20, otherwise value is 2

//     // display messages describing the current transaction
//     Console.WriteLine($"Customer is making a ${itemCost} purchase");
//     Console.WriteLine($"\t Using {paymentTwenties} twenty dollar bills");
//     Console.WriteLine($"\t Using {paymentTens} ten dollar bills");
//     Console.WriteLine($"\t Using {paymentFives} five dollar bills");
//     Console.WriteLine($"\t Using {paymentOnes} one dollar bills");

//     // MakeChange manages the transaction and updates the till 
//     string transactionMessage = MakeChange(itemCost, cashTill, paymentTwenties, paymentTens, paymentFives, paymentOnes);

//     // Backup Calculation - each transaction adds current "itemCost" to the till
//     if (transactionMessage == "transaction succeeded")
//     {
//         Console.WriteLine($"Transaction successfully completed.");
//         registerCheckTillTotal += itemCost;
//     }
//     else
//     {
//         Console.WriteLine($"Transaction unsuccessful: {transactionMessage}");
//     }

//     Console.WriteLine(TillAmountSummary(cashTill));
//     Console.WriteLine($"Expected till value: {registerCheckTillTotal}\n\r");
//     Console.WriteLine();
// }

// Console.WriteLine("Press the Enter key to exit");
// do
// {
//     readResult = Console.ReadLine();

// } while (readResult == null);