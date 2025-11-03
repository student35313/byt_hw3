using BYT_HW3_Task2;


Console.WriteLine("--- Calculator Demonstration ---");

Calculator calc1 = new Calculator(20, 10, '+');
Console.WriteLine($"Calculation 1 (Add): 20 + 10 = {calc1.Calculate()}");

Calculator calc2 = new Calculator(10, 3, '/');
Console.WriteLine($"Calculation 2 (Divide): 10 / 3 = {calc2.Calculate():F5}");

Calculator calc3 = new Calculator(7, 3, '*');
Console.WriteLine($"Calculation 3 (Multiply): 7 * 3 = {calc3.Calculate()}");

Calculator calc4 = new Calculator(100, 15.5, '-');
Console.WriteLine($"Calculation 4 (Subtract): 100 - 15.5 = {calc4.Calculate()}");

Calculator calc5 = new Calculator(-10, -5, '/');
Console.WriteLine($"Calculation 5 (Negatives): -10 / -5 = {calc5.Calculate()}");

Calculator calc6 = new Calculator(5, 2, '/');
Console.WriteLine($"Calculation 6 (Remainder): 5 / 2 = {calc6.Calculate()}");

Console.WriteLine("\n--- Demonstration Complete ---");