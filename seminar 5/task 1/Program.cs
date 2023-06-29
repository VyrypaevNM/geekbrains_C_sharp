//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


Console.Clear();
int number = Input("Input number of array's elements: ");
int[] array = GenerateArray(number);
int quantity = Calc(array);
output(number, array, quantity);


int Input(string message)
{
    int num;
    Console.Write(message);
    num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] GenerateArray(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i<len; i++)
    {
        arr[i]= new Random().Next(100, 1000);
    }
    
    return arr;
}

int Calc(int[] arr)
{
    int quantity = 0;
    foreach(int item in arr)
    {
        if (item % 2 == 0) 
        {
            quantity +=1;
        }
    }
    return(quantity);
}
void output(int len, int[] arr, int quantity)
{
    System.Console.Write("[");
    for (int i = 0; i < len-1; i++)
    {
       System.Console.Write($"{arr[i]}, ");
    }
    
    System.Console.WriteLine($"{arr[len-1]}]");
    System.Console.WriteLine($"Quantity of even elements in array is {quantity}");
}
   
