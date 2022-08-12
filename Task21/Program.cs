//  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D
// Пример A (3,6); B (2,1) -> 5,09  A (7,-5); B (1,-1) -> 7,21

Console.Clear();
string[]A  = new string [2];
Console.WriteLine("Введите число x1");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число y1");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число x2");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число y2");
double y2 = Convert.ToDouble(Console.ReadLine());
double Length = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
Console.WriteLine(Length);
