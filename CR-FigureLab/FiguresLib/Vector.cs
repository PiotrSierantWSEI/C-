namespace FiguresLib
{
    public struct Vector
    {
        public double X { get; }
        public double Y { get; }

        public Vector(double x, double y)
        {
            X = Math.Round(x, Figure.FRACTIONAL_DIGITS);
            Y = Math.Round(y, Figure.FRACTIONAL_DIGITS);
        }

        public override string ToString()
        {
            return $"[{X}, {Y}]";
        }

        // Dodawanie dwóch wektorów (opcjonalnie, dla wygody operacji)
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }
    }
}