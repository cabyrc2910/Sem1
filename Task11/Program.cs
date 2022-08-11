// Написать программу которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
// Пример 456->46  782->72  918->98

Console.Clear();
string s = new Random().Next(100,1000).ToString;  //int number=new Random().Next(100,1000);
Console.WriteLine($"Наше случайное число = {number}");
                                                  //string s = number.ToString();
int first = int.Parse(s[0].ToString());    // Выбираем o элемент первое число
int last = int.Parse(s[s.Length - 1].ToString()); // Выбираем последнее число
Console.WriteLine($"{first}{last}");       // Вывод 2 символами
