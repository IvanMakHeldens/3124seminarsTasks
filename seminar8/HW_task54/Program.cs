// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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

void arrangeRow(int[,] matrix)
{
    for(int k = 0; k < matrix.GetLength(1)-1; k++ )
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i,j] > matrix[i,j + 1])
                {
                    int max = matrix[i,j];
                    matrix[i,j] = matrix[i,j + 1];
                    matrix[i,j + 1] = max;
                }
            }   
        }
       
    }
}


int m = ReadNumber("Введите количество строк: ");
int n = ReadNumber("Введите количество столбцов: ");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
Console.WriteLine();
arrangeRow(matr);
Console.WriteLine();
PrintMatrix(matr);