﻿// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Clear();

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n > m)
{
    PrintNumbers(m, n);
}
else
{
    PrintNumbers(n, m);
}
void PrintNumbers(int m, int n)
{
    if (n == m - 1)
    {
       return;
    }
    PrintNumbers(m, n - 1);
    Console.Write($"{n}, ");
}
