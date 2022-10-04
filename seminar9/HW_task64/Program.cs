// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int ReadNumber (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} 

void PrintNto1(int n, int m)
{
    
    if (m > n)
    {
        return;
    }
    else
    {
        PrintNto1(n, m + 1);
        Console.Write(m + " ");
    }
}

int number = ReadNumber("Введите N: ");
int m = 1;
PrintNto1(number, m);