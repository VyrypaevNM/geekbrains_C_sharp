// ввод случайного числа
int num1 = new Random().Next(1, 10);
Console.Write("Input number, please = ");
double num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("random number = ");
Console.WriteLine(num1);
Console.Write(num1);
Console.Write("/");
Console.Write(num2);
Console.Write("=");
Console.WriteLine(num1 / num2);