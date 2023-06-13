// Задача 4: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (num < 2) {Console.WriteLine($"There isn't any even number between 1 and {num}");}
int count = 2;
while (count <= num)
{
    Console.Write($"{count}  ");
    count = count + 2;
}