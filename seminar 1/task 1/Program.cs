// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
Console.WriteLine("Input first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int num2 = Convert.ToInt32(Console.ReadLine());
int a;
if (num1 > num2)
{
    a = num1;
    num1 = num2;
    num2 = a;
}

Console.Write("Smallest number is ");
Console.WriteLine(num1);
Console.Write("Biggest number is ");
Console.WriteLine(num2);