// Написать программу, которая будет преобразовывать десятичное число в двоичное.
// 45->101101   3->11    2->10

Console.Clear();
void PrintBinary(int N)
{
    if(N <=0) return;
    PrintBinary(N/2);
    Console.Write(N%2);
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
PrintBinary(number);