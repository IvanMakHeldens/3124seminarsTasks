// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int ReadNumber (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} 

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write($"{matrix[i,j]}  ");
        }
        Console.WriteLine();
    }
}

void MinSumRow(int[,] matrix)
{
    int sum = 0;
    int[] arr = new int[matrix.GetLength(0)];
    for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                sum = sum + matrix[i,j];
            }   
        arr[i] = sum;
        sum = 0;
        }
    int min = arr[0];
    int minK = 0;
    for (int k = 1; k < arr.Length; k++)
    {
        if (arr[k] < min)
        {
            min = arr[k];
            minK = k;
        }
    }
    Console.WriteLine($"строка с наименьшей суммой элементов - строка с индексом {minK}");
    // Console.WriteLine(string.Join("  ", arr));
}


int m = ReadNumber("Введите количество строк: ");
int n = ReadNumber("Введите количество столбцов: ");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
Console.WriteLine();
MinSumRow(matr);
