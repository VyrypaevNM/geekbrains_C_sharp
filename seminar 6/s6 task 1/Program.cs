// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Clear();


int counter = 0;
int number = -1;
while (number < 1) 
{
    number = Input("Input positive quantity of numbers: ");
}

for (int i = 0; i < number; i++)
    {
        int temp = Input($"Input number № {i+1}: ");
        if (temp > 0) {counter++;}
    }

System.Console.WriteLine($"Quantity of positive numbers equal {counter}");

int Input(string message)
{
    int num;
    Console.Write(message);
    num = Convert.ToInt32(Console.ReadLine());
    return(num);
}