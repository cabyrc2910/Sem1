// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//Пример: 0, 7, 8, -2, -2 -> 2     1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= M; i++)
{
    Console.Write($"Введите {i}-е число: ");
    int A = Convert.ToInt32(Console.ReadLine());
    if (A > 0)
    {
        sum = sum + 1;
    }
}
Console.Write($"Количество положительных чисел равно: {sum}");