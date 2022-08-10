Console.Clear();
Console.WriteLine("Введите первое чило:");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int C = Convert.ToInt32(Console.ReadLine());

int max = A;
if(A > max) max = A;
if(B > max) max = B;
if(C > max) max = C;
Console.Write ("max = ");
Console.WriteLine (max);
