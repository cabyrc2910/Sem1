// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// Пример  [1,0,1,1,0,1,0,0]       Join-перегрузка

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
Console.WriteLine ();
Console.WriteLine ('['+ string.Join(",", array(N,min,max))+']');
Console.WriteLine ();
