// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] Mass = new int[8];
Console.WriteLine("Введите числа для заполнения массива: ");
for (int i = 0; i < Mass.Length; i++)
{
    Console.Write($"Введите {i + 1}-е число: ");
    Mass[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Вот такой получился массив: ");
for (int i = 0; i < Mass.Length; i++)
{
    Console.Write(Mass[i] + " ");
}