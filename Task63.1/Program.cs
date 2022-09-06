﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int number)
{
    if (number == 0)
    {
        return;
    }
    PrintNumbers(number - 1);
    Console.Write($"{number}, ");

}
PrintNumbers(N);
