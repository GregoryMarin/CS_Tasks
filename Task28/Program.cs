// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Multiply(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i;
    }
    return result;
}

System.Console.WriteLine($"Произведение чисел от 1 до {number} = {Multiply(number)}" );
