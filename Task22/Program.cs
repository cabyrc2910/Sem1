// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// Пример 5->1, 4, 9, 16, 25.   2->1,4

Console.Clear();
Console.WriteLine ("Введите любое число N:");
int N = Convert.ToInt32 (Console.ReadLine());
N = Math.Abs(N);
int count = 1;
if (N == 0)
{
    Console.WriteLine ("0");
}
else
{
    while(count < N)
    {
        Console.WriteLine (Math.Pow(count, 2));
        count++;
    }
}
