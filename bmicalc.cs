#BMICalculator Class:

using System;

public class BMICalculator
{
    public double CalculateBMI(double weight, double height)
    {
        if (weight <= 0 || height <= 0)
        {
            throw new ArgumentException("Weight and height must be positive numbers.");
        }

        // Convert height from cm to meters
        height = height / 100.0;

        // Calculate BMI using the formula: weight / (height * height)
        double bmi = weight / (height * height);

        return bmi;
    }

    public string GetBMICategory(double bmi)
    {
        if (bmi < 16)
        {
            return "acute weight loss";
        }
        else if (bmi < 18.5)
        {
            return "underweight";
        }
        else if (bmi < 25)
        {
            return "normal weight";
        }
        else if (bmi < 30)
        {
            return "overweight";
        }
        else if (bmi < 35)
        {
            return "obesity (Class 1)";
        }
        else if (bmi < 40)
        {
            return "obesity (Class 2)";
        }
        else
        {
            return "morbid obesity";
        }
    }

    public double CalculateIdealWeight(double height)
    {
        // Convert height from cm to meters
        height = height / 100.0;

        // Calculate ideal weight for BMI of 25
        return 25 * height * height;
    }

    public double CalculateWeightChange(double weight, double idealWeight)
    {
        // Calculate weight change needed
        return idealWeight - weight;
    }
}




#Program
using System;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter your weight (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your height (cm): ");
            double height = Convert.ToDouble(Console.ReadLine());

            BMICalculator calculator = new BMICalculator();
            double bmi = calculator.CalculateBMI(weight, height);

            Console.WriteLine($"Your BMI = {bmi:f2}, which means you are {calculator.GetBMICategory(bmi)}.");

            if (bmi < 18.5 || bmi >= 25)
            {
                double idealWeight = calculator.CalculateIdealWeight(height);
                double weightChange = calculator.CalculateWeightChange(weight, idealWeight);

                if (bmi < 18.5)
                {
                    Console.WriteLine($"You need to gain at least {Math.Abs(weightChange):f2} kg.");
                }
                else
                {
                    Console.WriteLine($"You need to lose at least {Math.Abs(weightChange):f2} kg.");
                }
            }
            else
            {
                Console.WriteLine("You have a normal weight. Congratulations!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid numbers for weight and height.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
