//Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
System.Console.WriteLine("Input first number");
int firstNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input second number");
int secondNum = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();
System.Console.WriteLine($"Ackerman({firstNum}, {secondNum}) = {Ack(firstNum,secondNum)}");

int Ack(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return Ack(m - 1, 1);
    else
      return Ack(m - 1, Ack(m, n - 1));
}