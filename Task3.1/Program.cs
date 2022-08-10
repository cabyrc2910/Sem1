Console.Clear();
Console.WriteLine("Введите чило от 1 до 7:");
int numbera = Convert.ToInt32(Console.ReadLine());

switch (numbera)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    default:
    Console.WriteLine("Нет такого дня");
        break;
}
