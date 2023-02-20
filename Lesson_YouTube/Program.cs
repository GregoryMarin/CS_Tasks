// Напишите программу, которая вычисляет среднее арифметическое двух чисел

double firstValue, secondValue;
System.Console.WriteLine("Введите первое число: ");
firstValue = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
secondValue = Convert.ToDouble(Console.ReadLine());

void Average(double n1, double n2)
{
    double result = (n1 + n2) / 2;
    double aver = Math.Round(result, 2, MidpointRounding.ToZero);
    System.Console.WriteLine($"Среднее арифметическое чисел {n1} и {n2} = {aver}");
}

Average(firstValue, secondValue);