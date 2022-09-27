// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int ReadNumber (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} 


int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
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

int[,] GetMatrixRowsAreColumns(int[,] matrix)
{
    int[,] matr = new int[matrix.GetLength(1), matrix.GetLength(0)];

    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = matrix[j,i];
        }
    }

    return matr;
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


int m = ReadNumber("Введите количество строк: ");
int n = ReadNumber("Введите количество столбцов: ");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
Console.WriteLine();
int[,] matrix = GetMatrixRowsAreColumns(matr);
PrintMatrix(matrix);
