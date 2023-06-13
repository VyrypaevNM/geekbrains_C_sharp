// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
Console.WriteLine("Input first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int num2 = Convert.ToInt32(Console.ReadLine());
int biggest = num2,
    smallest = num1;
if (num1 > num2)
{
    biggest = num1;
    smallest = num2;
}
Console.WriteLine($"Smallest number is {smallest}");
Console.WriteLine($"Biggest number is {biggest}");