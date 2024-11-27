// See https://aka.ms/new-console-template for more information
int age;
string userInput;
bool isAgeParsed = false;

Console.WriteLine("Enter your age: ");

while (!isAgeParsed)
{
    userInput = Console.ReadLine();
    isAgeParsed = int.TryParse(userInput, out age);
    if(isAgeParsed)
    {
        Console.WriteLine($"Age read as {age}");
        break;
    }
    Console.WriteLine("Please, enter a valid age: ");
}