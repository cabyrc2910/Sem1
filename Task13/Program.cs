// Написать программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Пример  645->5  78-> третьей цифры нет  32679->6

Console.Clear();
Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int i = N/10%10;
Console.WriteLine (i);