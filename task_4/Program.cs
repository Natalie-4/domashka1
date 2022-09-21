// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write("Первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Третье число: ");
double c = Convert.ToDouble(Console.ReadLine());

if (a>b && a>c)
{
   Console.WriteLine("Первое число максимальное");
}

else
{
    if (b>a && b>c)
    {
        Console.WriteLine("Второе число максимальное");
    }
    else 
    {
     Console.WriteLine("Третье число максимальное");
    }
}