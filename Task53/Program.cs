// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Clear();
Console.WriteLine("Введите массив размером m на n.");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
Console.WriteLine("Заданный массив:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[] vrm = new int[n];
Console.WriteLine("Измененный массив:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == 0)
        {
            vrm[j] = matrix[m - 1, j];
            matrix[m - 1, j] = matrix[i, j];
            matrix[0, j] = vrm[j];
        }
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
