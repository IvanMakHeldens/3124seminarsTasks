// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int ReadNumber (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
} 

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
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

int[,] SecondMatrix(int[,] secMatr)
{
    for(int i = 0; i < secMatr.GetLength(0); i++)
    {
        for(int j = 0; j < secMatr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                secMatr[i,j] = secMatr[i,j] * secMatr[i,j];
            }
        }
    }
    return secMatr;
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


int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n, 1, 9);
Console.WriteLine("Старый массив:");
PrintMatrix(matr);
int[,] secMatrix = SecondMatrix(matr);
Console.WriteLine("Новый массив:");
PrintMatrix(secMatrix);
