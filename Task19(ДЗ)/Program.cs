// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно полиндромом
// Пример 14212->нет  23432->да  12821-> да

Console.Clear();

Console.WriteLine ("Введите пятизначное число");
int N = Convert.ToInt32(Console.ReadLine());
int x = N / 10000;
int a  = N % 10;
int b = N % 100 / 10;
int c = N %1000 /100;
int d = N %10000 /1000;
int e = N /10000;
if (x >= 1 && x <= 9)
{

    if (a == e && b == d)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.Write("нет");
    }
}
else
{
    Console.WriteLine("Введите пятизначное число");
}
