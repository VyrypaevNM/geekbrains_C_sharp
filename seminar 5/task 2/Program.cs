// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


Console.Clear();

int number = 0;
while (number < 1) 
{
    number = Input("Input positive number of array's elements: ");
}
int[] array = GenerateArray(number);
int quantity = Calc(array);
output(number, array, quantity);


int Input(string message)
{
    int num;
    Console.Write(message);
    num = Convert.ToInt32(Console.ReadLine());
    return(num);
}

int[] GenerateArray(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i<len; i++)
    {
        arr[i]= new Random().Next(1, 10);
    }
    
    return arr;
}

int Calc(int[] arr)
{
    int sum = 0;
    //int i;
    for(int i = 0; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }
    return(sum);
}
void output(int len, int[] arr, int sum)
{
    System.Console.Write("[");
    for (int i = 0; i < len-1; i++)
    {
       System.Console.Write($"{arr[i]}, ");
    }
    
    System.Console.WriteLine($"{arr[len-1]}]");
    System.Console.WriteLine($"Sum of elements on odd position in array is {sum}");
}

