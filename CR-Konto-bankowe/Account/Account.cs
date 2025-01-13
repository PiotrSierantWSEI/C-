using System;

namespace Bank
{
    public interface IAccount
    {
        string Name { get; }
        decimal Balance { get; }
        bool IsBlocked { get; }
        void Block();
        void Unblock();
        bool Deposit(decimal amount);
        bool Withdrawal(decimal amount);
    }

    public class Account : IAccount
    {
        /* ZACHOWANIE 
            Wszystkie operacje arytmetyczne wykonywane z dokładnością do 4. cyfr po przecinku
            Konstruktor tworzy obiekt na podstawie nazwy klienta (obligatoryjnie) i salda początkowego (opcjonalnie). Domyślnie, saldo początkowe wynosi 0. W przypadku podania ujemnego salda początkowego, zgłaszany jest wyjątek typu ArgumentOutOfRangeException. Nazwa konta musi mieć przynajmniej 3 znaki, w przeciwnym przypadku zgłaszany wyjątek ArgumentException. W momencie utworzenia konto jest odblokowane.
            Wpłatę można wykonać dla podanej kwoty (wartość nieujemna), o ile konto nie jest zablokowane. Jeśli saldo ulega zmianie, zwracana jest wartość true. Metoda Deposit nie zgłasza wyjątków.
            Wypłatę można wykonać dla podanej kwoty (wartość nieujemna), o ile konto nie jest zablokowane oraz na koncie jest wystarczająca ilość środków. Jeśli saldo ulega zmianie, zwracana jest wartość true. Metoda Withdrawal nie zgłasza wyjątków.
            
            Tekstową reprezentacją konta jest napis o formacie:
            Saldo podawane jest w zaokrągleniu do 2. miejsc po przecinku.
        */

        public string Name { get; }

        public decimal Balance { get; private set; }

        public bool IsBlocked { get; private set; }

        public Account(string name, decimal balance = 0)
        {   
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentOutOfRangeException(nameof(name), "Name is null");
            }
            string trimedName = name.Trim();
            if (trimedName.Length < 3)
            {
                throw new ArgumentException("Name must have at least 3 characters");
            }

            if(balance < 0)
            {
                throw new ArgumentOutOfRangeException("Balance cannot be negative");
            }

            Name = trimedName;
            Balance = Math.Round(balance, 4);
            IsBlocked = false;
        }

        public void Block()
        {
            IsBlocked = true;
        }

        public void Unblock()
        {
            IsBlocked = false;
        }

        public bool Deposit(decimal amount)
        {
            if(amount < 0 || IsBlocked)
            {
                return false;
            }

            Balance += Math.Round(amount, 4);
            return true;

        }

        public bool Withdrawal(decimal amount)
        {
            if(amount <= 0 || IsBlocked || Balance < amount)
            {
                return false;
            }

            Balance -= Math.Round(amount, 4);
            return true;
        }

        public override string ToString()
        {
            if(IsBlocked)
            {
                return $"Account name: {Name}, balance: {Balance:F2}, blocked";
            }
            else
            {
                return $"Account name: {Name}, balance: {Balance:F2}";
            }
        }
    }
}