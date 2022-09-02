// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
const int ROWS = 2;
const int COLUMNS = 2;
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

int[,] matrixA = FillMatrixRandom(ROWS, COLUMNS);
Console.WriteLine("Матрица А:");
PrintMatrix(matrixA);
int[,] matrixB = FillMatrixRandom(ROWS, COLUMNS);
Console.WriteLine("Матрица B:");
PrintMatrix(matrixB);

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                sum = sum + matrixA[i, k] * matrixB[k, j];
            }
            matrixC[i, j] = sum;
        }
    }
        return matrixC;
}
if (matrixA.GetLength(1) != matrixB.GetLength(0))
{
    Console.WriteLine("Произведение матриц не возможно!");

}
else
{
    int [,] matrixC = MatrixMultiplication(matrixA, matrixB);
    Console.WriteLine("Произведение матриц А и В:");
    PrintMatrix(matrixC);
}