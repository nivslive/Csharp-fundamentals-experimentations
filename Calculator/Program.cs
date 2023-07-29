static string placeholderToAction(string action)
{
    switch (action)
    {
        //case "E":
        //    action = "Saída";
        //    break;
        case "A":
            action = "+";
            break;
        case "S":
            action = "-";
            break;
        case "M":
            action = "*";
            break;
    }

    return action;
}
static void ResultValuePrint(int number1, int number2, string action, int result)
{
    Console.WriteLine(
        $"O valor de {number1} {placeholderToAction(action)} {number2} deu: {result}");
}

static int IntParser(string data)
{
    int _;
    if (int.TryParse(data, out _))
    {
        _ = int.Parse(data);
        return _;
    }
    return 0;
}
Calculator.Functions calculator = new();

// first number
Console.WriteLine("Input the first number:");
int number1 = IntParser(Console.ReadLine() ?? "");
calculator.SetNumber1(number1);

Console.WriteLine("Input the second number:");
int number2 = IntParser(Console.ReadLine() ?? "");
calculator.SetNumber2(number2);

// interface
Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd Numbers!");
Console.WriteLine("[S]ubtract Numbers!");
Console.WriteLine("[M]ultiply Numbers!");


// the user action
string actionResult = Console.ReadLine() ?? "E";
string action = actionResult.ToUpper();

int result;

switch(action) {
    case "A":
        result = calculator.Add();
        break;
    case "M":
        result = calculator.Mult();
        break;
    case "S":
        result = calculator.Sub();
        break;
    default:
        result = 0;
        break;
}

ResultValuePrint(
    calculator.GetNumber1(),
    calculator.GetNumber2(),
    action,
    result
);
Console.ReadLine();