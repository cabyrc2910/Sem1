// Задайте двумерный массив размеров m*n, заполненный случайными целыми числами. 
// Пример: m=3, n=4.    
// 1 4 8 1 9    
// 5 -2 33 -2     
// 77 3 8 1

Console.Clear();
Console.WriteLine("Задайте двумерный массив m x n");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];     //задаём двумерный массив
for (int i = 0; i < m; i++)        // заполняем массив случайными числами
{
    for (int j = 0; j < n; j++)      // чтобы заполнить строку вводим цикл
    {
        matrix[i, j] = new Random().Next(-100, 101);
        Console.Write(matrix[i, j] + " ");     // Вывод каждой строки
    }
    Console.WriteLine();    // Перенос строки
}
