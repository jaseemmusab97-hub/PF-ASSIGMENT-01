using System;

class Question3
{
    static void Main()
    {
        Console.WriteLine("Class ID: YOUR_CLASS_ID");
        Console.WriteLine("Registration ID: 66455");
        Console.WriteLine("Name: Musab Bin Jaseem");
        Console.WriteLine("Submission Date: 28-10-2026");
        Console.WriteLine("--------------------------------");

        Console.Write("Enter a year: ");
        int year;
        if (!int.TryParse(Console.ReadLine(), out year))
        {
            Console.WriteLine("Invalid year");
            return;
        }

        if (year % 400 == 0)
            Console.WriteLine("Leap Year");
        else if (year % 100 == 0)
            Console.WriteLine("Not a Leap Year");
        else if (year % 4 == 0)
            Console.WriteLine("Leap Year");
        else
            Console.WriteLine("Not a Leap Year");
    }
}
