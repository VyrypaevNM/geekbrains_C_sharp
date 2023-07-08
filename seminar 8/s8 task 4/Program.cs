// See https://aka.ms/new-console-template for more information

Console.Clear();
System.Console.Write("input N = ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Clear();
int [,] mx = SpireMatrix(n);
output(mx,n,n);

int [,] SpireMatrix(int size)
{
  int [,] arr = new int [size, size];
  int sizeX = size;
  int sizeY = size;
  int Summ = size * size;
  int CorrectY = 0;
  int CorrectX = 0;
  int Count = 1;
  while( sizeY > 0 )
  {
    for ( int y = 0; y < 4; y++ )
    {
      for ( int x = 0; x < ( ( sizeX < sizeY ) ? sizeY : sizeX ); x++ )
      {
        if ( y == 0 && x < sizeX - CorrectX && Count <= Summ )
          arr[y + CorrectY, x + CorrectX] = Count++;
        if ( y == 1 && x < sizeY - CorrectY && x != 0 && Count <= Summ )
          arr[x + CorrectY, sizeX - 1] = Count++;
        if ( y == 2 && x < sizeX - CorrectX && x != 0 && Count <= Summ )
          arr[sizeY - 1, sizeX - (x + 1)] = Count++;
        if ( y == 3 && x < sizeY - ( CorrectY + 1 ) && x != 0 && Count <= Summ )
          arr[sizeY - (x + 1), CorrectY] = Count++;
      }
    }
    sizeY--;
    sizeX--;
    CorrectY ++;
    CorrectX ++;
  }
  return (arr);
}		




void output(int[,] arr, int Rnum, int Cnum)
{
    for (int i = 0; i < Rnum; i++)
    {
       for (int j = 0; j < Cnum; j++)
       {
        System.Console.Write($"{arr[i,j]} \t");
       }
       System.Console.WriteLine();
       System.Console.WriteLine();
       System.Console.WriteLine();
       System.Console.WriteLine();
    }
    
    
}