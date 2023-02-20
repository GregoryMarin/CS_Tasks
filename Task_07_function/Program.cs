/* Напишите число, которое на вход принимает 3-х значное число, а на выходе выдает последнюю цифру числа */

Console.WriteLine("Введите 3-х значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    Console.WriteLine($"Последняя цифра числа {number} = {number % 10}");
}
else
{
    Console.Write("Некорректные данные");
}