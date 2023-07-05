// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


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

double[,] array = GenerateArray(RowNumber, ColumNumber);
output(array, RowNumber, ColumNumber);

int Input(string message)
{
    int num;
    Console.Write(message);
    num = Convert.ToInt32(Console.ReadLine());
    return(num);
}


double[,] GenerateArray(int Rnum, int Cnum)
{
    double[,] arr = new double[Rnum, Cnum];
    for (int i = 0; i<Rnum; i++)
    {
        for (int j = 0; j < Cnum; j++)
        {
            int randtemp1 = (new Random().Next(-100, 100));
            int randtemp2 = (new Random().Next(1, 10));
            double rez = randtemp1/(randtemp2/1.0);
            //System.Console.WriteLine($"{randtemp1} {randtemp2}, {rez}");
            arr[i,j]=  Math.Round(rez, 2);//randtemp1/randtemp2/3.0;
        }
    }

    
    return arr;
}

void output(double[,] arr, int Rnum, int Cnum)
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
