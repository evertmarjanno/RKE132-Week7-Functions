Console.WriteLine("Enter the operation (+/-): ");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("Enter first number: ");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case '+':
        Addition(firstNum, secondNum);
        break;
    case '-':
        Subtraction(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("invalid operation");
        break;
}

static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Subtraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}