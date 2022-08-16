// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X≠0 и Y≠0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();

Console.WriteLine ("Введите четверть:");
int quater = Convert.ToInt32(Console.ReadLine());
string[] arr = {"x>0;y>0", "x<0;y>0", "x<0;y<o", "x>0; y<0"};
if(quater >=1 && quater <= 4)
{
    Console.WriteLine (arr[quater-1]);
}
else 
{
    Console.WriteLine ("Такой четверти нет");
}
