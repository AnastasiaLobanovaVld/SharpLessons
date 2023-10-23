using System;
using Constructors;

public class Program
{
    public static void Main()
    {
        Multicooker ninja1 = new Multicooker();
        ninja1.Model = "JHGDJvu";
        ninja1.PrintInfo();

        Multicooker ninja2 = new Multicooker("NNN", null);
        ninja2.PrintInfo();

        Console.WriteLine("Multicooker");
        Console.WriteLine();

        Multicooker ninja = new Multicooker("Ninja Foodi Max");
        Multicooker philips = new Multicooker();
        philips.Model = "Philips Ovi Smart";
        philips.Wattage = 2225;
        philips.ProductWeight = 7990;

        ninja.PrintInfo();
        ninja.StartCooking();

        Console.WriteLine();
        philips.PrintInfo();
        philips.SubmitForRepair(1);

        //
        Console.WriteLine();
        Console.WriteLine("Students");
        Console.WriteLine();

        Student mark = new Student("Mark", "Erler", 20, 11);
        Student rich = new Student("Rich", "West", 21, 12);
        Console.WriteLine(mark);
        Console.WriteLine(rich);

        StudentGroup group = new StudentGroup("F1");
        group.AddStudent(mark);
        group.AddStudent(rich); 
        group.GetStudents();
    } 
}