// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


// int[] Mass = new int[12];
// Random rand = new Random();

// for (int i = 0; i < Mass.Length; i++)
//     {
//         Mass[i] = rand.Next(0, 2);
//         Console.Write(Mass[i] + " ");
//     }

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

// int SumPositiveElements(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] > 0)
//         {
//             sum = sum + arr[i];
//         }
//         ;
//     }
//     return sum;
// }

// int SumNegativeElements(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] < 0)
//         {
//             sum = sum + arr[i];
//         }
        
//     }
//     return sum;
// }

(int, int) GetNegativeAndPositiveSums(int[] arr)
{
    int sumP = 0;
    int sumN = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            sumP += arr[i];
        }
        else
        {
            sumN += arr[i];
        }
    }
    return (sumP, sumN);
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(string.Join(", ", array));
// int sumPositive = SumPositiveElements(array);
// int sumNegative = SumNegativeElements(array);
(int sumPositive, int sumNegative) = GetNegativeAndPositiveSums(array);
Console.WriteLine($"Сумма положительных элементов = {sumPositive}, отрицательных элементов = {sumNegative}");