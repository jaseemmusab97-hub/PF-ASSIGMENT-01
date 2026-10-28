using System;

class Question4
{
    static void Main()
    {
        Console.WriteLine("Class ID: YOUR_CLASS_ID");
        Console.WriteLine("Registration ID: 66455");
        Console.WriteLine("Name: Musab Bin Jaseem");
        Console.WriteLine("Submission Date: 28-10-2026");
        Console.WriteLine("--------------------------------");

        Console.Write("Enter first number: ");
        double a;
        if (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Invalid number");
            return;
        }

        Console.Write("Enter operator (+, -, *, /): ");
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input) || input.Length != 1)
        {
            Console.WriteLine("Invalid operator");
            return;
        }
        char op = input[0];

        Console.Write("Enter second number: ");
        double b;
        if (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Invalid number");
            return;
        }

        switch (op)
        {
            case '+':
                Console.WriteLine("Result = " + (a + b));
                break;
            case '-':
                Console.WriteLine("Result = " + (a - b));
                break;
            case '*':
                Console.WriteLine("Result = " + (a * b));
                break;
            case '/':
                if (b != 0)
                    Console.WriteLine("Result = " + (a / b));
                else
                    Console.WriteLine("Cannot divide by zero");
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
        }
    }
}
