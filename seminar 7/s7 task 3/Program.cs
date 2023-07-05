// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();



int RowNumber = -1;
while (RowNumber < 1) 
{
    RowNumber = Input("Input positive quantity of rows: ");
}

int ColumNumber = -1;
while (ColumNumber < 1) 
{
    ColumNumber = Input("Input positive quantity of columns: ");
}

int[,] array = GenerateArray(RowNumber, ColumNumber);
output(array, RowNumber, ColumNumber);
int[] summa = CalcAvg(RowNumber,ColumNumber,array);
//output(sum,1,ColumNumber);

int Input(string message)
{
    int num;
    Console.Write(message);
    num = Convert.ToInt32(Console.ReadLine());
    return(num);
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

int[] CalcAvg(int Rnum, int Cnum, int [,] arr)
{
    int[] sum = new int[Rnum];
    for (int j = 0; j<Cnum; j++)
    {
        //sum[j]=0;
        for (int i = 0; i < Rnum; i++)
        {
            sum[j]=sum[j] + arr[i,j];
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine("Average on columns:");
    for (int j=0; j<Cnum; j++)
    {
        
        double temp = (sum[j]/1.0)/Rnum;
        System.Console.Write($"{temp} \t");
    }
    return sum;
    
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
