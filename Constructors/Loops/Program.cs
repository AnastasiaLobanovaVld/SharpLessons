using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the number: ");
        int number = Int32.Parse(Console.ReadLine());

        int sum = GetSum(number);
        Console.WriteLine("Sum of digits: " + sum);

        static int GetSum(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10; // Delete the last digit
            }

            return sum;
        }
    }
}
