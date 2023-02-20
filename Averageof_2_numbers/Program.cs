using System;
// 1. Write a programm that calculates the average of 2 numbers

System.Console.WriteLine("Write 2 numbers: ");

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

int summ = number1 + number2;
int average = summ / 2;

System.Console.WriteLine("The average of " + number1 + " and " + number2 + " is = " + average);
System.Console.WriteLine("Well done!");
