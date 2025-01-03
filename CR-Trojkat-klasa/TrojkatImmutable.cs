namespace CR_Trojkat_klasa;
public class TrojkatImmutable
{
    public int A { get; }
    public int B { get; }
    public int C { get; }

    public TrojkatImmutable(int a = 1, int b = 1, int c = 1)
    {
        A = a;
        B = b;
        C = c;
        if (A <= 0 || B <= 0 || C <= 0)
        {
            throw new ArgumentOutOfRangeException("Długości boków muszą być dodatnie");
        }

        if (A + B <= C || A + C <= B || B + C <= A)
        {
            throw new ArgumentException("Nie można utworzyć trójkąta z podanych boków");
        }

    }

    public override string ToString()
    {
        string triangleType = GetTriangleType();
        string triangleSides = $"Boki trójkąta: A = {A}, B = {B}, C = {C}";
        string trianglePerimeter = $"Obwód trójkąta: {GetTrianglePerimeter()}";
        string triangleArea = $"Pole trójkąta: {GetTriangleArea()}";

        return $"{triangleSides}\n{trianglePerimeter}\n{triangleArea}\n{triangleType}";
    }

    private double GetTrianglePerimeter()
    {
        return A + B + C;
    }

    private double GetTriangleArea()
    {
        double perimeter = GetTrianglePerimeter();
        double s = perimeter / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }
    private string GetTriangleType()
    {
        string triangleType = "";

        double a2 = A * A;
        double b2 = B * B;
        double c2 = C * C;

        if (Math.Abs(a2 + b2 - c2) < 1e-10 || Math.Abs(a2 + c2 - b2) < 1e-10 || Math.Abs(b2 + c2 - a2) < 1e-10)
        {
            triangleType += "prostokątny";
        }
        else if (a2 + b2 > c2 && a2 + c2 > b2 && b2 + c2 > a2)
        {
            triangleType += "ostrokątny";

            if (A == B && B == C)
            {
                triangleType += "\ntrójkąt równoboczny";
            }
            else if (A == B || A == C || B == C)
            {
                triangleType += "\ntrójkąt równoramienny";
            }
        }
        else
        {
            triangleType += "rozwartokątny";
            if (A == B || A == C || B == C)
            {
                triangleType += "\ntrójkąt równoramienny";
            }
        }

        return triangleType;
    }
}