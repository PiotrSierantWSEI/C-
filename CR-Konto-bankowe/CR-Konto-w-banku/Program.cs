namespace CR_Konto_w_banku;

using Bank;

class Program
{
    static void Main()
    {
        Test8();
        Console.WriteLine("============");
        Test9();
    }
    public static void Test8()
    {

        // scenariusz: wpłaty wypłaty, blokada konta
        // utworzenie konta plus z domyslnym limitem 100
        var john = new AccountPlus("John", initialBalance: 100.0m);
        Console.WriteLine(john);

        // wypłata - podanie kwoty ujemnej
        john.Withdrawal(-50.0m);
        Console.WriteLine(john);

        // wypłata bez wykorzystania debetu
        john.Withdrawal(50.0m);
        Console.WriteLine(john);

        // wypłata z wykorzystaniem debetu
        john.Withdrawal(100.0m);
        Console.WriteLine(john);

        // konto zablokowane, wypłata niemożliwa
        john.Withdrawal(10.0m);
        Console.WriteLine(john);

        // wpłata odblokowująca konto
        john.Deposit(80.0m);
        Console.WriteLine(john);

        // wpłata podanie kwoty ujemnej
        john.Deposit(-80.0m);
        Console.WriteLine(john);
    }
    public static void Test9()
    {
        // sytuacje specjalne
        // konto z zerowym stanem
        var account = new AccountPlus("John", initialBalance: 0, initialLimit: 0);
        Console.WriteLine(account);
        account.Withdrawal(10);
        Console.WriteLine(account);

        // zerowe saldo, limit 50
        account.OneTimeDebetLimit = 50;
        Console.WriteLine(account);
        account.Withdrawal(0); // zerowa wypłata
        Console.WriteLine(account);
        account.Withdrawal(10); // wypłata w ramach debetu
        Console.WriteLine(account);
        account.Unblock(); // próba odblokowania konta
        Console.WriteLine(account);
        account.Deposit(10); // likwidacja debetu, zerowy bilans
        Console.WriteLine(account);
    }
}
