Console.WriteLine("Enter a word: ");
string? userInPut = Console.ReadLine();

PrintAnyWord(userInPut);

static void PrintAnyWord(string? anyString)
{
    anyString = anyString?.ToUpper();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}
