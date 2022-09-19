// Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int DiffMaxMin(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    for (int i = 1; i < arr.Length; i ++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
            // Console.WriteLine($"макс = {max}");
        }
        else if (arr[i] < min)
        {
            min = arr[i];
            // Console.WriteLine($"мин = {min}");
        }
    }
    Console.WriteLine($"максимальный элемент равен {max}");
    Console.WriteLine($"минимальный элемент равен {min}");
    int diff = max - min;
    return diff;
}

int[] array = GetArray(20, 1, 100);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {DiffMaxMin(array)}");