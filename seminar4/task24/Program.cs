// Напишите программу, которая принимает на вход число (A) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число:");
int A = Convert.ToInt32(Console.ReadLine());
int res = 0;
if (A > 0)
{
    for (int count = 1; count <= A; count++)
    {
        res = res + count;
    }
}
else
{
    Console.WriteLine("Вводить нужно число больше 0");    
}
Console.WriteLine(res);