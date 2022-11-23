namespace AreaCalcLib;

public class CircleAreaCalculator : ICalc
{
    private readonly double radius;
    
    public CircleAreaCalculator(double radius)
    {
        this.radius = radius;
    }
    
    public double Calculate()
    {
        return radius * 3.142;
    }
}