Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs!");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO!");
Console.WriteLine("[E]xit!!");

string userChoice = Console.ReadLine() ?? "";
bool isUserInputABC =
    userChoice == "ABC" ||
    userChoice == "test" ||
    userChoice == "banana";
if (userChoice.Length > 10)
{
    Console.WriteLine("IS ABC!");
}
Console.WriteLine("User input:" + userChoice);
Console.ReadKey();