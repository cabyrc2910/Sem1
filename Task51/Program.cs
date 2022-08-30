// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Пример, задан массив:
// 1 4 7 2      1
// 5 9 2 3      9
// 8 4 2 4      2
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();
Console.WriteLine("Введите массив размера m на n.");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [m,n];
int sum = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(1,10);
        Console.Write(matrix[i,j] + " ");
        if (i == j) {sum = sum + matrix[i,j];}
    }
    Console.WriteLine();
}
Console.WriteLine($"Сумма равна: {sum}");
