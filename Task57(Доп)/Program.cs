// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

Console.Clear();
Console.WriteLine("Введите массив размером m на n.");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
Console.WriteLine("Заданный массив: ");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
        {   
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + " ");
        }
    Console.WriteLine();
}
int sum = 0;
for (int k = 0; k < 10; k++)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {   
            if (k == matrix[i,j])
            {
                sum = sum + 1;                
            }
        }
    }
    Console.WriteLine($"Число {k} встречается {sum} раз.");
    sum = 0;
}
