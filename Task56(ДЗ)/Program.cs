// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
const int ROWS = 8;
const int COLUMNS = 10;

int[,] FillMatrixRandom(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = FillMatrixRandom(ROWS, COLUMNS);
Console.WriteLine("Исходный массив: ");
PrintMatrix(matrix);

int temp = int.MaxValue;
int sum = 0;
int minIndex = 0;
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i,j];
    }
    if (sum < temp)
    {
        temp = sum;
        minIndex = i;
    }
    Console.WriteLine($"Сумма {i}-й строки равна: {sum}");
    sum = 0;
}
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов: {minIndex}-я.");
