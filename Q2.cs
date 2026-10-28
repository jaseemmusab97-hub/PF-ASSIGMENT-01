using System;

class Question2
{
    static void Main()
    {
        Console.WriteLine("Class ID: YOUR_CLASS_ID");
        Console.WriteLine("Registration ID: 66455");
        Console.WriteLine("Name: Musab Bin Jaseem");
        Console.WriteLine("Submission Date: 28-10-2026");
        Console.WriteLine("--------------------------------");

        Console.Write("Enter purchase amount: ");
        double amount;
        if (!double.TryParse(Console.ReadLine(), out amount) || amount < 0)
        {
            Console.WriteLine("Invalid purchase amount");
            return;
        }

        double discountPercentage;
        if (amount >= 5000)
            discountPercentage = 20;
        else if (amount >= 2000)
            discountPercentage = 10;
        else
            discountPercentage = 0;

        double discountAmount = amount * discountPercentage / 100;
        double finalAmount = amount - discountAmount;

        Console.WriteLine("Discount Percentage: " + discountPercentage + "%");
        Console.WriteLine("Discount Amount: " + discountAmount);
        Console.WriteLine("Final Payable Amount: " + finalAmount);
    }
}
