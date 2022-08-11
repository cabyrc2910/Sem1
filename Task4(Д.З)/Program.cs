// Написать программу которая принимает на вход три числа и выдаёт максимальное из этих чисел
// Пример  2,3,7->7  44,5,78->78  22,3,9,->22

Console.Clear();
Console.WriteLine("Введите первое чило:");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int C = Convert.ToInt32(Console.ReadLine());

int max = A;  // Присваиваем переменной max значение первого числа
if(A > max) max = A;  // Это условие не нужно, т.к. захода в него не будет
if(B > max) max = B;
if(C > max) max = C;
Console.Write ("max = ");
Console.WriteLine (max);
