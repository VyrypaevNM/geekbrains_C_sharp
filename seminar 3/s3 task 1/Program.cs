//Задача 1
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
int number = Input("Input number: ");
if (Valid(number))
{
    Console.WriteLine($"Is this number a palindrome? -  {calc(number)}");
}
else 
{
    Console.WriteLine("It's not a five digit number");
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
    var = ((num > 9999) && (num < 100000));
    return var;
}

bool calc(int rez)
{
    bool var = true;
    int var1 = 0;
    int var2 = rez;
    while (rez > 0)
    {
        var1 = var1 * 10 + rez %10;
        rez = rez / 10;
                
    }
   //System.Console.WriteLine(var1);
   //System.Console.WriteLine(var2);
     
    var = (var1 == var2);
    return var;
}
