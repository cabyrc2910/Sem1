// Напишите программу , которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа
// Пример 456->5  782->2  918->8

Console.Clear();
Console.WriteLine("Введите трёхзначное число:");
int N = Convert.ToInt32(Console.ReadLine());
int i = N%10;
Console.WriteLine (i);
