using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Class: ");
        string userClass = Console.ReadLine();

        Console.Write("Enter Roll No: ");
        string rollNo = ConvertToInt32(Console.ReadLine());

        Console.WriteLine("\n--- Student Details ---");
        Console.WriteLine("Name     : " + name);
        Console.WriteLine("Class    : " + userClass);
        Console.WriteLine("Roll No  : " + rollNo);
    }
}
