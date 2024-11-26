// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, user! Please, enter a number: ");
string userInput = Console.ReadLine();
Console.WriteLine("Thanks! Now another one, please: ");
string userInput2 = Console.ReadLine();
int userInput3 = int.Parse(userInput);
int userInput4 = int.Parse(userInput2);
Console.WriteLine("The sum of your two numbers is " + (userInput3+userInput4));
