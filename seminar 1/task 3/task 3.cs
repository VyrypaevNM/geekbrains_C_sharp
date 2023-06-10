// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).
Console.WriteLine("Input number");
string answer = "No";
int num = Convert.ToInt32(Console.ReadLine());
if (num %2 == 0) { answer = "Yes";}
if (num == 0) { answer = "Neither nor";}
Console.WriteLine(answer);
