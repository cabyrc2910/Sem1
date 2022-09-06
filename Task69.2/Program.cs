﻿// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int Vozvedenie(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    return a * Vozvedenie(a, b - 1);
}
Console.WriteLine(Vozvedenie(a,b));
