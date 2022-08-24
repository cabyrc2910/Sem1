// Задать массив вещественных чисел. Найти разницу между максимальным и минимальным элементов массива
// Пример  [3 7 22 2 78]->76

Console.Clear();
Console.WriteLine("Введите кол-во ячеек массива");
int[] Arr = new int[Convert.ToInt32(Console.ReadLine())];
for (int i = 0 ; i<Arr.Length ; i++)
{
    Console.WriteLine("Введите значение ячейки массива под номером " + (i+1));
    Arr[i] = Convert.ToInt32(Console.ReadLine());
}
int max = Arr.Max();
int min = Arr.Min();
Console.WriteLine("Максимальное значение в массиве " + max);
Console.WriteLine("Минимальное значение в массиве " + min);
Console.Write("разница = ");
Console.WriteLine(max - min);
