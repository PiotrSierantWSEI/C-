﻿class Program
{
    const char CHAR = '*';
    static void Star() => Console.Write(CHAR);
    static void StarLn() => Console.WriteLine(CHAR);
    static void Space() => Console.Write(" ");
    static void SpaceLn() => Console.WriteLine(" ");
    static void NewLine() => Console.WriteLine();
    static void Dot() => Console.Write(".");

    public static void Prostokat( int n, int m )
    {
        for( int i = 0; i<n; i++)
        {
            Star();
        }
        NewLine();

        for (int j = 1; j < m-1; j++)
        {
            Star();
            for (int i = 1; i < n - 1; i++)
                Space();

            StarLn();
        }

        for (int i = 0; i < n; i++)
        {
            Star();
        }
        NewLine();
    }

    public static void XPattern(int n) {
        if( n < 3 ) throw new ArgumentException("n must be greater than 3");

        if (n % 2 == 0)
            n--;

        for( int i = 0; i < n; i++ )
        {
            for( int j = 0; j < n; j++ )
            {
                if( i == j || i + j == n - 1 )
                    Star();
                else
                    Space();
            }
            NewLine();
        }
    }

    public static void CPTTRN1(int l, int c) {
        // l,c < 100
        for (int i = 0; i < l; i++)
        {
            for (int j = 0; j < c; j++)
            {
                if (i % 2 == 0) 
                {
                    if (j % 2 == 0) {
                        Star();
                    } else {
                        Dot();
                    }
                } else {
                    if (j % 2 == 0) {
                        Dot();
                    } else {
                        Star();
                    }
                }
            }
            NewLine();
        }
    }

    public static void Main(string[] args)
    {
        // Prostokat(5, 7);
        // XPattern(3);
        // XPattern(7);
        // XPattern(8);
        CPTTRN1(3, 3);
        CPTTRN1(2, 5);
    }
}