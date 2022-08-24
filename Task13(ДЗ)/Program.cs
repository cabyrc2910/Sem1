// Написать программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Пример  645->5  78-> третьей цифры нет  32679->6

Console.Clear();
Console.Write ("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
if (N < 100)
{
    Console.WriteLine ("У числа нет третьей цифры!");
}
else
{
    string s = Convert.ToString (N);
    int third = int.Parse(s[2].ToString());
    Console.WriteLine($"Третья цифра числа: {third}");
}
