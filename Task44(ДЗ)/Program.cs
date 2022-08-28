// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Пример: Если N = 5 -> 0 1 1 2 3      Если N = 3 -> 0 1 1         Если N = 7 -> 0 1 1 2 3 5 8


Console.Clear();
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int A = 0;
int B = 1;
for (int i = 0; i < N; i++)
{
    Console.Write(A + " ");
    A = A + B;
    B = A - B;
}