// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
void Natural(int N)
{
    if (N == 0)
    {
        return;
    }
    Natural(N-1);
    Console.WriteLine(N);
    
}

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

Natural(N);
