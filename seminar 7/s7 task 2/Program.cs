// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

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

int Elrow = -1;
while (Elrow < 1) 
{
    Elrow = Input("Input element row number: ");
}

int Elcol = -1;
while (Elcol < 1) 
{
    Elcol = Input("Input element column number: ");
}

int[,] array = GenerateArray(RowNumber, ColumNumber);
output(array, RowNumber, ColumNumber, Elrow, Elcol);

int Input(string message)
{
    int num;
    Console.Write(message);
    num = Convert.ToInt32(Console.ReadLine());
    return(num);
}


int [,] GenerateArray(int Rnum, int Cnum)
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

void output(int[,] arr, int Rnum, int Cnum, int elemRow, int elemCol)
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
    
    if ((elemCol < Cnum +1) && (elemRow < Rnum +1))
    {
        System.Console.WriteLine($"Element position [{elemRow}, {elemCol}] = {arr[elemRow-1,elemCol-1]}");
    }
    else System.Console.WriteLine("Element doesn't exist");
}
