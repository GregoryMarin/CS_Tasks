﻿// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int UserEnter(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

int[] Fibonacci(int size)
{
    int[] arr = new int[size];
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 2] + arr[i - 1];
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

int size = UserEnter("Write a size: ");
int[] array = Fibonacci(size);
PrintArray(array);


