// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

System.Console.WriteLine("Введите чило: ");
int number = Convert.ToInt32(Console.ReadLine());

int CountNumbers(int num)
{
    int count = 0;
    while (num > 0)
    {
        count = count + 1;
        num = num / 10;
    }
    return count;
}
int result = CountNumbers(number);
System.Console.WriteLine(result);