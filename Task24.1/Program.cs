﻿// Напишите программу которая  принимает на вход число (А) и выдаёт сумму чисел от 1 до (А)
// 7->28  4->10  8->36

Console.Clear();
int Cycle(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum = sum + i;
    }
    return sum;
}
Console.Write("Ввод числа A: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = Cycle(number);
Console.Write($"Результат работы программы = {sum}");