// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int ReadNumber (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} 

int RaisAtoB(int a, int b)
{   
    
    if(b == 0)
    {
        return 1;
    }
    else
    {
       return a * RaisAtoB(a, b-1);
    }
    
}
int A = ReadNumber("Введите A: ");
int B = ReadNumber("Введите B: ");
Console.WriteLine(RaisAtoB(A, B));             
