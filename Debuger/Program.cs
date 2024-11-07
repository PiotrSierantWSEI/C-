// /* 
// This code uses a names array and corresponding methods to display
// greeting messages
// */

// string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

// string messageText = "";

// foreach (string name in names)
// {
//     if (name == "Sophia")
//         messageText = SophiaMessage();
//     else if (name == "Andrew")
//         messageText = AndrewMessage();
//     else if (name == "AllGreetings")
//         messageText = SophiaMessage();
//         messageText = messageText + "\n\r" + AndrewMessage();

//     Console.WriteLine(messageText + "\n\r");
// }

// bool pauseCode = true;
// while (pauseCode == true);

// static string SophiaMessage()
// {
//     return "Hello, my name is Sophia.";
// }

// static string AndrewMessage()
// {
//     return "Hi, my name is Andrew. Good to meet you.";
// }

// int productCount = 2000;
// string[,] products = new string[productCount, 2];

// LoadProducts(products, productCount);

// for (int i = 0; i < productCount; i++)
// {
//     string result;
//     result = Process1(products, i);

//     if (result != "obsolete")
//     {
//         result = Process2(products, i);
//     }
// }

// bool pauseCode = true;
// while (pauseCode == true) ;

// static void LoadProducts(string[,] products, int productCount)
// {
//     Random rand = new Random();

//     for (int i = 0; i < productCount; i++)
//     {
//         int num1 = rand.Next(1, 10000) + 10000;
//         int num2 = rand.Next(1, 101);

//         string prodID = num1.ToString();

//         if (num2 < 91)
//         {
//             products[i, 1] = "existing";
//         }
//         else if (num2 == 91)
//         {
//             products[i, 1] = "new";
//             prodID = prodID + "-n";
//         }
//         else
//         {
//             products[i, 1] = "obsolete";
//             prodID = prodID + "-0";
//         }

//         products[i, 0] = prodID;
//     }
// }

/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
// int x = 5;

// ChangeValue(x);

// Console.WriteLine(x);

// void ChangeValue(int value) 
// {
//     value = 10;
// }

int x = 5;
x = ChangeValue(x);
Console.WriteLine(x);

int ChangeValue(int value) 
{
    value = 10;
    return value;
}