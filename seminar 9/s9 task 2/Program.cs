//Задача 2: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

Console.Clear();
System.Console.WriteLine("Input first number");
int firstNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input second number");
int secondNum = Convert.ToInt32(Console.ReadLine());



if (secondNum < firstNum)
{
    int temp = secondNum;
    secondNum = firstNum;
    firstNum = temp;
}

System.Console.WriteLine();
System.Console.WriteLine($"Sum = {Summ(firstNum,secondNum)}");

int Summ(int firstNum, int secondNum)
{
    //System.Console.WriteLine(firstNum);
    if(firstNum > secondNum-1)  return(firstNum);
    return firstNum + Summ(firstNum +1, secondNum);
}

