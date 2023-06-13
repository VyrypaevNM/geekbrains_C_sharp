// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет. Не использовать строки
Console.Write("Input number: ");
int var = Convert.ToInt32(Console.ReadLine());
int rez = var;
if (var<100)
{
    Console.WriteLine("There isn't a third digit in this number");
}
while (rez>999) 
{
    rez = rez / 10;
}
Console.WriteLine(rez%10);