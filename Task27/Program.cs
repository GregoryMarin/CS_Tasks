// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Number(int num)
{
    int result = 0;
    while(num != 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}

int num = Number(number);
System.Console.WriteLine($"Результат сложения цифр в числе: {num}");