// Написать цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
// Пример 3,5->243(3⁵)  2,4->16  Не использовать MathPow  и аналоги

Console.Clear();
Console.WriteLine("Введите число A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int B = Convert.ToInt32(Console.ReadLine());
int count = 0;
int C = 1;
while ( count < B )
{
    C  = C*A;
    count = count + 1; 
}
Console.WriteLine(C);
