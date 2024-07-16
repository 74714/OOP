using System;

public class Calculator
{
    // 1. Sum and multiplication of whole numbers
    public void CalculateSumAndProduct(int n1, int n2)
    {
        long sum = 0;
        long product = 1;

        for (int i = n1; i <= n2; i++)
        {
            sum += i;
            product *= i;
        }

        Console.WriteLine($"1. Sum of whole numbers from {n1} to {n2}: {sum}");
        Console.WriteLine($"   Multiplication of whole numbers from {n1} to {n2}: {product}");
    }

    // 2. Sum of every 3-digit number
    public void CalculateSumOfThreeDigitNumbers(int n1, int n2)
    {
        long sumThreeDigit = 0;

        for (int i = n1; i <= n2; i++)
        {
            if (i >= 100 && i <= 999)
            {
                sumThreeDigit += i;
            }
        }

        Console.WriteLine($"2. Sum of every 3-digit number from {n1} to {n2}: {sumThreeDigit}");
    }

    // 3. Multiplication of every 2-digit number
    public void CalculateMultiplicationOfTwoDigitNumbers(int n1, int n2)
    {
        long productTwoDigit = 1;

        for (int i = n1; i <= n2; i++)
        {
            if (i >= 10 && i <= 99)
            {
                productTwoDigit *= i;
            }
        }

        Console.WriteLine($"3. Multiplication of every 2-digit number from {n1} to {n2}: {productTwoDigit}");
    }

    // 4. Calculate 1.1 * 1.2 * 1.3 * ... * 2
    public void CalculateSeriesProduct()
    {
        double productSeries = 1.0;

        for (double i = 1.1; i <= 2; i += 0.1)
        {
            productSeries *= i;
        }

        Console.WriteLine($"4. Product of the series 1.1 * 1.2 * ... * 2: {productSeries}");
    }

    // 5. A ^ n
    public void CalculatePower(double a, int n)
    {
        double result = Math.Pow(a, n);
        Console.WriteLine($"5. {a}^{n} = {result}");
    }

    // 6. N!
    public void CalculateFactorial(int n)
    {
        if (n < 0)
        {
            Console.WriteLine("6. Factorial cannot be calculated for negative numbers.");
            return;
        }

        long factorial = 1;

        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"6. {n}! = {factorial}");
    }

    // 7. Average of 5 numbers
    public void CalculateAverage(params double[] numbers)
    {
        if (numbers.Length != 5)
        {
            Console.WriteLine("7. Please enter exactly 5 numbers.");
            return;
        }

        double sum = 0;

        foreach (var num in numbers)
        {
            sum += num;
        }

        double average = sum / 5;

        Console.WriteLine($"7. Average of the 5 numbers: {average}");
    }

    // 8. Calculate square and cube values in range (1 to N)
    public void CalculateSquareAndCubeValues(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            long square = i * i;
            long cube = i * i * i;
            Console.WriteLine($"8. For {i}: Square = {square}, Cube = {cube}");
        }
    }

    // 9. A ^ x for x in range (1 to N)
    public void CalculatePowerSeries(double a, int n)
    {
        for (int i = 1; i <= n; i++)
        {
            double result = Math.Pow(a, i);
            Console.WriteLine($"9. {a}^{i} = {result}");
        }
    }

    // 10. Sum of A ^ x for x in range (1 to N)
    public void CalculateSumOfPowerSeries(double a, int n)
    {
        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += Math.Pow(a, i);
        }

        Console.WriteLine($"10. Sum of {a}^x for x in range (1 to {n}): {sum}");
    }

    // 11. Sum of 1 + 1/2 + 1/3 + ... + 1/N
    public void CalculateHarmonicSeries(int n)
    {
        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / i;
        }

        Console.WriteLine($"11. Sum of harmonic series (1 + 1/2 + ... + 1/{n}): {sum}");
    }
}





using System;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter the starting number (n1): ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the ending number (n2): ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter A for power calculations: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter n for power calculations: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Calculator calculator = new Calculator();

            calculator.CalculateSumAndProduct(n1, n2);
            calculator.CalculateSumOfThreeDigitNumbers(n1, n2);
            calculator.CalculateMultiplicationOfTwoDigitNumbers(n1, n2);
            calculator.CalculateSeriesProduct();
            calculator.CalculatePower(a, n);
            calculator.CalculateFactorial(n);
            calculator.CalculateAverage(1, 2, 3, 4, 5); // Example numbers for average calculation
            calculator.CalculateSquareAndCubeValues(n);
            calculator.CalculatePowerSeries(a, n);
            calculator.CalculateSumOfPowerSeries(a, n);
            calculator.CalculateHarmonicSeries(n);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid numbers for n1, n2, A, and n.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
