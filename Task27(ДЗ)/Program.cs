//Написать программу, которая принимает на вход число и выдаёт сумму цифр в числе
// Пример 452->11  82->10  9012->12

Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
int Sum = 0;
while (a>0)
{
    b = a % 10;
    Sum = b + Sum;
    a = a/10;
}
Console.WriteLine(Sum);
 