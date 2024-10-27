// string value = "abc123";
// char[] valueArray = value.ToCharArray();

// Console.WriteLine(valueArray[0]); // a
// Console.WriteLine(value[0]);

// Array.Reverse(valueArray);
// string result = new(valueArray);

// Console.WriteLine(result); // 321cba


// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] valueArray = pangram.Split(" ");
// // string result = "";

// for(int i = 0; i < valueArray.Length; i++)
// {
//     char[] charArray = valueArray[i].ToCharArray();
//     Array.Reverse(charArray);
//     valueArray[i] = new string(charArray);

//     // result += valueArray[i] + " ";
// }

// string result = String.Join(" ", valueArray);
// Console.WriteLine(result);
// result = ehT kciuq nworb xof spmuj revo eht yzal god

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// Dodaj kod poniżej poprzedniego kodu, aby przeanalizować identyfikatory "Order ID" z string zamówień przychodzących i zapisać identyfikatory "Order ID" w tablicy

string[] orders = orderStream.Split(",");
Array.Sort(orders);

// Dodaj kod do danych wyjściowych każdego "Identyfikator zamówienia" w kolejności sortowania i zamówień tagów, które nie mają dokładnie czterech znaków długości jako "- Błąd"

for(int i = 0; i < orders.Length; i++)
{
    if(orders[i].Length != 4)
    {
        orders[i] = $"{orders[i]} - Error";
    }

    Console.WriteLine(orders[i]);
}

// A345
// B123
// B177
// B179
// C15     - Error
// C234
// C235
// G3003   - Error