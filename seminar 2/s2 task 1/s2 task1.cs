// Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа. Не использовать строки
Console.Write("Input 3-digit number: ");
int var = Convert.ToInt32(Console.ReadLine());
if (var<100 || var>999)
{
 Console.WriteLine("It's not a 3-digit number");
}
else {
    Console.WriteLine(var / 10 % 10);
}