// Задача 1: Задайте двумерный массив. 
//Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

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

int [] SortedRow = new int[ColumnNumber];
int [] Row = new int [ColumnNumber];
int [,] SortedArray = new int[RowNumber, ColumnNumber];

int[,] array = GenerateArray(RowNumber, ColumnNumber);
output(array, RowNumber, ColumnNumber);

for (int i=0; i<RowNumber; i++)
{
    for (int j = 0; j < ColumnNumber; j++)
    {
        Row[j] = array[i,j];
    }
    SortedRow = Sort(Row);
    
    for (int j = 0; j<ColumnNumber; j++)
    {
        SortedArray[i,j] = SortedRow[j];
    }
    
}

System.Console.WriteLine();
System.Console.WriteLine("Sorted array:");
output(SortedArray, RowNumber, ColumnNumber);



//foreach(int item in Sortedrow)
//{
//    System.Console.WriteLine(item );
//}

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
            arr[i,j]=  (new Random().Next(1, 100));
        }
    }
   
    return arr;
}

int [] Sort(int [] arr)

{
    int temp;
    for(int i = 0; i < arr.Length-1; i++)
    {
        for (int j=0; j<arr.Length-1; j++)
        {
            if (arr[j] < arr[j+1])
            {
                temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1]=temp;
            }
        }
    }
    return (arr);
}