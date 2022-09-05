// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int AkkerMan(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m != 0) && (n == 0))
    {
       return AkkerMan(m - 1, 1); 
    }
    else
    {
        return AkkerMan(m - 1, AkkerMan(m, n - 1));   
    }
}

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(AkkerMan(m,n));