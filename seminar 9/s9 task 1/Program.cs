// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все 
//чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"

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
System.Console.WriteLine($"Even numbers between {firstNum} and {secondNum}:");
if (firstNum % 2 != 0) {firstNum ++;}
printEvenNumbers(firstNum,secondNum);

void printEvenNumbers(int firstNum, int secondNum)
{
    if(firstNum > secondNum)  return;
    System.Console.Write($"{firstNum} ");
    printEvenNumbers(firstNum + 2, secondNum);
}

