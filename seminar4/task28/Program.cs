// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
long res = 1;
if (N > 0)
{
    for (long count = 1; count <= N; count++)
    {
        res = res * count;
    }
}
else
{
    Console.WriteLine("Вводить нужно число больше 0");    
}
Console.WriteLine(res);
