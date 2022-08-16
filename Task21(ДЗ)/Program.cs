//  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D
// Пример A (3,6,8); B (2,1,-7)->15,84  A (7,-5,0); B (1,-1,9) ->11,53

Console.Clear();
string[]A  = new string [3];
Console.WriteLine("Введите число x1");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число y1");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число z1");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число x2");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число y2");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число z2");
double z2 = Convert.ToDouble(Console.ReadLine());
double Length = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
Console.WriteLine(Length);
