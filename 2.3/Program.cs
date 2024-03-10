using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose the formula to calculate z:");
        Console.WriteLine("1 - first, First, FIRST");
        Console.WriteLine("2 - Second, second, SECOND");
        Console.WriteLine("3 - Third, third, THIRD");
        string choice = Console.ReadLine().ToLower();

        double z = 0;
        switch (choice)
        {
            case "1":
            case "first":
            case "FIRST":
                z = Math.Pow(Math.Sin(x), 2);
                break;
            case "2":
            case "second":
            case "SECOND":
                z = Math.Pow(Math.Log(x),2);
                break;
            case "3":
            case "third":
            case "THIRD":
                z = 1 / Math.Cos(Math.Pow(x, 3));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        Console.WriteLine($"The calculated value of z is: {z}");
    }
}
