/* 
System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsSquare(number1, number2) ? "да" : "нет");

bool IsSquare(int n1, int n2)
{
    return n1 / n2 == n2 || n2 / n1 == n1;
} */
/* 16. Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

Console.WriteLine("Введите первое число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Square(numb1, numb2) ? "Yes" : "No");

bool Square (int n1, int n2)
{
    return n1 / n2 == n2 || n2 / n1 == n1;
}