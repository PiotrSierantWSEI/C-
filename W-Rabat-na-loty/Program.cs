using System;
namespace Rabat_Na_Loty
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime dateOfBirth = AskForDate("Podaj swoją datę urodzenia");
            DateTime flightDate = AskForDate("Podaj datę lotu");

            bool isDomestic = AskForYesNoAnswer("Czy lot jest krajowy");
            bool isRegularCustomer = AskForYesNoAnswer("Czy jesteś stałym klientem");

            bool isSeason = CheckIsSeason(flightDate);

            PrintData(dateOfBirth, flightDate, isDomestic, isRegularCustomer, isSeason);

            int discount = CalcDiscount(dateOfBirth, flightDate, isDomestic, isRegularCustomer, isSeason);
            PrintResult(discount);
        }
        public static int CalcDiscount(DateTime dateOfBirth, DateTime flightDate, bool isDomestic, bool isRegularCustomer, bool isSeason)
        {
            int discount = 0;
            int age = DateTime.Now.Year - dateOfBirth.Year;

            discount += CalcBasicPromotion(age, isDomestic);

            if (flightDate.AddMonths(-5) > DateTime.Now)
            {
                discount += 10;
            }

            if (!isDomestic && !isSeason)
            {
                discount += 15;
            }

            if (isRegularCustomer && age >= 18)
            {
                discount += 15;
            }

            if (age < 2 && discount > 80)
            {
                discount = 80;
            }

            if (age >= 2 && discount > 30)
            {
                discount = 30;
            }

            return discount;
        }
        public static int CalcBasicPromotion(int age, bool isDomestic)
        {
            if (age < 2 && !isDomestic) return 70;
            if (age < 2 && isDomestic) return 80;
            if (age >= 2 & age <= 16) return 10;
            return 0;
        }
        public static DateTime AskForDate(string question)
        {
            Console.Write($"{question} (w formacie RRRR-MM-DD): ");
            string? inputDate = Console.ReadLine();

            if (!DateTime.TryParse(inputDate, out DateTime parsedDate))
            {
                Console.WriteLine("Niepoprawny format daty. Spróbuj ponownie.");
                return AskForDate(question);
            }
            return parsedDate;
        }
        public static bool AskForYesNoAnswer(string question)
        {
            Console.Write(question + " (T/N)? ");
            string? answer = Console.ReadLine();

            if (string.Equals(answer, "t", StringComparison.OrdinalIgnoreCase)) return true;
            if (string.Equals(answer, "n", StringComparison.OrdinalIgnoreCase)) return false;

            Console.WriteLine("Niepoprawna odpowiedź. Spróbuj ponownie.");
            return AskForYesNoAnswer(question);
        }
        public static bool CheckIsSeason(DateTime flightDate)
        {
            if ((flightDate.Month == 12 && flightDate.Day >= 20) || (flightDate.Month == 1 && flightDate.Day <= 10) ||
                (flightDate.Month == 3 && flightDate.Day >= 20) || (flightDate.Month == 4 && flightDate.Day <= 10) ||
                flightDate.Month == 7 || flightDate.Month == 8)
            {
                return true;
            }
            return false;
        }
        public static void PrintData(DateTime dateOfBirth, DateTime flightDate, bool isDomestic, bool isRegularCustomer, bool isSeason)
        {
            Console.WriteLine("=== Do obliczeń przyjęto:");
            Console.WriteLine($" * Data urodzenia: {dateOfBirth:dd.MM.yyyy}");
            Console.WriteLine($" * Data lotu: {flightDate:dddd, d MMMM yyyy}. Lot {(isSeason ? "w sezonie" : "poza sezonem")}");
            Console.WriteLine($" * Lot krajowy: {isDomestic}");
            Console.WriteLine($" * Stały klient: {isRegularCustomer}");
        }
        public static void PrintResult(int discount)
        {
            Console.WriteLine($"Przysługuje Ci rabat w wysokości: {discount}%");
            Console.WriteLine($"Data wygenerowania raportu: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
        }
    }
}
