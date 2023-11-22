using CalculatorDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        var calculator = new Calculator();

        var result1 = calculator.Calculate(new CalculationRequest("add", 10, 5));
        Console.WriteLine($"10 + 5 = {result1}");

        var result2 = calculator.Calculate(new CalculationRequest("multiply", 10, 5));
        Console.WriteLine($"10 * 5 = {result2}");

        var result3 = calculator.Calculate(new CalculationRequest("divide", 10, 5));
        Console.WriteLine($"10 / 5 = {result3}");

        var result4 = calculator.Calculate(new CalculationRequest("substract", 10, 5));
        Console.WriteLine($"10 - 5 = {result4}");
    }
}
