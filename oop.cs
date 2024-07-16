//1. Types of Class Members: Fields, Methods, Properties, Constructors, Destructors, this Keyword
//Fields
//Fields are variables declared in a class to hold data.

//Methods
//Methods are functions defined in a class to perform operations.

///Properties
//Properties are used to access and manipulate private fields in a controlled way.

//Constructors
//Constructors are special methods called when an instance of the class is created.

//Destructors
.//Destructors are special methods called when an instance of the class is destroyed (mainly used in unmanaged resources cleanup).

//this Keyword
//this refers to the current instance of the class.

//Example:

using System;

public class Person
{
    // Fields
    private string firstName;
    private string lastName;
    private int age;

    // Constructor
    public Person(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    // Property
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    // Method
    public void PrintInfo()
    {
        Console.WriteLine($"Name: {firstName} {lastName}, Age: {age}");
    }

    // Destructor
    ~Person()
    {
        // Cleanup code
    }
}


//2. Instances of Class and Structure
//Classes are reference types and instances are created using the new keyword. Structures are value types.


public class Car
{
    public string Make;
    public string Model;
}

public struct Point
{
    public int X;
    public int Y;
}

class Program
{
    static void Main()
    {
        // Creating instance of a class
        Car car = new Car { Make = "Toyota", Model = "Corolla" };

        // Creating instance of a structure
        Point point = new Point { X = 10, Y = 20 };

        Console.WriteLine($"Car: {car.Make} {car.Model}");
        Console.WriteLine($"Point: ({point.X}, {point.Y})");
    }
}



//3. Static Classes and Methods
//Static classes cannot be instantiated and contain only static members.

public static class MathUtilities
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    static void Main()
    {
        int sum = MathUtilities.Add(5, 10);
        int product = MathUtilities.Multiply(5, 10);

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Product: {product}");
    }
}




//4. Encapsulation
//Encapsulation is the process of restricting access to certain details of an object, usually by making fields private and providing access through public properties or methods.

public class BankAccount
{
    private double balance;

    public double Balance
    {
        get { return balance; }
        private set { balance = value; }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
        }
    }
}




//5. Passing Objects to Methods

public class Calculator
{
    public void IncreaseAge(Person person)
    {
        person.Age += 1;
    }
}



//6. Ways of Passing Arguments to Methods
//By Value (default): A copy of the argument is passed.
//By Reference (ref): A reference to the argument is passed.
//Output Parameters (out): Similar to ref, but the called method must assign a value.
//Parameter Arrays (params): Allows passing a variable number of arguments.

public class MathOperations
{
    public void Increment(ref int number)
    {
        number++;
    }

    public void CalculateSum(out int sum, int a, int b)
    {
        sum = a + b;
    }

    public void PrintNumbers(params int[] numbers)
    {
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}



//7. Partial Types
//Partial types allow splitting the definition of a class, struct, or interface across multiple files.


//File 1: Person.Part1.cs

public partial class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

//File 2: Person.Part2.cs


//public partial class Person
{
    public int Age { get; set; }

    public void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }
}






Main Program:


class Program
{
    static void Main()
    {
        Person person = new Person
        {
            FirstName = "John",
            LastName = "Doe",
            Age = 30
        };

        person.PrintFullName();
        Console.WriteLine($"Age: {person.Age}");
    }
}