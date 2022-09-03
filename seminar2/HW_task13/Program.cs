// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0; // подсчёт количества цифр в числе
if (number < 0)
{
    number = -number;
}

int digit = number; // для подсчёта количества цифр в цикле
int numberA = number; // для уменьшения числа до третьей цифры

if (number > 99) 
{
    while (digit > 0)  // цикл подсчёта количества цифр
    {
        digit = digit / 10;
        count = count + 1;
    }
    while (count > 3) // цикл деления числа до третьей цифры
    {
    numberA = numberA / 10;
    count = count - 1;
    }
    int thirdNumber = numberA % 10;
    Console.WriteLine($"третья цифра равна {thirdNumber}");
}
else
{
   Console.WriteLine("третьей цифры нет");
}
