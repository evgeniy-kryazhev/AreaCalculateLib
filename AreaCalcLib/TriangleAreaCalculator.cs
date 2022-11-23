namespace AreaCalcLib;

public class TriangleAreaCalculator : ICalc
{
    public bool IsRectangular => a * a + b * b == c * c;

    private readonly double a;
    private readonly double b;
    private readonly double c;

    public TriangleAreaCalculator(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    
    public double Calculate()
    {
        var p = (a + b + c) / 2;
        var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return s;
    }
}