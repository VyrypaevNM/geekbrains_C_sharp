// Задача 3: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
//Console.Write("Input day's number: ");
//int day = Convert.ToInt32(Console.ReadLine());
//if (day < 1 || day>7) 
//{
//    Console.WriteLine(" not a weekday");
//}
//else if (day > 5) 
//{
//    Console.WriteLine("It's a weekend");
//}
//else Console.WriteLine("It's a weekday");
int DayNumber = Input("Input day's number: ");
if (Valid(DayNumber))
{
    Console.WriteLine(calc(DayNumber));
}
else 
{
    Console.WriteLine("Not a weekday");
}

int Input(string message)
{
    int num;
    Console.Write(message);
    num = Convert.ToInt32(Console.ReadLine());
    return num;
}




bool Valid(int num)
{
    bool var;
    var = (num > 0 && num < 8);
    return var;
}

string calc(int rez)
{
    string message;
    if (rez > 5)
    {
        message = "It's a weekend";
    }
    else 
    {
        message = "It's a weekday";
    }
    return message;
}
