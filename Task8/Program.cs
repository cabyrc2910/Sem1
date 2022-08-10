// Напишите программу которая на вход принимает число (N), а на выходе показывает все чётные числа в промежутке от 1 до N
// Пример 4->-4,-3,-2,-1,0,1,2,3,4    2->-2,-1,0,1,2

Console.Clear();
Console.WriteLine("Введите целое число больше 2: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (count < N)
{
    while (count <= N)
    {
        Console.WriteLine(count);
        count += 2;
    }
}
