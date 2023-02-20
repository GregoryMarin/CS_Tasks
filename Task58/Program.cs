// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int UserEnter(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateMatrixRnd(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],2}");
            if (j < matr.GetLength(1) - 1) Console.Write(", ");
        }
        Console.WriteLine("] ");
    }
}
int[,] MultiplyMatrix1(int[,] matr1, int[,] matr2)
{
    int[,] resultMultiply = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr2.GetLength(0); k++)
            {
                resultMultiply[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    return resultMultiply;
}

int row = UserEnter("Write a row value: ");
int column = UserEnter("Write a column value: ");
int row2 = UserEnter("Write a row2 value: ");
int column2 = UserEnter("Write a column2 value: ");

int[,] matrix = CreateMatrixRnd(row, column);
int[,] matrix2 = CreateMatrixRnd(row2, column2);

if (matrix.GetLength(0) == matrix2.GetLength(1) && matrix.GetLength(1) == matrix2.GetLength(0))
{
    PrintMatrix(matrix);
    System.Console.WriteLine();
    PrintMatrix(matrix2);
    System.Console.WriteLine();
    int[,] matrixResult = MultiplyMatrix1(matrix, matrix2);
    PrintMatrix(matrixResult);
}
else
{
    Console.WriteLine("matrix row != matrix2 column! ");
}