// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Clear();
void Sequence (int n, int m)
{
    // if (n == m)
    if (n < m)
    {
        return;
    }
    Sequence(n-1, m);
    Console.Write($"{n}, ");
}    
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите возрастающее число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < M) Console.Write("Неверно задана последовательность");
else Sequence (N,M);