// Simple echo program: read a line from the user and print it back.
Console.Write("Enter some text: ");
string? input = Console.ReadLine();
if (string.IsNullOrEmpty(input))
{
	Console.WriteLine("No input provided.");
}
else
{
	Console.WriteLine($"You entered: {input}");
}
