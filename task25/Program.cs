// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите натуральную степень числа: ");
int degree = Convert.ToInt32(Console.ReadLine());

int DegreeNumber(int num, int degr)
{
    int result = 1;
    for (int i = 0; i < degr; i++)
    {
    result = result * num;
    }
    return result;
}
int degr = DegreeNumber(number, degree);
if (degree > 0)
{
    System.Console.WriteLine($"Число {number} в {degree} степени = {degr}");
}
else
{
    System.Console.WriteLine("Число степени не натуральное или нулевое - что некорректно.");
}

