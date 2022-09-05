// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int Natural(int M, int N)
{
    if (M == N + 1)
    {
        return 0;
    }
    return M + Natural(M + 1, N);   
}

Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Natural(M,N));
