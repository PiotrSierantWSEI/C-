namespace CR_Trojkat_klasa;
public class TrojkatMutable
{
    private int _a, _b, _c;
    public int A
    {
        get => _a;
        set
        {
            try {
                ScaleTriangle(value, "a");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }

    public int B
    {
        get => _b;
        set
        {
            try {
                ScaleTriangle(value, "b");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }

    public int C
    {
        get => _c;
        set
        {
            try {
                ScaleTriangle(value, "c");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }

    public TrojkatMutable(int a = 1, int b = 1, int c = 1)
    {
        ValidateTriangle(a, b, c);
        _a = a;
        _b = b;
        _c = c;
    }

    private static void ValidateTriangle(int a, int b, int c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentOutOfRangeException("Długości boków muszą być dodatnie.");
        }

        if (a + b <= c || a + c <= b || b + c <= a)
        {
            throw new ArgumentException("Nie można utworzyć trójkąta z podanych boków.");
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
    private void ScaleTriangle(int newSide, string sideName)
    {
        double scale;
        int newA = _a, newB = _b, newC = _c;

        switch (sideName.ToLower())
        {
            case "a":
                scale = (double)newSide / _a;
                newA = newSide;
                newB = (int)(_b * scale);
                newC = (int)(_c * scale);
                break;

            case "b":
                scale = (double)newSide / _b;
                newB = newSide;
                newA = (int)(_a * scale);
                newC = (int)(_c * scale);
                break;

            case "c":
                scale = (double)newSide / _c;
                newC = newSide;
                newA = (int)(_a * scale);
                newB = (int)(_b * scale);
                break;

            default:
                throw new ArgumentException("Niepoprawna nazwa boku trójkąta.");
        }

        if (newA <= 0 || newB <= 0 || newC <= 0)
        {
            throw new ArgumentOutOfRangeException("Długości boków muszą być dodatnie.");
        }

        if (newA + newB <= newC || newA + newC <= newB || newB + newC <= newA)
        {
            throw new ArgumentException("Nie można utworzyć trójkąta z podanych boków.");
        }

        _a = newA;
        _b = newB;
        _c = newC;
    }

    public void ScaleTriangle(double scale) {
        if (scale <= 0)
        {
            throw new ArgumentOutOfRangeException("Skala musi być dodatnia.");
        }
        _a = (int)(_a * scale);
        _b = (int)(_b * scale);
        _c = (int)(_c * scale);
    }
}