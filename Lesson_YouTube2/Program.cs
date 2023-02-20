// Введите три числа и выведите на экран значение суммы и произведения этих чисел

double firstNumber, secondNumber, thirdNumber;

System.Console.WriteLine("Введите первое число: ");
firstNumber = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
secondNumber = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Введите третье число: ");
thirdNumber = Convert.ToDouble(Console.ReadLine());

void Number(double n1, double n2, double n3)
{
    double summ = n1 + n2 + n3;
    double multiplication = n1 * n2 * n3;
    System.Console.WriteLine($"сумма чисел = {summ} произведение чисел = {multiplication} ");
}

Number(firstNumber, secondNumber, thirdNumber);