using System;

public class Program
{
    public static void Main()
    {
        //Even or not
        Console.WriteLine("Enter the number: ");
        try
        {
            int input = Int32.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Not even");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("God knows what but not a number is entered");
        }

        //Inch into centimeters
        Console.WriteLine("The number of inches to convert into centimeters:");
        int number = Int32.Parse(Console.ReadLine());

        double inch = 2.54;
        double centimeters = number * inch;
        Console.WriteLine($"In centimeters it is: {centimeters}");
    }
}