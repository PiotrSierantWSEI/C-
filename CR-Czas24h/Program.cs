namespace Program {
    class Program {
        static void Main() {
            // Test1();
            // Test2();
            // Test3();
            // Test4();
            Test5();
        }
        
        static void Test1() 
        {
            var t = new Czas24h(2, 15, 37);
            t.Minuta = 20;
            t.Godzina = 1;
            t.Sekunda = 26;
            Console.WriteLine(t);
            // 1:20:26
        }
        static void Test2()
        {
            var t = new Czas24h(2, 15, 37);
            t.Minuta = 20;
            t.Godzina = 24;
            Console.WriteLine(t);
            // error 
        }
        static void Test3()
        {
            var t = new Czas24h(2, 15, 37);
            t.Minuta = -20;
            t.Godzina = 23;
            Console.WriteLine(t);
            // error
        }
        static void Test4()
        {
            var t = new Czas24h(2, 15, 37);
            t.Minuta = 20;
            t.Godzina = 23;
            t.Godzina = 1;
            t.Sekunda = 15;
            t.Minuta = 10;
            t.Sekunda = 23;
            t.Sekunda = 1;
            t.Minuta = 12;
            Console.WriteLine(t);
            // 1:12:01
        }
        static void Test5()
        {
            var t = new Czas24h(24, 15, 37);
            t.Minuta = 20;
            t.Godzina = 23;
            t.Godzina = 1;
            Console.WriteLine(t);
        }
    }
}