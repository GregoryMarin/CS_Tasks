// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

void PrintArray(int[] num)
{
    System.Console.Write("Массив из сгенерированных случайных чисел: [ ");
    for (int i = 0; i < num.Length; i++)
    {
        System.Console.Write($"{num[i]}, ");
    }
    System.Console.WriteLine("]");
}

void FillArray(int[] num)
{
    Random rnd = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = rnd.Next(0, 100);
    }
}

FillArray(array);
PrintArray(array);