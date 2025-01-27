using FiguresLib;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== default constructor ==");
            Point P0 = new Point();
            Console.WriteLine(P0);
            P0.Draw();

            Console.WriteLine("\n== new point (1,2) ==");
            Point P1 = new Point(1, 2);
            Console.WriteLine(P1);
            P1.Draw();

            Console.WriteLine("\n== another new point (1,2) ==");
            Point P2 = new Point(1, 2);
            P2.Color = System.Drawing.Color.Red; // bo konflikt nazw
            Console.WriteLine(P2);
            P2.Draw();

            Console.WriteLine("P1 equals P2: " + (P1 == P2));

            Console.WriteLine("\n== another new point (1.00001, 2.000009) ==");
            Point P3 = new Point(1.00001, 2.000009);
            P3.Color = System.Drawing.Color.Yellow; // bo konflikt nazw
            Console.WriteLine(P3);
            P3.Draw();

            Console.WriteLine("P1 equals P3: " + (P1 == P3));

            LineSegment s1 = new LineSegment();
            Console.WriteLine(s1);
            s1.Draw();

            LineSegment s2 = new LineSegment(new Point(1, 2), new Point(2, 3));
            s2.Draw();
            LineSegment s3 = new LineSegment(new Point(1, 2), new Point(2, 3));
            s3.Draw();
            LineSegment s4 = new LineSegment(new Point(2, 3), new Point(1, 2));
            s4.Draw();
            Console.WriteLine(s2 == s3);
            Console.WriteLine(s2 == s4);
        }
    }
}