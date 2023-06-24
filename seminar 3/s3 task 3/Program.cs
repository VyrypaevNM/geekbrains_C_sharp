// Задача 4: Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел от 1 до N.

Console.Clear();
int Input(string message)
{
System.Console.Write($"{message} ");
return int.Parse(Console.ReadLine());
}

int number = Input("Input number:");

for (int i = 1; i <= number; i++)
{
System.Console.WriteLine(Math.Pow(i, 3));
}