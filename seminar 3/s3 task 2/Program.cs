//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
int Input(string message)
{
System.Console.Write($"{message} ");
return int.Parse(Console.ReadLine());
}

int x1 = Input("Input coordinate x1:");
int y1 = Input("Input coordinate y1:");
int z1 = Input("Input coordinate z1:");

int x2 = Input("Input coordinate x2:");
int y2 = Input("Input coordinate y2:");
int z2 = Input("Input coordinate z2:");

double distanceX = x2 - x1;
double distanceY = y2 - y1;
double distanceZ = z2 - z1;

double distance = Math.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);
System.Console.WriteLine($"Distance between points is {distance}");