// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Radius: ");
string userInput = Console.ReadLine();
double radius = double.Parse(userInput);
double area = Math.PI * radius * radius;
Console.WriteLine($"Area: {area}");