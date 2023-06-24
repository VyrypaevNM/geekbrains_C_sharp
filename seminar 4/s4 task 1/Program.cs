//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


Console.Clear();
int number = Input("Input number: ");
int power = Input("Input power: ");
if (Valid(power))
{
    System.Console.WriteLine($"{number} ^ {power} = {calc(number, power)}");
}
else {System.Console.WriteLine("Incorrect value of power");}



int Input(string message)
{
    int num;
    Console.Write(message);
    num = Convert.ToInt32(Console.ReadLine());
    return num;
}


bool Valid(int num)
{
    return (num > 0);
}

double calc(int number, int power)
{
    double var = number;
    
    for (int i = 2; i <= power; i++)
    {
        var = var * number;
    }
    return var;
}