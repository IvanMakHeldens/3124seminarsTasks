// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.WriteLine("Введите номер четверти");
int N = Convert.ToInt32(Console.ReadLine());

if (N == 1)
{
    Console.WriteLine("x > 0 && y > 0");
}
else if (N == 2)
{
    Console.WriteLine("x < 0 && y > 0");
}
else if (N == 3)
{
    Console.WriteLine("x < 0 && y < 0");
}
else if (N == 4)
{
    Console.WriteLine("x > 0 && y < 0");
}
else
{
    Console.WriteLine("Введен неверный номер четверти");
}
