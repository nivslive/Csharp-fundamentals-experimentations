static void ResultValuePrint(int value)
{
    Console.WriteLine("O valor deu:" + value);
}
static int intParser(string data)
{
    if (int.TryParse(data, out int number))
    {
        return int.Parse(data);
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

ResultValuePrint(result);