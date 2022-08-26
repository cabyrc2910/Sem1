// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

Console.Clear();
Console.WriteLine("Введите длину первой стороны треугольника");
double ac =Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите длину первой стороны треугольника");
double ab =Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите длину первой стороны треугольника");
double bc =Convert.ToInt64(Console.ReadLine());

if (ac < ab+bc || bc < ab+ac || ab < ac+bc)
Console.WriteLine("возможно");
else
Console.WriteLine("невозможно");
