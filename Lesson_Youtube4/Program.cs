System.Console.Write("Введите высору прямоугольниика: ");
int height = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите ширину прямоугольника: ");
int width = Convert.ToInt32(Console.ReadLine());

for (int j = 0; j < height; j++)
{
    for (int i = 0; i < width; i++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}
    