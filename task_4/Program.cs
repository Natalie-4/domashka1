// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Первое число: ");
double a = Convert.ToDouble(Console.Readline());
Console.Write("Второе число: ");
double b = Convert.ToDouble(Console.Readline());
Console.Write("Третье число: ");
double c = Convert.ToDouble(Console.Readline());
double max = a;
if (b>max)
{
    max = b;
    Console.WriteLine("b наибольшее число");
    
}
else
{
    if (c>max && c>b)
    {
        max = c;
        Console.WriteLine("c наибольшее число");
    }
   else 
   {
    max = a;
    Console.WriteLine("a наибольшее число");
   }
}
