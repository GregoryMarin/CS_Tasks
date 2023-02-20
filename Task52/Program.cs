// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int UserEnter(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrix(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] Average(int[,] matrix)
{
    double[] columnAverage = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int summ = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summ += matrix[i, j];
        }
        columnAverage[j] = (double)summ / matrix.GetLength(1);
    }
    return columnAverage;
}

void PrintArray(double[] array)
{
    double[] arr = new double[array.Length];
    Console.Write("Average of columns: ");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = Math.Round(array[i], 1, MidpointRounding.ToZero);
        Console.Write($"{i + 1} = {arr[i]}");
        if (i < array.Length - 1) Console.Write("; ");
    }
    Console.WriteLine("]");
}

int rowSize = UserEnter("Enter the row size: ");
int columnSize = UserEnter("Enter the column size: ");
int[,] matrix = new int[rowSize, columnSize];


Console.WriteLine();
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

double[] averageColumns = Average(matrix);
PrintArray(averageColumns);