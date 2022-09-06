// Написать программу которая на вход принимает два числа и выдаёт, какое число больщшее, а какое меньшее.
// Пример  a=5;b=7->max=7    a=2;b=10->max=10    a=-9;b=-3->max=-3

Console.Clear();
Console.WriteLine("Введите чиcло a:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
    Console.Write ("max = ");
    Console.WriteLine (numberA);
}
else
{
    Console.Write ("max = ");
    Console.WriteLine (numberB);
}
