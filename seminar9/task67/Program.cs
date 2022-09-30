// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int ReadNumber (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} 

int SumOfDigit(int number)
{
    int sum = 0;
    if(number == 0)
    {
        return sum;
    }
    else
    {
       return (number % 10 ) + SumOfDigit(number/10);
    }       
}
int number = ReadNumber("Введите число: ");
Console.Write(SumOfDigit(number));




