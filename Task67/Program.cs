// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum(int n)
{
    if (n == 0)
    {
        return 0;
    }
    return n % 10 + sum(n / 10);
}
Console.WriteLine(sum(n));
