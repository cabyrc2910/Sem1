// Напишите программу которая  принимает на вход число (А) и выдаёт сумму чисел от 1 до (А)
// 7->28  4->10  8->36

Console.Clear();
Console.Write("Ввод числа A:");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i<= number; i++)
{
    sum = sum + i;
}
Console.Write($"Результат работы программы = {sum}");
