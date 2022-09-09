// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// Console.ForegroundColor = ConsoleColor.Green;
int[] Mass = new int[8];
Random rand = new Random();
// int a = 0;
// while(a == 0)
// {
    for (int i = 0; i < Mass.Length; i++)
    {
        Mass[i] = rand.Next(0, 2);
        Console.Write(Mass[i] + " ");
    }
// }
