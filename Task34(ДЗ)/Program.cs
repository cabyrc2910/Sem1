// Задать массив заполненный случайными положительными трёхзначными числами.Написать программу, которая покажет количество чётных чисел в массиве.
// Пример  [345,897,568,234]->2

Console.Clear();
Console.WriteLine("Введите колличество элементов");
int i = Convert.ToInt32(Console.ReadLine());
int [] array = new int [i];
int count = 1;
int k= 0;
while (count <= i )
{
    Random x = new Random();
    int n = x.Next(100,999);
    array[count -1]= n;
    if (n % 2 == 0)
    {
     k++;
    }

    Console.Write(n);
    Console.Write(" ");
    count++;
}
Console.Write("количество четных =");
Console.Write(k);


