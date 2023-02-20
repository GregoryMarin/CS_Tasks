// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArray(int size, int min, int max)
{
    Random rnd = new Random();
    int[] fillArray = new int[size];
    for (int i = 0; i < fillArray.Length; i++)
    {
        fillArray[i] = rnd.Next(min, max);
    }
    return fillArray;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

int UserEnter(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] MultiplyArrNumbers(int[] arr)
{
    int sizeArr = (arr.Length % 2 == 0) ? arr.Length / 2 : arr.Length / 2 + 1;
    int[] newArray = new int[sizeArr];
    if (arr.Length % 2 != 0) newArray[newArray.Length - 1] = arr[arr.Length / 2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        newArray[i] = arr[i] * arr[arr.Length - 1 - i]; 
    }
    return newArray;
}

int size = UserEnter("Введите размер массива: ");
int minValue = UserEnter("Введите минимальное значение массива: ");
int maxValue = UserEnter("Введите максичальное значение массива: ");

int[] array = CreateArray(size, minValue, maxValue);
int[] resArray = MultiplyArrNumbers(array);

PrintArray(array);
Console.Write(" -> ");
PrintArray(resArray);


