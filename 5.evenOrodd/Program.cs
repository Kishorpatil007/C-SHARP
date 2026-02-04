using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine("\nThe number is Even");
        else
            Console.WriteLine("\nThe number is Odd");
    }
}
