// total < 10 - 1%
// total >= 10 && total < 20 -5%
// total >= 20 - 10%

Console.WriteLine("Provide total: ");
int userInPut = Int32.Parse(Console.ReadLine());

double discount = CalculateDiscount(userInPut);

Console.WriteLine($"Your discount is: {discount}%");

double newTotal = CalculateNewTotal(userInPut, discount);

Console.WriteLine($"Your updated total with {discount}%: {newTotal}");

static double CalculateDiscount(int total)
{
    if (total < 10)
    {
        return 1;
    }
    else if (total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double CalculateNewTotal(double total, double discount)
{
    return total - total * discount / 100;
}