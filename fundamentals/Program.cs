void PrintSelectionOption(string selectedOption)
{
    Console.WriteLine("Selected option:" + selectedOption);
}


Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs!");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO!");
Console.WriteLine("[E]xit!!");


string userChoice = Console.ReadLine() ?? "";

if (userChoice == "S")
{
    PrintSelectionOption(userChoice);
}

if (userChoice == "A")
{
    PrintSelectionOption(userChoice);
}

if (userChoice == "R")
{
    PrintSelectionOption(userChoice);
}

if (userChoice == "E")
{
    PrintSelectionOption(userChoice);
}

//Console.WriteLine("User input:" + userChoice);
Console.ReadKey();
