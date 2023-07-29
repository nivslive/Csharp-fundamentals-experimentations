Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs!");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO!");
Console.WriteLine("[E]xit!!");

string userChoice = Console.ReadLine() ?? "";
if (userChoice.Length > 11)
{
    Console.WriteLine("IS ABC!");
}
Console.WriteLine("User input:" + userChoice);
Console.ReadKey();