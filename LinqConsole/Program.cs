// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string str = "23444";
int xyz = str.IntegerExtension();
Console.WriteLine(xyz);

int i = 30, j = 40;
Console.WriteLine($"{i} is greater than {j}-{i.IsGreaterThan(j)}");

str = "Down the lane there is a house";
Console.WriteLine($"Number of Words: {str.GetWordCount()");
