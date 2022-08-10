// Напишите программу , которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа
// Пример 456->5  782->2  918->8

Console.Clear();
Console.WriteLine("Введите трёхзначное число:");
int N = Convert.ToInt32(Console.ReadLine());
if(N>99 && N<1000)
{
Console.WriteLine (N%10);
}
else
{
Console.WriteLine ("Число не подходит");
}