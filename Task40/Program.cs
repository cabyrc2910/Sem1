// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

Console.Clear();
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int C = Convert.ToInt32(Console.ReadLine());
if (A < B + C && B < A + C && C < A + B)
{
    Console.WriteLine($"Треугольник со сторонами {A}, {B}, {C} - существует!");
}
else
{
    Console.WriteLine("Треугольник не существует.");
}