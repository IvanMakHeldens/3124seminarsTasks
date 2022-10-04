// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNumber (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} 

int SumMToN(int m, int n)
{   
    
    if(n < m)
    {
        return 0;
    }
    else
    
    {
        return SumMToN(m, n-1) + n;
    }
    
}
int M = ReadNumber("Введите M: ");
int N = ReadNumber("Введите N: ");
Console.WriteLine(SumMToN(M, N));  