#Country Class

using System;

public class Country
{
    public string CountryName { get; }
    public double Population { get; }
    public double Area { get; }

    public Country(string name, double population, double area)
    {
        CountryName = name;
        Population = population;
        Area = area;
    }

    public void PrintInformation()
    {
        Console.WriteLine($"Country: {CountryName}");
        Console.WriteLine($"Population: {Population} million");
        Console.WriteLine($"Area: {Area} sq. km");
    }
}


#Student Class with Private Fields and Properties

using System;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    private DateTime DateOfBirth { get; set; }
    private string Gender { get; set; }
    private string SchoolName { get; set; }
    private string Faculty { get; set; }
    private string Major { get; set; }
    private int Course { get; set; }
    private int[] Grades { get; set; }

    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = DateTime.Now.AddYears(-20); // Default value for example
        Gender = "Male"; // Default value for example
        SchoolName = "ABC School"; // Default value for example
        Faculty = "Engineering"; // Default value for example
        Major = "Computer Science"; // Default value for example
        Course = 3; // Default value for example
        Grades = GenerateRandomGrades();
    }

    public void PrintInformation()
    {
        Console.WriteLine($"Student: {FirstName} {LastName}");
        Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Gender: {Gender}");
        Console.WriteLine($"School: {SchoolName}");
        Console.WriteLine($"Faculty: {Faculty}");
        Console.WriteLine($"Major: {Major}");
        Console.WriteLine($"Course: {Course}");
        Console.WriteLine("Grades:");

        for (int i = 0; i < Grades.Length; i++)
        {
            Console.WriteLine($"Subject {i + 1}: {Grades[i]}");
        }

        Console.WriteLine($"Average Grade: {CalculateAverageGrade():F2}");
    }

    private int[] GenerateRandomGrades()
    {
        Random random = new Random();
        int[] grades = new int[10];

        for (int i = 0; i < grades.Length; i++)
        {
            grades[i] = random.Next(51, 101); // Random grade between 51 and 100 inclusive
        }

        return grades;
    }

    public double CalculateAverageGrade()
    {
        double sum = 0;

        foreach (var grade in Grades)
        {
            sum += grade;
        }

        return sum / Grades.Length;
    }
}


#Program

using System;

class Program
{
    static void Main()
    {
        // Demonstration of Country class
        Console.WriteLine("Country Information:");
        Country country = new Country("United States", 328.2, 9833520);
        country.PrintInformation();
        Console.WriteLine();

        // Demonstration of Student class
        Console.WriteLine("Student Information:");
        Student student1 = new Student("Smith", "John", 101, 3.8);
        student1.PrintInformation();
        Console.WriteLine();

        Student student2 = new Student("Johnson", "Anna", 102, 4.0);
        student2.PrintInformation();
        Console.WriteLine();

        // Finding student with the highest GPA
        Console.WriteLine("Student with the highest GPA:");
        Student topStudent = (student1.GPA > student2.GPA) ? student1 : student2;
        topStudent.PrintInformation();
        Console.WriteLine();

        // Demonstration of Student class with private fields and properties
        Console.WriteLine("Student Information with Private Fields:");
        Student student3 = new Student("Doe", "Jane");
        student3.PrintInformation();
    }
}