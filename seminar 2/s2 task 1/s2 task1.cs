// Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа. Не использовать строки
//Console.Write("Input 3-digit number: ");
//int var = Convert.ToInt32(Console.ReadLine());
//if (var<100 || var>999)
//{
// Console.WriteLine("It's not a 3-digit number");
//}
//else {
//    Console.WriteLine(var / 10 % 10);
//}

int number = Input("Input 3-digit number: ");
if (valid(number)) 
{
    Console.WriteLine(number / 10 % 10);
}
else 
{
    System.Console.WriteLine("It's not a 3-digit number");
}

//описание процедур

int Input(string message)
{
    int num;
    System.Console.WriteLine(message);
    num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool valid(int num)
{
    bool var;
    var = (num> 99 && num < 1000);
    return(var);
}