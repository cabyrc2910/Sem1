// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Clear();

// int M = 3;
// Console.WriteLine(M);
// int N = 18;
// Console.WriteLine(N);

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int number1, int number2)
{
    if (number1 > number2)
    {
       return;
    }
    Console.Write($"{number1}, ");
    PrintNumbers(number1 + 1, number2);
}
PrintNumbers(M, N);
