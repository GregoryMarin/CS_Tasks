// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int UserEnter(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] SummFibo(int size)
{
    int[] result = new int[size];
    result[1] = 1;
    for (int i = 2; i < size; i++)
    {
        result[i] = result[i - 2] + result[i - 1];
    }
    return result;
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

int size = UserEnter("Введите число: ");
int[] res = SummFibo(size);
PrintArray(res);
