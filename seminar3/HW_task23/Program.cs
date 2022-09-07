// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0)
{    
    Console.WriteLine($"Кубы чисел от 1 до {N}:");
    for (int count = 1; count <= N; count++)
    {
        Console.Write(count * count * count + " ");
    }
}
else
{
    Console.WriteLine("Нужно вводить число больше 0");
}