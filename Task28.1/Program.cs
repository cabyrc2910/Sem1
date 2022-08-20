//  Напишите программу, в которой задается массив чисел(ввод может быть с клавиатуры, либо можете сами задавать массив чисел) и выдаёт произведение чисел от 1 до N, каждого элемента этого массива.
// Пример{2, 3, 4}->2, 6, 24    {5, 3, 6, 2, 5, 1}->6, 720, 2, 120, 1

Console.Clear();
Console.WriteLine ("Введите количество элементов массива");
int i = Convert.ToInt32(Console.ReadLine());
int [] array = new int [i];
for (int count = 0; count < i;)
{
    Console.WriteLine ($"Введите {count + 1} элемент массива");
    array[count] = Convert.ToInt32(Console.ReadLine());
    count ++;
}
int A = Cycle(array, 1);
Console.WriteLine (A);
int Cycle (int[] array, int i)
{
    int sum = 1;
    for (int count = 1; count <= array [i]; count++)
    {
        sum = sum*count;
    }
    return sum;
}
