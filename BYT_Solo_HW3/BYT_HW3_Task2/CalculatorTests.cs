namespace BYT_HW3_Task2;

[TestFixture]
public class Tests
{
    [TestCase(5, 10, '+', 15)]
    [TestCase(20, 8, '-', 12)]
    [TestCase(7, 3, '*', 21)]
    [TestCase(10, 2.5, '*', 25)]
    [TestCase(100, 10, '/', 10)]
    [TestCase(5, 2, '/', 2.5)]
    [TestCase(10, 2.5, '/', 4)]
    [TestCase(-5, -10, '+', -15)]
    [TestCase(10, -5, '-', 15)]
    [TestCase(-7, -3, '*', 21)]
    [TestCase(-10, -5, '/', 2)]
    public void TestBasicOperations(double a, double b, char op, double expected)
    {
        Calculator calc = new Calculator(a, b, op);
        double result = calc.Calculate();
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase((10.0 / 3.0), 2, '*', 6.666666)]
    [TestCase(10, 3, '/', 3.333333)]
    public void TestRepeatingDecimalOperations(double a, double b, char op, double expected)
    {
        Calculator calc = new Calculator(a, b, op);
        double result = calc.Calculate();
        Assert.That(result, Is.EqualTo(expected).Within(0.000001));
    }

    [TestCase(10, 10, '!')]
    [TestCase(10, 10, 'a')]
    [TestCase(double.PositiveInfinity, double.PositiveInfinity, '-')]
    [TestCase(0, double.PositiveInfinity, '*')]
    public void TestInvalidOperationCases(double a, double b, char op)
    {
        Calculator calc = new Calculator(a, b, op);
        Assert.Throws<InvalidOperationException>(() => calc.Calculate());
    }

    [TestCase(10, 0, '/', typeof(DivideByZeroException))]
    [TestCase(0, 0, '/', typeof(DivideByZeroException))]
    [TestCase(double.MaxValue, 2, '*', typeof(OverflowException))]
    public void TestSpecificExceptionCases(double a, double b, char op, Type exceptionType)
    {
        Calculator calc = new Calculator(a, b, op);
        Assert.Throws(exceptionType, () => calc.Calculate());
    }
}