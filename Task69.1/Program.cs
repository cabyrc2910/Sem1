// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
double fact(double a, double b)
{
    if (b == 0)
    {
        return b;
    }
    fact(a, b - 1);
    return Math.Pow(a, b);
}
Console.WriteLine($"результат возведения в степень: {fact(a,b)}");
