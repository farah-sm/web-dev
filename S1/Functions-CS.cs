Step 1: Setting up Visual Studio (Seminar PCs already have this installed)
Install Visual Studio: Download and install Visual Studio from the official Microsoft website (https://visualstudio.microsoft.com/).

Create a New Project:

•	Open Visual Studio.
•	Click on "Create a new project."
•	Select "Console App" from the templates.
•	Choose a name for your project (e.g., "CSharpBasicsTutorial").
•	Click "Create."
Step 2: C# Basics 
using System;

class Program
{
    static void Main()
    {
        // C# Syntax and Structure
        Console.WriteLine("Hello, C#! This is a basic console application.");

        // Control Structures
        int number = 10;

        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else
        {
            Console.WriteLine("The number is non-positive.");
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Iteration {i}");
        }
    }
}
Step 3: Functions and Methods
using System;

class Program
{
    // Functions and Methods
    static void Main()
    {
        Console.WriteLine("Hello, C#! This is a basic console application.");

        int sum = AddNumbers(5, 7);
        Console.WriteLine($"Sum: {sum}");
    }

    static int AddNumbers(int a, int b)
    {
        return a + b;
    }
}
Step 4: Object-Oriented Programming
using System;

// Object-Oriented Programming (OOP) in C#
class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name) { }

    // Overriding the MakeSound method in the derived class
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

class Program
{
    static void Main()
    {
        // Creating objects and demonstrating OOP concepts
        Animal genericAnimal = new Animal("Generic Animal");
        Cat myCat = new Cat("Whiskers");

        // Polymorphism: Same method call, different behavior
        genericAnimal.MakeSound();
        myCat.MakeSound();
    }
}
Run and Observe (For each program)
•	Save the changes in Visual Studio.
•	Press F5 or click on the "Start Debugging" button to run the program.
•	Observe the output in the console window.
This tutorial covers the basics of C# programming, including syntax, control structures, functions, and basic OOP concepts. Feel free to experiment, modify, and extend the code to deepen your understanding.
