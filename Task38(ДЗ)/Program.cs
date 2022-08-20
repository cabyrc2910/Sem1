// Задать массив вещественных чисел. Найти разницу между максимальным и минимальным элементов массива
// Пример  [3 7 22 2 78]->76

Console.Clear();
Console.WriteLine("Введите колличество элементов");
int i = Convert.ToInt32(Console.ReadLine());
double [] array = new double [i];
int count = 1;
double max = -100;
double min = 100;
while (count <= i )
{
    Random x = new Random();
    double n = x.Next(-100,100);
    array[count -1]= n;
    if (n > max)
    {
     max = n;
    }
    if (n < min)
    {
     min = n;
    }
    Console.Write(n);
    Console.Write(" ");
    count++;
}
Console.Write("max =");
Console.WriteLine(max);
Console.Write("min =");
Console.WriteLine(min);
Console.Write("разница =");
Console.WriteLine(max - min);
