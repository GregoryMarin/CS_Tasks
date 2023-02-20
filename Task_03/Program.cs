/* 3. Напишите программу, коротрая будет выдавать название дня недели по заданному номеру.
2 -> вторник
3 -> среда 
*/

Console.WriteLine("Write day number: ");
int day = Convert.ToInt32(Console.ReadLine());


if (day == 1) Console.WriteLine("Monday");
if (day == 2) Console.WriteLine("Tusday");
if (day == 3) Console.WriteLine("Wednesday");
if (day == 4) Console.WriteLine("Thursday");
if (day == 5) System.Console.WriteLine("Friday");
if (day == 6) System.Console.WriteLine("Saturday");
if (day == 7) System.Console.WriteLine("Sunday");
if (day > 7) System.Console.WriteLine("Warning! Incorrect data");
if (day <= 0) System.Console.WriteLine("Warning! Number can not be < 0");