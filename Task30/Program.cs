// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// Пример  [1,0,1,1,0,1,0,0]

Console.Clear();
Console.WriteLine ("Введите количество элементов массива:");
int i = Convert.ToInt32(Console.ReadLine());
int [] array = new int [i];
Random rnd = new Random();
for (int count = 0; count < i;)
{
    array[count] = Convert.ToInt32(rnd.Next(0,2));
    count ++;
}
for (int count = 0; count < i - 1;)
{
    Console.WriteLine (array[count] +",");
    count++;
}
Console.WriteLine (array[i - 1]);
