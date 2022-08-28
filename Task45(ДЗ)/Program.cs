// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. При помощи цикла.

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] arrayA = new int [N];
int [] arrayB = new int [N];
for (int i = 0; i < N; i++)
{
    Console.Write($"Введите {i}-й элемент массива: ");
    int X = Convert.ToInt32(Console.ReadLine());
    arrayA[i] = X;
}
Console.WriteLine("Заданный массив: " + '[' + string.Join(", ", arrayA) + ']');
for (int j = 0; j < N; j++)
{
    arrayB[j] = arrayA[j];
}
Console.WriteLine("Копия массива: " + '[' + string.Join(", ", arrayB) + ']');