//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


Console.Clear();
int number = Input("Input number of array's elements: ");
int minValue = Input("Input min value of elements: ");
int maxValue = Input("Input max value of elements: ");
int[] array = GenerateArray(number, minValue, maxValue);
output(number, array);

int Input(string message)
{
    int num;
    Console.Write(message);
    num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] GenerateArray(int len, int bottom, int top)
{
    int[] arr = new int[len];
    for (int i = 0; i<len; i++)
    {
        arr[i]= new Random().Next(bottom,top);
    }
    
    return arr;
}

void output(int len, int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < len-1; i++)
    {
       System.Console.Write($"{arr[i]}, ");
    }
    
    System.Console.WriteLine($"{arr[len-1]}]");
}
   
