// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

// Вариант 1
// Console.Clear();
// Console.Write("Введите число a: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите число b: ");
// int b = int.Parse(Console.ReadLine());
// if (a * a == b)
// {
// Console.WriteLine("b квадрат a");
// }
// eise if (b * b == a)
// {
// Console.WriteLine("a квадрат b");
// }
// else
// {
// Console.WriteLine("не является");
// }

// Вариант2
// Console.Clear();
// Console.Write("Введите число a: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите число b: ");
// int b = int.Parse(Console.ReadLine());
// if (a * a == b)
// {
// Console.WriteLine("b квадрат a");
// return;
// }
// if (b * b == a)
// {
// Console.WriteLine("a квадрат b");
// }
// else
// {
// Console.WriteLine("не является");
// }

// Вариант 3
Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if (a * a == b || b * b == a)
{
Console.WriteLine("является");   
}
else
{
Console.WriteLine("не является");
}
