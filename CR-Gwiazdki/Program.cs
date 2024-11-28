class Program
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

    public static void CPTTRN2(int l, int c) {
        // l,c < 100
        for (int i = 0; i < l; i++)
        {
            for (int j = 0; j < c; j++)
            {
                if (i == 0 || i == l-1) {
                    Star();
                } else {
                    if(j == 0 || j == c-1) {
                        Star();
                    } else {
                        Dot();
                    }
                }
            }
            NewLine();
        }
    }

    /*
    for CPTTRN3(2, 5)
    ****************
    *..*..*..*..*..*
    *..*..*..*..*..*
    ****************
    *..*..*..*..*..*
    *..*..*..*..*..*
    ****************
    */
    // 2 square  1, 2
    // ********
    // *..*..*
    // *..*..*
    // ********
    public static void CPTTRN3(int l, int c) {
        for (int i = 0; i < l; i++) {
            if(i == 0 || i == l) {
                for (int k = 0; k < c; k++) {
                    Star(); Star(); Star(); Star();
                }
                NewLine();
            }
            
            for (int m = 0; m < 2; m++) {
                for (int k = 0; k < c; k++) {
                    if(k == 0) {
                        Star();
                        Dot();
                        Dot();
                        Star();
                    } else if ( k == c-1) {
                        Dot();
                        Dot();
                        Star();
                    } else {
                        Dot();
                        Dot();
                        Star();
                    }
                }
                NewLine();
            }
            
            // Bottom line of squares (all stars)
            for (int k = 0; k < c; k++) {
                Star(); Star(); Star(); Star();
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
        // CPTTRN1(3, 3);
        // CPTTRN1(2, 5);
        // CPTTRN2(2, 4);
        // CPTTRN2(2, 5);
        // CPTTRN2(4, 4);
        // CPTTRN3(4, 2);
        CPTTRN3(3, 1);
    }
}