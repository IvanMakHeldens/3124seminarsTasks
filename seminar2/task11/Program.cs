// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(99, 1000);
Console.WriteLine($"Сгенерировалось случайное число {number}");

int digit2 = number % 10;
int digit1 = number / 100;


 // Console.WriteLine(digit1);
 // Console.WriteLine(digit2);


int result = digit1 * 10 + digit2;

Console.WriteLine("Получилось число " + result);
Console.WriteLine("Новое число: {0}{1}",digit1,digit2);
Console.WriteLine($"Новое число: {digit1}{digit2}");
Console.WriteLine("Новое число: " + digit1 + digit2);





