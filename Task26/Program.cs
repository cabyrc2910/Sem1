//  Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// Пример 456->3  78->2  89126->5

Console.Clear();
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (n > 0)
{
    n = n / 10;
    i += 1;
}
Console.WriteLine(i);
