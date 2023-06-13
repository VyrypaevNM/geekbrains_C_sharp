// Задача 3: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Input day's number: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 1 || day>7) 
{
    Console.WriteLine(" not a weekday");
}
else if (day > 5) 
{
    Console.WriteLine("It's a weekend");
}
else Console.WriteLine("It's a weekday");
