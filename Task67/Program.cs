// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

int SumA(int A)
{
    if (A == 0)
    {
        return 0;
    }
    return A % 10 + SumA(A / 10);
}


Console.WriteLine(SumA(A));