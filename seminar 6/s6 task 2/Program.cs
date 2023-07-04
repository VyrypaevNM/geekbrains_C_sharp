//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.


Console.Clear();


double k1 = Input("Input coefficient k for first line k1= ");
double b1 = Input("Input coefficient b for first line b1= ");
double k2 = Input("Input coefficient k for first line k2= ");
double b2 = Input("Input coefficient b for first line b2= ");

if ((k1 == k2) & (b1 == b2))
{
    System.Console.WriteLine("The lines are same");
}
else if (k1 == k2)
{
    System.Console.WriteLine("The lines have no any intersections");
}
else
{
    double X = (b2-b1)/(k1-k2);
    double Y = k1 * X + b1;
    System.Console.WriteLine($"Lines Y = {k1}*X +{b1} and Y = {k2}*X +{b2} have intersection in dot X = {X}, Y = {Y}");
}

double Input(string message)
{
    double num;
    Console.Write(message);
    num = Convert.ToDouble(Console.ReadLine());
    return(num);
}