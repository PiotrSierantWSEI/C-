using System;
using System.Drawing;

namespace FiguresLib
{
    public class Square : Figure, IMeasurable2D
    {
        public Point PointA { get; }
        public Point PointB { get; }

        // Konstruktor
        public Square(Point pointA, Point pointB)
        {
            PointA = pointA;
            PointB = pointB;
            Color = Color.Red;
        }

        // Długość przekątnej (z IMeasurable1D)
        public double Length => Math.Sqrt(Math.Pow(PointB.X - PointA.X, 2) + Math.Pow(PointB.Y - PointA.Y, 2));

        // Obwód kwadratu (z IMeasurable2D)
        public double Circumference => 4 * SideLength;

        // Pole powierzchni kwadratu (z IMeasurable2D)
        public double Surface => Math.Pow(SideLength, 2);

        // Długość boku kwadratu
        public double SideLength => Length / Math.Sqrt(2);

        // Punkty wierzchołków kwadratu
        public (Point, Point, Point, Point) Vertices
        {
            get
            {
                // Wektor przekątnej
                double dx = PointB.X - PointA.X;
                double dy = PointB.Y - PointA.Y;

                // Wektory prostopadłe do przekątnej
                double perpX = dy / Math.Sqrt(2);
                double perpY = -dx / Math.Sqrt(2);

                // Wierzchołki kwadratu
                Point vertex1 = PointA;
                Point vertex2 = new Point(PointA.X + perpX, PointA.Y + perpY);
                Point vertex3 = PointB;
                Point vertex4 = new Point(PointB.X - perpX, PointB.Y - perpY);

                return (vertex1, vertex2, vertex3, vertex4);
            }
        }

        // Rysowanie kwadratu
        public override void Draw()
        {
            var (v1, v2, v3, v4) = Vertices;
            Console.WriteLine($"Drawing: Square({v1}, {v2}, {v3}, {v4}), Color = {Color}");
        }

        public override string ToString()
        {
            var (v1, v2, v3, v4) = Vertices;
            return $"Square({v1}, {v2}, {v3}, {v4})";
        }
    }
}
