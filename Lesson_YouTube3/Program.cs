// Напишите программу которая выводит четные числа и нечетные числа из заданного диапозона, а так же выводит сумму четных чисел

System.Console.WriteLine("Введите минимальное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ввеедите максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

void Counters(int n1, int n2)
{
    int addition1 = 0;
    int addition2 = 0;
    while (n1 <= n2)
    {
        if (n1 % 2 == 0)
        {
            addition1 = addition1 + n1;
            n1++;
        }
        else
        {
            addition2 = addition2 + n1;
            n1++;
        }
    }
    System.Console.WriteLine($"Сумма четных чисел = {addition1}, сумма нечетных чисел = {addition2}");
}
Counters(minValue, maxValue);