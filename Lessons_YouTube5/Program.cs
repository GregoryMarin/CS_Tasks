
int number1 = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < number1; i++)
{
    Console.SetCursorPosition(number1 - i, i + 1);
    for (int j = 0; j <= i; j++)
    {
        Console.Write("#");
    }
}