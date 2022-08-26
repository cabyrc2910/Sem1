// Задать одномерный массив, заполненный случайными числами.Найти сумму элементов, стоящих на нечётных позициях
// Пример  [3,7,23,12]->19    [-4,-6,89,6]->0

Console.Clear();
Console.WriteLine("Введите колличество элементов");
int i = Convert.ToInt32(Console.ReadLine());
int [] array = new int [i];
int count = 1;
int sum = 0;
while (count <= i )
{
    Random x = new Random();
    int n = x.Next(-100,100);
    array[count -1]= n;
    if ((count - 1)  % 2 != 0)
    {
     sum = sum + n;
    }
    Console.Write(n);
    Console.Write(" ");
    count++;
}
Console.Write("сумма нечетных элементов =");
Console.Write(sum);
