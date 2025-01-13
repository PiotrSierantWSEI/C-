namespace CR_Konto_w_banku;

using Bank;

class Program
{
    static void Main(string[] args)
    {
        Test5();
    }

    static void Test1()
    {
        /* Utworzenie konta dla dwóch poprawnie podanych argumentów
        */
        var account = new Account(" John   ", 100.23m);
        Console.WriteLine(account.Balance == 100.23m);
        Console.WriteLine(account.Name == "John");
        Console.WriteLine(!account.IsBlocked);
        Console.WriteLine(account);
    }

    static void Test2()
    {
        /* Utworzenie konta dla dwóch poprawnie podanych argumentów
            zaokrąglenie kwoty w Balance */
        var account = new Account(" John   ", 100.23156m);
        Console.WriteLine(account.Balance == 100.2316m);
        Console.WriteLine(account.Name == "John");
        Console.WriteLine(!account.IsBlocked);
        Console.WriteLine(account);
    }

    static void Test3()
    {
        /* Utworzenie konta dla jednego poprawnie podanego argumentu
        */
        var account = new Account(" Adam ");
        Console.WriteLine(account.Balance == 0.0m);
        Console.WriteLine(account.Name == "Adam");
        Console.WriteLine(!account.IsBlocked);
        Console.WriteLine(account);
    }
    static void Test4()
    {
        /* Utworzenie konta dla dwóch argumentów, nazwa jest null
*/
        try
        {
            var account = new Account(null, 100.0m);
            Console.WriteLine(account);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Name is null");
        }
    }

    static void Test5()
    {
        /* wypłaty */
        var account = new Account("John");
        account.Deposit(100.00m);
        Console.WriteLine(account.Withdrawal(10.00m)); // True
        Console.WriteLine(account); // Account name: John, balance: 90.00
        Console.WriteLine(account.Withdrawal(100.00m)); // False
        Console.WriteLine(account);  // Account name: John, balance: 90.00
        Console.WriteLine(account.Withdrawal(0.00m)); // False
        // Console.WriteLine(account); // False
        // Console.WriteLine(account.Withdrawal(-10.00m)); // Account name: John, balance: 90.00
        // Console.WriteLine(account); // False
        // account.Block(); // Account name: John, balance: 90.00
        // Console.WriteLine(account.Withdrawal(10.4999m)); // False
        // Console.WriteLine(account); // Account name: John, balance: 90.00, blocked
    }
}









