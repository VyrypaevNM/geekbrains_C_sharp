// Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, кратны ли эти числа предварительно 
// введенному числу, при кратности - цикл прерывается.
int num = Convert.ToInt32(Console.ReadLine());
int Rnum = new Random().Next(1, 10000);
System.Console.WriteLine(Rnum);
while (Rnum % num !=0)
{
    Rnum = new Random().Next(1, 10000);
    System.Console.WriteLine(Rnum);
}