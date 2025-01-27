using System;
using System.Drawing;

namespace FiguresLib
{
    public class Triangle : Figure, IMeasurable2D, IMoveable
    {
        public Point A { get; }
        public Point B { get; }
        public Point C { get; }

        // Konstruktor
        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
            Color = Color.Red;
        }

        // Obwód trójkąta
        public double Circumference =>
            new LineSegment(A, B).Length +
            new LineSegment(B, C).Length +
            new LineSegment(C, A).Length;

        // Pole trójkąta (wzór Herona)
        public double Surface
        {
            get
            {
                double a = new LineSegment(A, B).Length;
                double b = new LineSegment(B, C).Length;
                double c = new LineSegment(C, A).Length;
                double s = Circumference / 2; // Połowa obwodu
                return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            }
        }

        // Długość najdłuższego boku (do celów IMeasurable1D)
        public double Length => Math.Max(
            new LineSegment(A, B).Length,
            Math.Max(new LineSegment(B, C).Length, new LineSegment(C, A).Length));

        // Przesuwanie trójkąta
        public void Move(Vector v)
        {
            throw new NotSupportedException("Triangle is immutable. Use a method to create a new triangle with shifted points.");
        }

        public Triangle MoveTriangle(Vector v)
        {
            return new Triangle(A.Move(v), B.Move(v), C.Move(v));
        }

        // Właściwości geometryczne
        public bool IsEquilateral =>
            AreEqual(new LineSegment(A, B).Length, new LineSegment(B, C).Length) &&
            AreEqual(new LineSegment(B, C).Length, new LineSegment(C, A).Length);

        public bool IsIsosceles =>
            AreEqual(new LineSegment(A, B).Length, new LineSegment(B, C).Length) ||
            AreEqual(new LineSegment(B, C).Length, new LineSegment(C, A).Length) ||
            AreEqual(new LineSegment(A, B).Length, new LineSegment(C, A).Length);

        public bool IsRight
        {
            get
            {
                double a = new LineSegment(A, B).Length;
                double b = new LineSegment(B, C).Length;
                double c = new LineSegment(C, A).Length;
                double[] sides = { a, b, c };
                Array.Sort(sides); // Posortuj długości rosnąco
                return AreEqual(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2), Math.Pow(sides[2], 2));
            }
        }

        public bool IsAcute
        {
            get
            {
                double a = new LineSegment(A, B).Length;
                double b = new LineSegment(B, C).Length;
                double c = new LineSegment(C, A).Length;
                double[] sides = { a, b, c };
                Array.Sort(sides); // Posortuj długości rosnąco
                return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) > Math.Pow(sides[2], 2);
            }
        }

        public bool IsObtuse
        {
            get
            {
                double a = new LineSegment(A, B).Length;
                double b = new LineSegment(B, C).Length;
                double c = new LineSegment(C, A).Length;
                double[] sides = { a, b, c };
                Array.Sort(sides); // Posortuj długości rosnąco
                return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) < Math.Pow(sides[2], 2);
            }
        }

        // Pomocnicza metoda do porównywania wartości z uwzględnieniem dokładności FRACTIONAL_DIGITS
        private bool AreEqual(double a, double b)
        {
            return Math.Abs(a - b) < Math.Pow(10, -FRACTIONAL_DIGITS);
        }

        // Rysowanie trójkąta
        public override void Draw()
        {
            Console.WriteLine($"drawing: {this}, {Color}, Surface = {Surface}, Circumference = {Circumference}");
        }

        public override string ToString()
        {
            return $"Triangle(A: {A}, B: {B}, C: {C})";
        }
    }
}
