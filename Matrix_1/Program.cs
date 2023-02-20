
// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillMatrix(int[,] matr)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = rnd.Next(1, 10);
//         }
//     }
// }

// int[,] matrix =  new int[3, 6];
// PrintMatrix(matrix);
// System.Console.WriteLine();
// FillMatrix(matrix);
// PrintMatrix(matrix);

int[] array = { 1, 14, 2, 25, 24, 46, 345, 36, 35 };
int[] result = Array.FindAll(array, i => i < 70);
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}
PrintArray(result);
