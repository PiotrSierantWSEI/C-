// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0 ? "heads" : "tails"));

Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");