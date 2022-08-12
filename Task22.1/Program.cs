// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// Пример 5->1, 4, 9, 16, 25.   2->1,4

Console.Clear();
int number = Convert.ToInt32 (Console.ReadLine());
int count = 1;
while(count <= number)
{
    Console.WriteLine (count*count);
    count++;
}

