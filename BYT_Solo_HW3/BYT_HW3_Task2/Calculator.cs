namespace BYT_HW3_Task2;

public class Calculator
{
    private readonly double _a;
    private readonly double _b;
    private readonly char _operation;

    public Calculator(double a, double b, char operation)
    {
        _a = a;
        _b = b;
        _operation = operation;
    }

    public double Calculate()
    {
        double result;

        switch (_operation)
        {
            case '+':
                result = _a + _b;
                break;
            case '-':
                result = _a - _b;
                break;
            case '*':
                result = _a * _b;
                break;
            case '/':
                if (_b == 0) throw new DivideByZeroException("Error: Cannot divide by zero.");
                result = _a / _b;
                break;
            default:
                throw new InvalidOperationException($"Error: Unsupported operation '{_operation}'.");
        }

        if (double.IsInfinity(result))
            throw new OverflowException("Error: Calculation resulted in an overflow (Infinity).");

        if (double.IsNaN(result))
            throw new InvalidOperationException("Error: Calculation resulted in an undefined value (NaN).");

        return result;
    }
}