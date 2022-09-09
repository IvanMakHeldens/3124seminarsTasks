// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

int ReadNumber (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
} 

int A = ReadNumber("Введите первое число:");
int B = ReadNumber("Введите второе число:");
int res = 1;
for (int count = 1; count <= B; count++)
{
    res = A * res;

}
Console.WriteLine(res);