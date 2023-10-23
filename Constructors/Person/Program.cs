using PersonConstructor;
using System;

public class Program
{
    public static void Main()
    {
        Person person = new Person("Mark", 30, "Male", "+380874567338");
        person.FirstName = "John";

        person.Print();
        person.SetAge(35);
        person.SetPhoneNumber("+380987633566");
        Console.WriteLine("\nUpdated info:");
        person.Print();
    }
}
