// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X≠0 и Y≠0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();
int[] point = new int [2];
Console.WriteLine ("Введите координату X:");
point[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату Y:");
point[1] = Convert.ToInt32(Console.ReadLine());
if(point[0] > 0 && point [1] > 0)
{
    Console.WriteLine ("Первая четверть");
}
else if(point[0] < 0 && point[1]> 0)
{
    Console.WriteLine ("Вторая четверть");
}
else if(point[0] < 0 && point[1]< 0)
{
    Console.WriteLine ("Третья четверть");
}
else if(point[0] > 0 && point[1]< -0)
{
    Console.WriteLine ("Четвёртая четверть");
}
else
{
    Console.WriteLine ("Точка лежит на оси");
}
