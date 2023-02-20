Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

bool DivCheck(int number1, int number2)
{
    return number1 % number2 == 0;
}

if (DivCheck(userNumber, userNumber2))
{
    Console.WriteLine($"{userNumber}, {userNumber2} -> кратно");
}
else
{
    Console.WriteLine($"{userNumber}, {userNumber2} -> не кратно, остаток " + (userNumber % userNumber2));
}