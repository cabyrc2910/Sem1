//  Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// Пример 456->3  78->2  89126->5

Console.Clear();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (number > 0)
{
    number = number / 10;
    count ++;
}
if (number ==0)
{
    count ++;
}
Console.WriteLine(count);
