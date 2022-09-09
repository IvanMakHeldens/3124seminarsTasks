//  Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);

int count = 0;
if (N == 0)
{
    count = 1;
}

while (N > 0)
{
    N = N / 10;
    count = count + 1;
}
Console.WriteLine($"Количество цифр в числе равно {count}");
