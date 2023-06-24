//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


Console.Clear();
int number = Input("Input number: ");
Console.WriteLine($"Sum of digits in number {number} is equal  {calc(number)}");


int Input(string message)
{
    int num;
    Console.Write(message);
    num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int calc(int rez)
{
    int sum = 0;
    while (rez > 0)
    {
        sum =sum + rez %10;
        rez =rez / 10;        
    }
    return (sum);
}