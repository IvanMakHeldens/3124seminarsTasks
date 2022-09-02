//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = -number;
}
if (number > 99 && number < 1000) 
{
    int secNumber = number / 10;
    int res = secNumber % 10; 
    Console.WriteLine($"Вторая цифра {res}");
}
else
{
   Console.WriteLine("Было введено не трёхзначное число");
}
