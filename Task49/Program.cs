// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2          1 4 49 2
// 5 9 2 3          5 9 2 3
// 8 4 2 4          64 4 4 4

Console.Clear();
Console.WriteLine("Задайте массив размера m на n.");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(1,6);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            matrix[i,j] = matrix[i,j] * matrix[i,j];
        }
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}