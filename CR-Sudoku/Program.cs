/*
    Wczytać tabele 9x9 jednocyfrowych liczb całkowitych
    Każdy wiersz 9 cyfr
    Każda kolumna 9 cyfr
    Każdy z 9 kwadratów 3x3 9 cyfr

    sprawdzanie poprawności
    - wiersze od 1 do 9
    - kolumny od 1 do 9
    - kwadraty od 1 do 9

    napis yes jeśli podany zestaw stanowi poprawne rozwiązanie Sudoku, w przeciwnym przypadku napis no
*/

using System;

namespace CR_Sudoku {
    class Program {
        static void Main() {
            int[,] sudoku = new int[9, 9];

            for(int i = 0; i < 9;i ++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for(int j =0; j < 9; j++)
                {
                    sudoku[i, j] = int.Parse(line[j]);
                }
            }

            ValidateSudoku(sudoku);
        }

        static void ValidateSudoku(int[,] sudoku) {
            for(int i = 0; i < 9; i++)
            {
                if(!ValidateRow(sudoku, i) || !ValidateColumn(sudoku, i) || !ValidateSquare(sudoku, i))
                {
                    Console.WriteLine("no");
                    return;
                }
            }
            Console.WriteLine("yes");
        }

        static bool ValidateRow(int[,] sudoku, int row) {
            bool[] rowCheck = new bool[9];
            for(int i = 0; i < 9; i++)
            {
                if(rowCheck[sudoku[row, i] - 1])
                {
                    return false;
                }
                rowCheck[sudoku[row, i] - 1] = true;
            }
            return true;
        }

        static bool ValidateColumn(int[,] sudoku, int column) {
            bool[] columnCheck = new bool[9];
            for(int i = 0; i < 9; i++)
            {
                if(columnCheck[sudoku[i, column] - 1])
                {
                    return false;
                }
                columnCheck[sudoku[i, column] - 1] = true;
            }
            return true;
        }

        static bool ValidateSquare(int[,] sudoku, int square) {
            bool[] squareCheck = new bool[9];
            int row = (square / 3) * 3;
            int column = (square % 3) * 3;
            for(int i = row; i < row + 3; i++)
            {
                for(int j = column; j < column + 3; j++)
                {
                    if(squareCheck[sudoku[i, j] - 1])
                    {
                        return false;
                    }
                    squareCheck[sudoku[i, j] - 1] = true;
                }
            }
            return true;
        }
    }
}