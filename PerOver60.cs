
#Person Class

using System;
# Encapsulates the concept of a person with an age pr

{
    public int Age { get; private set; }

    public Person(int age)
    {
        SetAge(age);
    }


# Provides a method SetAge 
    public void SetAge(int age)
    {
        if (age < 0)
        {
            throw new ArgumentException("Age cannot be negative.");
        }
        Age = age;
    }

#baced on age
    public string DeterminePersonality()
    {
        if (Age >= 65)
        {
            return "Pensioner";
        }
        else if (Age >= 18)
        {
            return "Adult";
        }
        else if (Age >= 13)
        {
            return "Teenager";
        }
        else
        {
            return "Child";
        }
    }
}


#Program Class

using System;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Person person = new Person(age);
            string personality = person.DeterminePersonality();

            Console.WriteLine($"Based on the age of {age}, the person is a {personality}.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid age as a number.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}