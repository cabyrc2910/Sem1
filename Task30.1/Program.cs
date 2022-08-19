// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// Пример  [1,0,1,1,0,1,0,0]

Console.Clear();
int N = 8;
int min = 0;
int max = 1;
int[] array(int N, int min, int max)
{
    int [] arr = new int [N];
    for (int i = 0; i < N; i++)
    {
        arr[i] = new Random(). Next(min,max + 1);
    }
    return arr;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length;i++)
    {
        Console.Write ($"{array[i]}");
    }
}

Console.WriteLine ();
PrintArray(array(N,min,max));
Console.WriteLine ();
