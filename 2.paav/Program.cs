using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of array A: ");
        int size = int.Parse(Console.ReadLine());
        int[] A = new int[size];

        Console.WriteLine("Enter the elements of array A:");
        for (int i = 0; i < size; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
        }

        int minElement = A.Min();
        int minIndex = Array.IndexOf(A, minElement);

        int[] B = A.Skip(minIndex + 1).Where(x => x % 2 != 0).ToArray();

        Array.Sort(B);

        Console.WriteLine("Array B, sorted in ascending order:");
        foreach (int element in B)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
