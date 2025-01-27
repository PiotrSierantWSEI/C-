using System;
using System.Drawing;

namespace FiguresLib
{
    public class Point : Figure, IEquatable<Point>, IMoveable
    {
        // fields
        public readonly double X, Y; //immutability

        // constructor
        public Point(double x = 0, double y = 0)
        {
            X = Math.Round(x, Figure.FRACTIONAL_DIGITS);
            Y = Math.Round(y, Figure.FRACTIONAL_DIGITS);
            Color = Color.Blue;
        }

        public override void Draw()
        {
            Console.WriteLine("drawing: " + $"Point({X}, {Y}), {Color}");
        }

        public override string ToString() => $"Point({X},{Y})";

        #region implementation of IEquatable<Point>
        // https://docs.microsoft.com/en-us/dotnet/api/system.object.equals?view=netstandard-2.0
        public bool Equals(Point other) => (other is null) ? false : (this.X == other.X && this.Y == other.Y);
        public override bool Equals(Object obj)
        {
            if (!this.GetType().Equals(obj.GetType())) return false;

            return this.Equals((Point)obj);
        }

        public override int GetHashCode() => unchecked(((int)X << 2) ^ (int)Y);

        static public bool operator ==(Point p1, Point p2)
        {
            if (p1 is null && p2 is null) return true;
            if (p1 is null && !(p2 is null)) return false;

            //p1 != null
            return p1.Equals(p2);
        }
        static public bool operator !=(Point p1, Point p2) => !(p1 == p2);
        #endregion

        void IMoveable.Move(Vector vector)
        {
            throw new NotSupportedException("Cannot move an immutable Point. Create a new Point instead.");
        }

        public Point Move(Vector vector)
        {
            return new Point(X + vector.X, Y + vector.Y);
        }
    }
}