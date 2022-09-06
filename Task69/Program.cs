// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
double Stepen(double a, double b)
{
    if (b == 0)
    {
        return b;
    }
    Stepen(a, b - 1);
    return Math.Pow(a, b);
}
Console.Write("Введите А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Stepen(a,b));
