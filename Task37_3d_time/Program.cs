// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int UserEnter(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

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

int[] CreateArray(int size, int min, int max)
{
    Random rnd = new Random();
    int[] rndArray = new int[size];
    for (int i = 0; i < rndArray.Length; i++)
    {
        rndArray[i] = rnd.Next(min, max);
    }
    return rndArray;
}

int[] MultRndArray(int[] arr)
{
    int size = (arr.Length % 2 == 0) ? arr.Length / 2 : arr.Length / 2 + 1;
    int[] multArr = new int[size];
    if (arr.Length % 2 != 0) multArr[multArr.Length - 1] = arr[arr.Length / 2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        multArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return multArr;
}

int size = UserEnter("Введите размер массива: ");
int minValue = UserEnter("Введите минимальное значение: ");
int maxValue = UserEnter("Введите максимальное значение: ");

int[] array = CreateArray(size, minValue, maxValue);
int[] multArr = MultRndArray(array);

PrintArray(array);
Console.WriteLine(" -> ");
PrintArray(multArr);