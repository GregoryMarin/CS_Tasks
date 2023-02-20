// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int UserEnter(string text)
{
    Console.WriteLine(text);
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

int rowSize = UserEnter("Enter a row size: ");
int columnSize = UserEnter("Enter a column size: ");

int[,] matrix = new int[rowSize, columnSize];

FillMatrix(matrix);
PrintMatrix(matrix);

int rowValue = UserEnter("Enter a row value of number: ");
int columnValue = UserEnter("Enter a column value of number: ");

if (rowValue > rowSize && columnValue > columnSize 
    || rowValue < rowSize && columnValue > columnSize 
    || rowValue > rowSize && columnValue < columnSize )
    {
        Console.WriteLine($"{rowValue}, {columnValue}  - ther's no value.");
    }
else Console.WriteLine($"{matrix[rowValue, columnValue]}");
