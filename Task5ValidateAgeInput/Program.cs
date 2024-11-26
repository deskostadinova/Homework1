// See https://aka.ms/new-console-template for more information
int age;

Console.WriteLine("Please, enter your age: ");
while (!int.TryParse(Console.ReadLine(), out age))
{
    Console.WriteLine("Please, enter a valid age: ");
}