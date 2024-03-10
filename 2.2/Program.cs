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
        double[] rowAverages = new double[rows];

        for (int i = 0; i < rows; i++)
        {
            double sum = 0;
            Console.WriteLine($"Enter elements for row {i + 1}:");
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = double.Parse(Console.ReadLine());
                sum += matrix[i, j];
            }
            rowAverages[i] = sum / columns;
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] *= rowAverages[i];
            }
        }

        Console.WriteLine("New matrix after multiplication with row averages:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
