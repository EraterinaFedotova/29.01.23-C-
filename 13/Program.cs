// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int Num3 (int number)
        {
            int result = -1;
            if (number >= 100)
            {
                while (number > 999)
                {
                    number = number / 10;
                }
                result = number % 10;
            }
            return result; 
        }
if (Num3 (number1) == -1)
    Console.WriteLine("третьей цифры нет");
else
    Console.WriteLine($"третья цифра в числе {Num3(number1)}");
