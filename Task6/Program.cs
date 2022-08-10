// Написать программу, которая на входпринимает число и выдаёт, является ли число чсётным(делится ли оно на два без остатка)
// Пример  4->да  -3->нет  7->да

Console.Clear();
Console.Write("Введите чило:");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2==1)
{
    Console.WriteLine ("Нет ");
}
else
{
    Console.WriteLine ("Да");
}
