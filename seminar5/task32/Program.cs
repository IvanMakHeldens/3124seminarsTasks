// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
        // Console.Write(arr[i] + " ");
    }
    return arr;
}

void SwitchNegPos(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;;
    }
    
}





int[] array = GetArray(12, -9, 9);
Console.WriteLine(string.Join(", ", array));
SwitchNegPos(array);
Console.WriteLine(string.Join(", ", array));