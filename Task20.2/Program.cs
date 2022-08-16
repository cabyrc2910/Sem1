//  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D
// Пример A (3,6); B (2,1) -> 5,09  A (7,-5); B (1,-1) -> 7,21

Console.Clear();
double [] A = new double [2];
double [] B = new double [2];
Console.WriteLine("Введите число x1");
A [0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число y1");
A [1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число x2");
B [0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число y2");
B [1] = Convert.ToDouble(Console.ReadLine());
double Length = Math.Sqrt(Math.Pow(B[0]-A[0], 2)+ Math.Pow (B[1]-A[1], 2));
Console.WriteLine(Length);
