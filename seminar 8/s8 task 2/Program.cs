// Задача 2: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.


Console.Clear();

int RowNumber = -1;
while (RowNumber < 1) 
{
    RowNumber = Input("Input positive quantity of rows: ");
}

int ColumnNumber = -1;
while (ColumnNumber < 1) 
{
    ColumnNumber = Input("Input positive quantity of columns: ");
}
Console.Clear();

int sum=0;
int temp = 0;
int tempRow = 0;

int[,] array = GenerateArray(RowNumber, ColumnNumber);
output(array, RowNumber, ColumnNumber);
System.Console.WriteLine();

for (int i=0; i<ColumnNumber; i++)
{
    temp = temp + array[0,i];
}

for (int i=0; i<RowNumber; i++)
{
    sum = 0;
    for (int j = 0; j < ColumnNumber; j++)
    {
        sum = sum + array[i,j];
    }
    
    if (sum < temp)
    {
        temp = sum;
        tempRow = i;
    }
    
    System.Console.WriteLine($"Sum in row {1+i}: {sum}");
}

System.Console.WriteLine();
System.Console.WriteLine($"Minimal sum row's number is {tempRow+1}");

int Input(string message)
{
    int num;
    Console.Write(message);
    string StringNum = Console.ReadLine();
    num = Convert.ToInt32(ValidateNumber(StringNum));
    //num = Convert.ToInt32(Console.ReadLine());
    return(num);
}

double ValidateNumber(string Str)
{
    double number;
    //string Str = Console.ReadLine();
    if (double.TryParse(Str, out number))
    {
        System.Console.WriteLine(number);
    }
    else
    {
        System.Console.WriteLine("It's not a number");
    }
    return (number);
}


void output(int[,] arr, int Rnum, int Cnum)
{
    //System.Console.Write("[");
    for (int i = 0; i < Rnum; i++)
    {
       for (int j = 0; j < Cnum; j++)
       {
        System.Console.Write($"{arr[i,j]} \t");
       }
       System.Console.WriteLine();
    }
    
    
}

int[,] GenerateArray(int Rnum, int Cnum)
{
    int[,] arr = new int[Rnum, Cnum];
    for (int i = 0; i<Rnum; i++)
    {
        for (int j = 0; j < Cnum; j++)
        {
            arr[i,j]=  (new Random().Next(1, 10));
        }
    }
   
    return arr;
}