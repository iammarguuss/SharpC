using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value for x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the value for a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        double y = Math.Pow(3 * (Math.Sqrt(x - a) + Math.Log(x) / (2 * Math.Sin(Math.PI / (3 + x)))), 1.0 / 3);

        Console.WriteLine("The value of the function is: " + y);
    }
}
