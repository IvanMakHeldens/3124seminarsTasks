// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату первой точки по X:");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату первой точки по Y:");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату первой точки по Z:");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату второй точки по X:");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату второй точки по Y:");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату второй точки по Z:");
int zB = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((xB - xA),2) + Math.Pow((yB - yA),2) + Math.Pow((zB - zA),2));

Console.WriteLine($"{distance:f2}");