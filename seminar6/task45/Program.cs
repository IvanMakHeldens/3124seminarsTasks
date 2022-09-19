// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


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

int[] CopyArray(int[] arr)
{
    int[] array = new int[arr.Length];
    for( int i = 0; i < array.Length; i++)
    {
        array[i] = arr[i];
    }
    return array;
}

int[] arr = GetArray(5, 0, 10);
Console.WriteLine($"Исходный массив = {string.Join(", ", arr)}");
arr[2] = 3;
Console.WriteLine($"Исходный массив = {string.Join(", ", arr)}");
int[] array = CopyArray(arr);
Console.WriteLine($"Копия массива = {string.Join(", ", arr)}");
arr[1] = 2;
Console.WriteLine($"Исходный массив = {string.Join(", ", arr)}");
