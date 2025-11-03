namespace BYT_HW3_Task2;

public class Calculator(double a, double b, char operation)
{
    public double Calculate()
    {
        double result = operation switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' => b == 0 ? throw new DivideByZeroException("Error: Cannot divide by zero.") : a / b,
            _ => throw new InvalidOperationException($"Error: Unsupported operation '{operation}'.")
        };

        if (double.IsInfinity(result))
            throw new OverflowException("Error: Calculation resulted in an overflow (Infinity).");

        if (double.IsNaN(result))
            throw new InvalidOperationException("Error: Calculation resulted in an undefined value (NaN).");

        return result;
    }
}