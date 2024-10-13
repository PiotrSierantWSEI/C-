// class TestClass
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine(args.Length);

//         // See https://aka.ms/new-console-template for more information
//         /* Hello World */
//         Console.WriteLine("Hello, World!");

//         /* Work with string */
//         string firstfriend = "Tom";
//         string secondfriend = "Saly";

//         Console.WriteLine($"{firstfriend} test {secondfriend}");
//         Console.WriteLine($"Length: Tom's length {firstfriend.Length}, Saly's length {secondfriend.Length}");

//         /* Trim string */
//         string greeting = "    Hello World     ";
//         Console.WriteLine(greeting);

//         string trimmedGreeting = greeting.Trim();
//         Console.WriteLine(trimmedGreeting);

//         string trimmedStartGreetting = greeting.TrimStart();
//         Console.WriteLine(trimmedStartGreetting);

//         string trimmedEndGreetting = greeting.TrimEnd();
//         Console.WriteLine(trimmedEndGreetting);

//         string sayHello = "Hello World";
//         Console.WriteLine(sayHello);

//         /* Replace */
//         sayHello = sayHello.Replace("Hello", "Grettings");
//         Console.WriteLine(sayHello);

//         /* Upper and Lower */
//         Console.WriteLine(sayHello.ToUpper());
//         Console.WriteLine(sayHello.ToLower());

//         /* Contains */
//         string songLyrics = "You say goodbye, and I say hello";
//         Console.WriteLine(songLyrics.Contains("goodbye"));
//         Console.WriteLine(songLyrics.Contains("greetings"));

//         /* Start and end with */
//         Console.WriteLine(songLyrics.StartsWith("You"));
//         Console.WriteLine(songLyrics.StartsWith("goodbye"));

//         /* Start and end with */
//         Console.WriteLine(songLyrics.EndsWith("hello"));
//         Console.WriteLine(songLyrics.EndsWith("goodbye"));
//     }
// }

using System.Text;  

StringBuilder builder = new();
builder.AppendLine("The following arguments are passed:");

foreach (var arg in args)
{
    builder.AppendLine($"Argument={arg}");
}
Console.WriteLine(builder.ToString());

return 0;