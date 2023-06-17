// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет. Не использовать строки
//Console.Write("Input number: ");
//int var = Convert.ToInt32(Console.ReadLine());
//int rez = var;
//if (var<100)
//{
//    Console.WriteLine("There isn't a third digit in this number");
//}
//while (rez>999) 
//{
//    rez = rez / 10;
//}
//Console.WriteLine(rez%10);

int number = Input("Input number: ");
if (Valid(number))
{
    Console.WriteLine($"Third digit is {calc(number)%10}");
}
else 
{
    Console.WriteLine("There isn't a third digit in this number");
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
    var = (num > 99);
    return var;
}

int calc(int rez)
{
    //rez = num;
    while (rez > 999)
    {
        rez = rez / 10;
        System.Console.WriteLine(rez);
    }
    return rez;
}
