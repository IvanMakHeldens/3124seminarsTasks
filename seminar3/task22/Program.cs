// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
int sqr = 1;
Console.WriteLine($"Квадраты чисел от 1 до {N}:");
while (count <= N)
{
    sqr = count*count;
    Console.Write(sqr + " ");
    count++;
}




