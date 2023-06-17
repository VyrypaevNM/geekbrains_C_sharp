//Напишите программу, которая выводит случайное число из отрезка [10, 9999]
// и показывает наибольшую цифру числа.

int number = RandNum();
System.Console.WriteLine($"Random number = {number}; biggest digit = {calc(number)}");


int RandNum()
{
    return (new Random().Next(10, 10000));    
}

int calc(int num)
{
    int rem, max;
    max = num % 10;
    while (num > 0)
    {
        num = num / 10;
        rem = num % 10;
        if (rem > max) {max = rem;}
    } 
    return (max);
}