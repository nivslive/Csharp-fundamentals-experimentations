static void ResultValuePrint(int number1, int number2, int result)
{
    Console.WriteLine("O valor de" + number1 +  "e" + number2 + "deu:" + result);
}
static int intParser(string data)
{
    int _;
    if (int.TryParse(data, out _))
    {
        _ = int.Parse(data);
        return _;
    }
    return 0;
}
Console.WriteLine("Input the first number:");
int number1 = intParser(Console.ReadLine() ?? "");
Console.WriteLine("Input the second number:");
int number2 = intParser(Console.ReadLine() ?? "");

Calculator.Functions calculator = new(number1, number2);

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd Numbers!");
Console.WriteLine("[S]ubtract Numbers!");
Console.WriteLine("[M]ultiply Numbers!");
string action = Console.ReadLine() ?? "E";
int result;
if(action == "A")
{
    result = calculator.Add();
}
else if (action == "M")
{
    result = calculator.Mult();
}
else if (action == "S")
{
    result = calculator.Sub();
}
else if (action == "E")
{
    result = 0;
}
else {
    result = 0;
}

ResultValuePrint(
    calculator.GetNumber1(),
    calculator.GetNumber2(),
    result
);