using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows in the matrix: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns in the matrix: ");
        int columns = int.Parse(Console.ReadLine());

        double[,] matrix = new double[rows, columns];
        double[] vector = new double[columns];
        double[] result = new double[rows];

        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter the elements of the vector:");
        for (int i = 0; i < columns; i++)
        {
            Console.Write($"Element [{i}]: ");
            vector[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < rows; i++)
        {
            result[i] = 0;
            for (int j = 0; j < columns; j++)
            {
                result[i] += matrix[i, j] * vector[j];
            }
        }

        Console.WriteLine("The result of the matrix-vector multiplication is:");
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}
