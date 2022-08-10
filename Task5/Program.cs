// Напишите программу которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N
// Пример 4->-4,-3,-2,-1,0,1,2,3,4    2->-2,-1,0,1,2
Console.Clear();
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
int i = -N;
while (i <= N)

{
    Console.WriteLine(i);
    i++;
}
