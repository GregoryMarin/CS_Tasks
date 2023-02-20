// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// 1) Создаем двумерный массив
// 2) переводим двумерный м в одномерный
// 3) сортируем по возростанию
// 4) выводим сколько каких цифр

int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j], 3}");
            if (j < matrix.GetLength(1) - 1) Console.Write(", ");
        }
        Console.WriteLine("  ]");
    }
    Console.WriteLine();
}
int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i * matrix.GetLength(1) + j] = matrix[i, j];
        }
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i], 3}");
        if (i < array.Length -1) Console.Write(",");
    }
    Console.WriteLine("  ]");
}
void DictionaryCounter(int[] array)
{
    int counter = 1;
    int num = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == num)
            counter++;
        else
        {
            Console.WriteLine($"The number {num} is {counter} in array");
            counter = 1;
            num = array[i];
        }
    }
    Console.WriteLine($"The number {num} is {counter} in array");
}

int[,] matrix = CreateMatrix(3, 3, 1, 7);
int[] array = MatrixToArray(matrix);

PrintMatrix(matrix);
PrintArray(array);
Array.Sort(array);
PrintArray(array);

DictionaryCounter(array);