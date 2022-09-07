// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 9999 && N < 100000)
{
    int numberA = N / 10000;
    int numberB = N / 1000 % 10;
    int numberD = N / 10 % 10;
    int numberE = N % 10;
    if (numberA == numberE && numberB == numberD)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("Ввели не пятизначное число");
}
