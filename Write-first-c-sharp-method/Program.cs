// DispayRandomNumber();

// static void DispayRandomNumber() 
// {
//     Random random = new Random();

//     for(int i = 0; i < 5; i++) {
//         Console.WriteLine(random.Next(1, 100));
//     }
// }

// using System;

// int[] times = {800, 1200, 1600, 2000};
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");

// /* Format and display medicine times */
// DisplayMedicineTimes();
// Console.WriteLine();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     AdjustTimes();
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");

// /* Format and display medicine times */
// DisplayMedicineTimes();
// Console.WriteLine();

// void DisplayMedicineTimes() {
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }
// }

// void AdjustTimes() {
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }

// Prawidłowy adres IPv4 składa się z czterech liczb rozdzielonych kropkami
// Każda liczba nie może zawierać zer wiodących
// Każda liczba musi należeć do zakresu od 0 do 255
// 1.1.1.1 i 255.255.255.255 to przykłady prawidłowych adresów IP.

// Napisz funkcję, która sprawdzi, czy podany ciąg znaków jest prawidłowym adresem IP.

// string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
// // bool validLength = false;
// // bool validZeroes = false;
// // bool validRange = false;

// // Console.WriteLine(CheckIpAddress(ipv4Input));

// foreach (string ip in ipv4Input) {
//     Console.WriteLine(CheckIpAddress(ip));
// }

// bool CheckIpAddress(string ip) {

//     string[] SplitIP = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//     if (SplitIP.Length != 4) {
//         Console.WriteLine("Invalid IP address");
//         return false;
//     }

//     foreach (string val in SplitIP) {
//         if (val.Length == 0 || val.Length > 3) {
//             Console.WriteLine("Invalid IP address");
//             return false;
//         }

//         if (val[0] == '0' && val.Length > 1) {
//             Console.WriteLine("Invalid IP address");
//             return false;
//         }

//         if (!int.TryParse(val, out int num)) {
//             Console.WriteLine("Invalid IP address");
//             return false;
//         }

//         if (num < 0 || num > 255) {
//             Console.WriteLine("Invalid IP address");
//             return false;
//         }
//     }

//     return true;
// }

// Random random = new Random();
// int luck = random.Next(100);

// string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
// string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
// string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
// string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

// Console.WriteLine("A fortune teller whispers the following words:");
// string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
// for (int i = 0; i < 4; i++) 
// {
//     Console.Write($"{text[i]} {fortune[i]} ");
// }

string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };
Random random = new Random();

void tellFortune()
{
    int luck = random.Next(100);

    Console.WriteLine("A fortune teller whispers the following words:");
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++)
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
}

for (int i = 0; i < 5; i++)
{
    tellFortune();
}