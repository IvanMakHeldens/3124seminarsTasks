// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
int tempN = N;
int Number = N;
int count = 0;
int sum = 0;


while (tempN > 0)
{
    tempN = tempN / 10;
    count = count + 1;
}
while (count > 0)
{
    Number = N % 10;
    sum = sum + Number;
    N = N / 10;
    count--;
}

Console.WriteLine(sum);

