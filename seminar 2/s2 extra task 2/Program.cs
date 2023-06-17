// Напишите программу, которая будет принимать на вход пять чисел 
// и выводить сумму и среднее арифметическое этих чисел.
int count = 0; 
double average = 0, sum = 0;
int [] array = new int[5];

System.Console.WriteLine("start");
while (count < 5)
{
    //array[count]=Convert.ToInt32(Console.ReadLine());
    count++;
    sum = sum + Convert.ToInt32(Console.ReadLine());//array[count];
    
}
average = sum / count;
System.Console.WriteLine($"{sum} {average}");