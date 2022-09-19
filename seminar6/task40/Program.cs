// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int ReadNumber (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
} 


int numberA = ReadNumber("Введите первое число:");
int numberB = ReadNumber("Введите второе число:");
int numberC = ReadNumber("Введите третье число:");

if(numberA < numberB + numberC && numberB < numberA + numberC && numberC < numberA + numberB)
{
    Console.WriteLine($"Может существовать треугольник с длинами сторон {numberA}, {numberB} и {numberC}");
}
else
{
    Console.WriteLine($"Не может существовать треугольник с длинами сторон {numberA}, {numberB} и {numberC}");
}
