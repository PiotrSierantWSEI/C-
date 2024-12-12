/*

Napisz program, który wczyta ze standardowego wejścia prostokątną planszę gry Saper (ang. minswepper),
a następnie wprowadzi do odpowiednich komórek planszy liczby określające liczbę przylegających min.

Przyjmujemy, że plansza jest prostokątem o zadanych rozmiarach (nie większych niż 8) składającym się z komórek, do których wprowadzone są znaki:

kropki . oznaczającej pole nieodsłonięte,
gwiazdki * oznaczającej minę,
cyfry oznaczającej liczbę przylegających min.
Twoim zadaniem jest "odsłonić" całą planszę. Przyjmujemy, że jeśli komórka nie przylega do żadnej miny, pozostawiamy znak kropki. Sugeruj się podanymi przykładami.

Na wejściu, w pierwszym wierszu podane są dwie liczby oddzielone jedną spacją, określające wymiary planszy: liczbę wierszy i liczbę kolumn odpowiednio
W kolejnych wierszach "narysowana" jest plansza gry za pomocą kropek i gwiazdek
Na wyjściu wypisana jest plansza, zapełniona w odpowiedni sposób liczbami.

==============================
4 5

.*.*.
..*..
..*..
.....

1*3*1
13*31
.2*2.
.111.

==============================
4 4

*...
....
.*..
....

*1..
221.
1*1.
111.

==============================
3 5

**...
.....
.*...

**1..
332..
1*1..

*/

using System;

namespace CR_Sapper {
    class Program {
        static void Main() {
            // wczytujemy wielkosc planszy
            int[] size = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            // wczytujemy plansze
            string[] board = new string[size[0]];
            for (int i = 0; i < size[0]; i++) {
                board[i] = Console.ReadLine();
            }
            printBoard(board);
        }

        static void printBoard(string[] board) {
            for (int i = 0; i < board.Length; i++) {
                for (int j = 0; j < board[i].Length; j++) {
                    if (board[i][j] == '*') {
                        Star();
                    } else {
                        int count = 0;
                        for (int x = -1; x <= 1; x++) {
                            for (int y = -1; y <= 1; y++) {
                                if (i + x >= 0 && i + x < board.Length && j + y >= 0 && j + y < board[i].Length) {
                                    if (board[i + x][j + y] == '*') {
                                        count++;
                                    }
                                }
                            }
                        }
                        if (count == 0) {
                            Dot();
                        } else {
                            Number(count);
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        static void Dot() => Console.Write("."); // pole nieodsłonięte
        static void Star() => Console.Write("*"); // mina
        static void Number(int n) => Console.Write(n); // liczba min wokół
    }
}