using System;
using System.Net.Mail;

namespace Bank
{
    public class AccountPlus : Account, IAccountWithLimit
    {
        private decimal _oneTimeDebetLimit;
        private decimal _avaibleFounds;

        private bool _isDebet = false;
        // przyznany limit debetowy
        // mozliwość zmiany, jeśli konto nie jest zablokowane
        public decimal OneTimeDebetLimit
        {
            get => _oneTimeDebetLimit;
            set
            {
                if (IsBlocked)
                    return;
                if (value < 0)
                    return;
                _oneTimeDebetLimit = Math.Round(value, 2);
                _avaibleFounds = Math.Round(Balance + _oneTimeDebetLimit, 2);
            }
        }
        // dostępne środki, z uwzględnieniem limitu
        public decimal AvaibleFounds { get => _avaibleFounds; }
        public bool IsDebet
        {
            get => _isDebet;
            private set => _isDebet = value;
        }

        public AccountPlus(string name, decimal initialBalance = 0, decimal initialLimit = 100)
            : base(name, initialBalance)
        {
            OneTimeDebetLimit = initialLimit < 0 ? 0 : Math.Round(initialLimit, 2);
            _avaibleFounds = Math.Round(Balance + OneTimeDebetLimit, 2);

            if(initialBalance <= 0) {
                IsDebet = true;
            }
        }

        public new bool Deposit(decimal amount)
        {
            if (amount <= 0)
                return false;

            decimal debtToCover = OneTimeDebetLimit - AvaibleFounds;
            
            if (debtToCover == amount) {
                IsDebet = false;
                _avaibleFounds = OneTimeDebetLimit;
                Unblock();
                return true;
            }

            base.Deposit(amount);
            // Jeśli konto było w debecie, spłać debet
            if (IsDebet)
            {
                base.Unblock();
                // ale wplacamy kwote pomniejszona o debet
                base.Deposit(amount - debtToCover);
                // Jeśli wpłata jest wystarczająca do spłaty debetu
                if (amount >= debtToCover)
                {
                    // Debet całkowicie spłacony
                    IsDebet = false;
                    // Zaktualizuj dostępne środki
                    _avaibleFounds = Math.Round(amount - debtToCover + OneTimeDebetLimit, 2);
                }
                else
                {
                    // Debet częściowo spłacony
                    _avaibleFounds = Math.Round(Balance + OneTimeDebetLimit - (debtToCover - amount), 2);
                    Block();
                }
            }
            else
            {
                // Konto nie jest w debecie, normalne obliczanie dostępnych środków
                _avaibleFounds = Math.Round(Balance + OneTimeDebetLimit, 2);
            }

            // Jeśli debet został spłacony, odblokuj konto
            if (!IsDebet && IsBlocked)
            {
                Unblock();
            }
            return true;
        }

        public new bool Withdrawal(decimal amount)
        {
            if (amount <= 0) return false;
            if (amount > AvaibleFounds) return false;
            if (IsBlocked) return false;
            // Jeśli saldo jest zerowe, sprawdzamy debet
            if (Balance == 0.00m && OneTimeDebetLimit > 0)
            {
                // Można wypłacić tylko w ramach debetu
                if (amount <= OneTimeDebetLimit)
                {
                    // Zmniejszamy dostępne środki o kwotę wypłaty
                    _avaibleFounds = Math.Round(OneTimeDebetLimit - amount, 2);
                    Block();
                    return true;
                }
                else
                {
                    return false; // Próba wypłaty większej niż dostępny debet
                }
            }

            if (amount > Balance && amount <= AvaibleFounds)
            {
                // Wypłata z wykorzystaniem debetu
                decimal debtUsed = amount - Balance;
                base.Withdrawal(Balance); // Wyzerowanie salda konta
                IsDebet = true; // Ustawienie flagi debetu

                // Aktualizacja dostępnych środków
                _avaibleFounds = Math.Round(OneTimeDebetLimit - debtUsed, 2);
                Block();
                return true;
            }

            // Normalna wypłata, bez debetu
            if (Balance >= amount)
            {
                base.Withdrawal(amount);
                _avaibleFounds = Math.Round(Balance + OneTimeDebetLimit, 2);
                return true;
            }
            return false;
        }


        public new void Unblock() 
        {
            if(AvaibleFounds < OneTimeDebetLimit) {
                Block();
                return;
            } 

            base.Unblock();
        }

        /*

            W każdym momencie konto można "ręcznie" zablokować (metoda Block()). 
            Konto zablokowane można "ręcznie" odblokować (metoda Unblock()) jedynie wtedy, gdy nie ma zadłużenia w ramach "jednorazowego limitu debetowego". 
            Konto "ręcznie" zablokowane odblokowuje się automatycznie przy operacji wpłaty powodującej, że nie ma zadłużenia.

        */
        public override string ToString()
        {
            string blockInfo = IsBlocked ? ", blocked" : "";
            return $"Account name: {Name}, balance: {Balance:F2}{blockInfo}, avaible founds: {AvaibleFounds:F2}, limit: {OneTimeDebetLimit:F2}";
        }
    }
}