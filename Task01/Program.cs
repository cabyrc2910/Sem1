﻿// Написать программу которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// Пример  a=25,b=5->да  a=2,b=10->нет  a=9,b=-3->да  a=-3,b=9->нет  

Console.Clear();
Console.WriteLine("Введите первое чило:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberB * numberB == numberA)
{
    Console.WriteLine ("Да");
}
else
{
    Console.WriteLine ("Нет");
}