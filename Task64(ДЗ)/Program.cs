// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
void Natural(int N)
{
    if (N == 0)
    {
        return;
    }
    Console.Write(N + " ");
    Natural(N-1);
}

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

Natural(N);
