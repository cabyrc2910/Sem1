// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

Console.Clear();
int Treg(double A, double B, double C)
{
    int result = 0;
    if(A > B+C)
    {
        result = 1;
    }
    else if(B > A+C)
    {
        result = 1;
    }
    else if(C > B+A)
    {
        result = 1;
    }
    else result = 0;
    return result;
};
Console.Write("Введите длину отрезка A: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите длину отрезка B: ");
double B = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите длину отрезка C: ");
double C = Convert.ToDouble(Console.ReadLine());
if(Treg(A, B, C) == 0)
{
    Console.WriteLine($"Треугольник может существовать!");
}
else
{
    Console.WriteLine("Треугольник не существует.");
}
    