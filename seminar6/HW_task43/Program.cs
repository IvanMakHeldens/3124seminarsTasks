// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ReadNumber (string message)
{
    Console.Write(message);
    return Convert.ToSingle(Console.ReadLine());
} 

double B1 = ReadNumber ("Введите b1: ");
double K1 = ReadNumber ("Введите k1: ");
double B2 = ReadNumber ("Введите b2: ");
double K2 = ReadNumber ("Введите k2: ");

if (K1 == K2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    double X = (B2 - B1) / (K1 - K2); 
    double Y = K1 * X + B1;
    Console.WriteLine($"Точка пересечения прямых ({X}; {Y})");
}