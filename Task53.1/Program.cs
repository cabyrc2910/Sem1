// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Clear();
const int ROWS = 3;
const int COLUMNS = 3;
int[,] FillMatrixRandom(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // Длина строки в двумерном массиве
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)    // Вывод массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");  
        }
        Console.WriteLine();  // Переход на новую с троку
    }
}

int [,] matrix = FillMatrixRandom(ROWS, COLUMNS);
PrintMatrix(matrix);

Console.WriteLine();
for (int i = 0; i < matrix.GetLength(1); i++)
{
    int temp = matrix[0,i];     // Bводим временную переменную Temp чтобы записать 1 элемент массива
    matrix[0,i] = matrix[matrix.GetLength(0) - 1, i]; // В первый элемент массива записываем первый элемент последней строки
    matrix[matrix.GetLength(0) - 1, i] = temp; // Первый элемент последней строки записываем в Temp чтобы это сохранилось
}                                              // До тех пор пока массив не перевернётся
PrintMatrix(matrix);
 