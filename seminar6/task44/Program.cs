// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите количество чисел Фибоначчи:");
int s = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[s];
if (s > 2)
{
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < s; i++)
    {
        arr[i] = arr[i - 2] + arr[i - 1];
    }
    Console.WriteLine(string.Join(" ", arr));
}
else
Console.WriteLine("Вводить нужно число больше 2");