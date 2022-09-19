// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int ReadNumber (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
} 
string numberBin = "";

int numberDec = ReadNumber("Введите число:");
while (numberDec > 0)
{
    int bin = numberDec % 2;
    numberDec = numberDec / 2;
    numberBin = bin + numberBin;
}


Console.WriteLine(numberBin);
