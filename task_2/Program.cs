// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите число n1: ");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число n2: ");
double n2 = Convert.ToDouble(Console.ReadLine());

if (n1>n2)
{
    Console.WriteLine("n1 наибольшее число");
    Console.Write("n2 наименьшее число");
}
else
{
    Console.WriteLine("n1 наименьшее число");
    Console.Write("n2 наибольшее число");
}