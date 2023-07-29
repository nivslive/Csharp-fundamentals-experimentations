Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs!");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO!");
Console.WriteLine("[E]xit!!");

string userChoice = Console.ReadLine() ?? "";

if (userChoice.Length >= 3)
{
    Console.WriteLine("Short Answer!");
}
else if (userChoice.Length < 10)
{
    Console.WriteLine("Medium Answer");
}
else {
    Console.WriteLine("Short answer.");
}

Console.WriteLine("User input:" + userChoice);
Console.ReadKey();