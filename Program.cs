using System;

public record Student(string Name, int Age, string Grade, string Course)
{
    // Method to greet, accessing the Name property
    public void Greet()
    {
        Console.WriteLine($"Hello, {Name}!");
    }

    // Method to simulate studying, displaying the Course
    public void Study()
    {
        Console.WriteLine($"I am studying {Course}.");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Student object
        var student = new Student("Excel", 26, "A", "Computer Science");

        // Calling methods
        student.Greet();  // Greeting the student
        student.Study();  // Showing what the student is studying
    }
}
