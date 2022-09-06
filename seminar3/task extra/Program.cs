// Написать метод для разворота массива, не используя память под дополнительный массив
Console.WriteLine("Введите размер массива:");
int s = Convert.ToInt32(Console.ReadLine());

int[] Mass = new int[s];
Random rand = new Random();

for (int i = 0; i < Mass.Length; i++)
{
     Mass[i] = rand.Next(1, 100);
}
//Вывод массива до сортировки
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < Mass.Length; i++)
{
    Console.Write(Mass[i] + " ");
}
while (s > 1)
{   int i = 0;
    while (i < s - 1)
    {
        int t = Mass[i+1];
        Mass[i+1] = Mass[i];
        Mass[i] = t;
        i++;
    }
    s--;
    
}

Console.WriteLine();
Console.WriteLine("Получился массив:");
for (int i = 0; i < Mass.Length; i++)
{
    Console.Write(Mass[i] + " ");
}



