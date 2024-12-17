/*

Problem
Poniżej przedstawiono zasady udzielania rabatów na przeloty w pewnej linii lotniczej.

Dla pasażerów niemowląt w wieku poniżej 2 lat na rejsach krajowych przysługuje rabat w wysokości 80%. 
Na trasach międzynarodowych rabat ten wynosi 70%. 

Dla młodzieży (od 2 do 16 lat) przysługuje rabat w wysokości 10%, zarówno na trasach krajowych jak i międzynarodowych. 

Pasażerom, którzy rezerwują lot na 5 miesięcy przed podróżą, przysługuje rabat w wysokości 10%.

Dla lotów międzynarodowych pasażerom przysługuje 15% rabat, jeśli podróżują poza sezonem.

Nie ma zniżek na loty międzynarodowe chyba, że pasażer jest niemowlęciem lub podróż odbywa się poza sezonem.

Stali klienci (a mogą nimi być tylko pasażerowie, którzy ukończyli 18 lat) otrzymują zniżkę 15%. 

Rabaty łączą się. 

Maksymalny łączny rabat dla niemowląt nie może przekroczyć 80%, zaś dla pozostałych – 30%.

Przyjmij, że sezon, to okres wakacyjny i świąteczny tzn. 20.12.XXXX – 10.01.XXX(X+1), 20.03.XXXX – 10.04.XXXX oraz miesiące lipiec i sierpień, gdzie XXXX oznacza dowolny rok.

*/

/*

# Zadanie 1
Napisz program konsolowy prowadzący dialog z użytkownikiem (zadający pytania dotyczące warunków zakupu biletu i wczytujący odpowiedzi użytkownika, np. data urodzenia, data lotu, czy lot jest krajowy/międzynarodowy, czy stały klient, ...), wypisujący obliczony rabat przysługujący klientowi w dniu bieżącym (w chwili uruchomienia programu).

## Scenariusz działania programu
Program zadaje klientowi serię pytań, wczytuje dane. W przypadku niepoprawnych danych informuje o rodzaju błędu i prosi o ponowne ich wprowadzenie.
Program wypisuje wczytane dane i przystępuje do obliczeń
Program wypisuje wynik - obliczony rabat

## Przykładowa sesja:

1. Podaj swoją datę urodzenia w formacie RRRR-MM-DD: 2011-01-01
2. Podaj datę lotu w formacie RRRR-MM-DD: 2023-07-04
3. Czy lot jest krajowy (T/N)? t
4. Czy jesteś stałym klientem (T/N)? t

5.
=== Do obliczeń przyjęto:
 * Data urodzenia: 01.01.2011
 * Data lotu: wtorek, 4 lipca 2023. Lot w sezonie
 * Lot krajowy
 * Stały klient: Tak

6.
Przysługuje Ci rabat w wysokości: 10%
Data wygenerowania raportu: 2023-02-01 12:03:23

## Zalecenia

Postaraj się odwzorować podany powyżej scenariusz i wydruk raportu.
Postaraj się zminimalizować liczbę instrukcji if-else.
Wykorzystaj typ danych DateTime do operacji na datach.

## Ograniczenia

Program nie może zgłosić żadnego wyjątku, wymusza na operatorze wprowadzenie poprawnych danych
Jedynym sposobem zakończenia programu jest wprowadzenie poprawnie wszystkich danych i uzyskanie wyniku obliczeń (ewentualnie przerwanie z poziomu systemu operacyjnego Ctrl-Z)
*/

using System;

namespace Rabat_Na_Loty {
    public class Program {
        static void Main(string[] args) {
            // Podaj swoją datę urodzenia w formacie RRRR-MM-DD: 2011-01-01
            DateTime dateOfBirth = AskForDateOfBirth();
            // Podaj datę lotu w formacie RRRR-MM-DD: 2023-07-04
            DateTime flightDate = AskForFlightDate();
            // Czy lot jest krajowy (T/N)? t
            bool isDomestic = AskForIsDomestic();
            // Czy jesteś stałym klientem (T/N)? t
            bool isRegularCustomer = AskForIsRegularCustomer();

            bool isSeason = CheckIsSeason(flightDate);

            PrintData(dateOfBirth, flightDate, isDomestic, isRegularCustomer, isSeason);
        }

        static DateTime AskForDateOfBirth() {
            Console.Write("Podaj swoją datę urodzenia w formacie RRRR-MM-DD: ");
            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string dateOfBirth = Console.ReadLine();
            
            if (!DateTime.TryParse(dateOfBirth, out DateTime dateOfBirthDateTime)) {
                Console.WriteLine("Niepoprawny format daty. Spróbuj ponownie.");
                AskForDateOfBirth();
            }
            return dateOfBirthDateTime;
        }

        static DateTime AskForFlightDate() {
            Console.Write("Podaj datę lotu w formacie RRRR-MM-DD: ");
            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string flightDate = Console.ReadLine();

            if (!DateTime.TryParse(flightDate, out DateTime dateOfflightDateTime)) {
                Console.WriteLine("Niepoprawny format daty. Spróbuj ponownie.");
                AskForDateOfBirth();
            }
            return dateOfflightDateTime;
        }

        static bool AskForIsDomestic() {
            Console.Write("Czy lot jest krajowy (T/N)? ");
            string isDomestic = Console.ReadLine();

            if (string.Equals(isDomestic, "t", StringComparison.OrdinalIgnoreCase)) {
                return true;
            } else if (string.Equals(isDomestic, "n", StringComparison.OrdinalIgnoreCase)) {
                return false;
            } else {
                Console.WriteLine("Niepoprawna odpowiedź. Spróbuj ponownie.");
                AskForIsDomestic();
            }
            return false;
        }

        static bool AskForIsRegularCustomer() {
            Console.Write("Czy jesteś stałym klientem (T/N)? ");
            string isRegularCustomer = Console.ReadLine();
            
            if (string.Equals(isRegularCustomer, "t", StringComparison.OrdinalIgnoreCase)) {
                return true;
            } else if (string.Equals(isRegularCustomer, "n", StringComparison.OrdinalIgnoreCase)) {
                return false;
            } else {
                Console.WriteLine("Niepoprawna odpowiedź. Spróbuj ponownie.");
                AskForIsRegularCustomer();
            }
            return false;
        }
    
        public static bool CheckIsSeason(DateTime flightDate) {
            if ((flightDate.Month == 12 && flightDate.Day >= 20) || (flightDate.Month == 1 && flightDate.Day <= 10) ||
                (flightDate.Month == 3 && flightDate.Day >= 20) || (flightDate.Month == 4 && flightDate.Day <= 10) ||
                flightDate.Month == 7 || flightDate.Month == 8) {
                return true;
            }
            return false;
        }
        static void PrintData(DateTime dateOfBirth, DateTime flightDate, bool isDomestic, bool isRegularCustomer, bool isSeason) {
            Console.WriteLine("=== Do obliczeń przyjęto:");
            Console.WriteLine($" * Data urodzenia: {dateOfBirth:dd.MM.yyyy}");
            Console.WriteLine($" * Data lotu: {flightDate:dddd, d MMMM yyyy}. Lot {(isSeason ? "w sezonie" : "poza sezonem")}");
            Console.WriteLine($" * Lot krajowy: {isDomestic}");
            Console.WriteLine($" * Stały klient: {isRegularCustomer}");

            // === Do obliczeń przyjęto:
            // * Data urodzenia: 01.01.2011
            // * Data lotu: wtorek, 4 lipca 2023. Lot w sezonie
            // * Lot krajowy
            // * Stały klient: Tak
        }
    }
}