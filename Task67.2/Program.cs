// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
void PrintNumbers(int number)
{
    if (number == 0)
    {
        return;
    }
    PrintNumbers (number / 10);
    sum = sum + number % 10;
}
PrintNumbers(n);
Console.WriteLine($"Сумма цифр числа равна {sum}");
