// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int fact(int n)
{
    if (n % 10 == 0)
    {
        return 0;
    }
    fact (n / 10);
    return sum = sum + (n % 10);
}
Console.WriteLine(fact(n));
 