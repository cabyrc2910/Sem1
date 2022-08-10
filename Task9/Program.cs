// Написать программу, которая выводитслучайное число из отрезка [10,99] и показываетнаибольшую цифру числа
// Пример 78->8  12->2  85->8

Console.Clear();
int number = new Random().Next(10, 100);
Console.WriteLine($"Наше случайное число = {number}");
int digit1 = number/10;
int digit2 = number%10;
if(digit1 > digit2)
{
    Console.WriteLine(digit1);
}
else
{
    Console.WriteLine(digit2);
}