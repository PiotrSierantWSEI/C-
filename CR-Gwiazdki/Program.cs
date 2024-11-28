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
            for (int k = 0; k < c; k++) {
                Star(); Star(); Star(); Star();
            }
            NewLine();
        }
    }

    public static void CPTTRN4(int l, int c, int h, int w) {
        for (int i = 0; i < l; i++) {
            if(i == 0 || i == l) {
                for (int k = 0; k < c; k++) {
                    Star(); Star(); Star(); Star();
                }
                NewLine();
            }
            
            for (int m = 0; m < h; m++) {
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
            for (int k = 0; k < c; k++) {
                Star(); Star(); Star(); Star();
            }
            NewLine();
        }
    }
    
    public static void CPTTRN5(int l, int c, int s)
    {
        for (int i = 0; i < c; i++) {
            for (int j = 0; j < s + 1; j++) Star();
        }
        Star();
        NewLine();

        for (int row = 0; row < l; row++) {
            for (int h = 0; h < s; h++) {
                Star();
                
                for (int col = 0; col < c; col++) {
                    bool useBackslash = ((row + col) % 2 == 0);
                    int diagPos = h;
                    
                    for (int w = 0; w < s; w++) {
                        if (w == diagPos && useBackslash) Console.Write(@"\");
                        else if (w == (s-1-diagPos) && !useBackslash) Console.Write("/");
                        else Dot();
                    }
                    Star();
                }
                NewLine();
            }

            for (int i = 0; i < c; i++) {
                for (int j = 0; j < s + 1; j++) Star();
            }
            Star();
            NewLine();
        }
    }
    
    public static void Main(string[] args)
    {
        // Prostokat(5, 7);
        // XPattern(8);
        // CPTTRN1(2, 5);
        // CPTTRN2(4, 4);
        // CPTTRN3(4, 2);
        // CPTTRN4(4, 4, 1, 2);
        // CPTTRN5(2, 5, 2);
    }
}