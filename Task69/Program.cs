// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


double Stepen(double A, double B)
{
    if (B == 1)
    {
        return B;
    }
    Stepen(A, B - 1);
    return Math.Pow(A, B);
}

Console.Write("Введите А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Stepen(A,B));