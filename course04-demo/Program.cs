// See https://aka.ms/new-console-template for more information


string first = "Hello";
string second = "World";

string result1 = string.Format("{0} {1}!", first, second);
string result2 = $"{first} {second}!";

Console.WriteLine(result1);
Console.WriteLine(result2);