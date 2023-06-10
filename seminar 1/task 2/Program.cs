//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Input first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number");
int num3 = Convert.ToInt32(Console.ReadLine());

int  maxNum = num1;
if (num2 > maxNum && num2 > num3) {maxNum = num2;}
if (num3 > maxNum && num3 > num2) {maxNum = num3;}

Console.Write($"Biggest number is {maxNum}");