namespace AreaCalcLib;

public class CalculatorFactory
{
    private readonly double[] args;
    private readonly IDictionary<int, ICalc> calculators = new Dictionary<int, ICalc>();
    public CalculatorFactory(params double[] args)
    {
        this.args = args;
        if (args.Length <= 0) return;
        calculators.Add(1, new CircleAreaCalculator(args.First()));

        if (args.Length == 3)
        {
            calculators.Add(3, new TriangleAreaCalculator(args[0], args[1], args[2]));
        }
    }

    public double Calculate()
    {
        calculators.TryGetValue(args.Length, out var calculator);
        if (calculator != null)
        {
            return calculator.Calculate();
        }

        throw new Exception("Not found calculator");
    }
}