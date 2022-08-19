//  Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// Пример  4->24  5->120

Console.Clear();
Console.WriteLine ("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 1;
for (int i = 1; i <= n;)
{
    sum = sum * i;
    i++;
}
Console.WriteLine (sum);
