for(int i = 1 ; i <= 100; i++) {
    if(i % 5 == 0 && i % 3 == 0) {
        Console.WriteLine($"FizzBuzz, {i}");
    }
    if(i % 3 == 0) {
        Console.WriteLine($"Fizz, {i}");
    }
    else if(i % 5 == 0) {
        Console.WriteLine($"Buzz, {i}");
    }
}