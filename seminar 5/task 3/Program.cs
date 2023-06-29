// Задача 3: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


Console.Clear();

int number = 0;
while (number < 1) 
{
    number = Input("Input positive number of array's elements: ");
}
double[] array = GenerateArray(number);
double max = MaxElement(array);
double min = MinElement(array);
output(array, min, max);

int Input(string message)
{
    int num;
    Console.Write(message);
    num = Convert.ToInt32(Console.ReadLine());
    return(num);
}

double[] GenerateArray(int len)
{
    double[] arr = new double[len];
    for (int i = 0; i<len; i++)
    {
        arr[i]= Math.Round((new Random().Next(1, 100))/(new Random().Next(1, 10))/3.0,2);
    }
    
    return arr;
}

double MinElement(double[] arr)
{
    double min = arr[0];
    foreach(double item in arr)
    {
        if (item < min) {min = item;}
    }
    return(min);
}

double MaxElement(double[] arr)
{
    double max = arr[0];
    foreach(double item in arr)
    {
        if (item > max) {max = item;}
    }
    return(max);
}

void output(double[] arr, double min, double max)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length -1; i++)
    {
       System.Console.Write($"{arr[i]}, ");
    }
    
    System.Console.WriteLine($"{arr[arr.Length-1]}]");
    System.Console.WriteLine($"Difference between Max element and Min element in array is:");
    System.Console.WriteLine($"{max} - {min} = {max - min}");
}
