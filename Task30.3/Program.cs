﻿// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// Пример  [1,0,1,1,0,1,0,0]       Join-перегрузка

Console.Clear();
int [] array = new int[8];
int i = 0;
while (i < 8)
{
    array[i] = new Random(). Next(0, 2);
    Console.Write ($"{array[i]},");
    i++;
}