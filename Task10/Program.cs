// Написать программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
// Пример  456->5  782->8  918->1

Console.Clear();
Console.WriteLine("Введите трёхзначное число:");
int N = Convert.ToInt32(Console.ReadLine());
int i = N/10%10;
Console.WriteLine (i);