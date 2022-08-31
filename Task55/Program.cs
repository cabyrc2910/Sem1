// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Clear();
Console.WriteLine("Введите массив размером m на n.");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m > n ^ m < n) { Console.WriteLine("Заменить строки на столбы при заданных параметрах m и n невозможно"); }
else
{
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

    Console.WriteLine("Измененный массив: ");
    for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[j, i] + " ");
                }
                Console.WriteLine();
        }
}
