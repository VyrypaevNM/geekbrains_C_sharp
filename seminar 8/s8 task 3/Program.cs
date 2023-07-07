// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
Console.Clear();

int RowNumber1 = -1;
while (RowNumber1 < 1) 
{
    RowNumber1 = Input("Input positive quantity of matrix 1 rows: ");
}

int ColumnNumber1 = -1;
while (ColumnNumber1 < 1) 
{
    ColumnNumber1 = Input("Input positive quantity of matrix 1 columns: ");
}

int RowNumber2 = -1;
while (RowNumber2 < 1) 
{
    RowNumber2 = Input("Input positive quantity of matrix 2 rows: ");
}

int ColumnNumber2 = -1;
while (ColumnNumber2 < 1) 
{
    ColumnNumber2 = Input("Input positive quantity of matrix 2 columns: ");
}

Console.Clear();

int sum=0;
int temp = 0;
int tempRow = 0;
//int [,] Mx1 = new int [RowNumber1, ColumnNumber1];
//int [,] Mx2 = new int [RowNumber2, ColumnNumber2];
int [,] productMatrix = new int [RowNumber1, ColumnNumber2];
//int [,] productMatrix = new int [2, 3];
//int [,] Mx1 = new int [r, 2];
//int [,] Mx2 = new int [2, 3];
//Mx1[0,0] =2;
//Mx1[0,1] =4;
//Mx1[1,0] =3;
//Mx1[1,1] =2;

//Mx2[0,0] =3;
//Mx2[0,1] =4;
//Mx2[0,2] =2;
//Mx2[1,0] =3;
//Mx2[1,1] =3;
//Mx2[1,2] =1;




int[,] Mx1 = GenerateArray(RowNumber1, ColumnNumber1);
int[,] Mx2 = GenerateArray(RowNumber2, ColumnNumber2);
output(Mx1, RowNumber1, ColumnNumber1);
System.Console.WriteLine();
output(Mx2, RowNumber2, ColumnNumber2);
System.Console.WriteLine();

if (RowNumber2== ColumnNumber1)
{
    for (int i=0; i<RowNumber1; i++)
    {
    
        for (int j=0; j<ColumnNumber2; j++)
        {
            for (int k=0; k < RowNumber2; k++)
            productMatrix[i,j] += (Mx1[i,k] * Mx2[k,j]);
        }
    }
    output(productMatrix, RowNumber1, ColumnNumber2);
}
else {System.Console.WriteLine("Matrixes can'n be multiplied");}


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