// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input user name");
string username = Console.ReadLine();
if (username.ToLower() == "nick")
{
    Console.WriteLine("Wow, it's Nick!");
}
else {Console.Write("Hi, ");Console.WriteLine(username);}
