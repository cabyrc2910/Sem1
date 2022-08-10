// Написать программу, которая на вход принимает число и проверяет, кротно ли оно однавременно 7 и 23
// Пример 14->нет    46->нет   161->да

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}