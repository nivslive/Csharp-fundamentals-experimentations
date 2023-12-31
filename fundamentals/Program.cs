﻿using fundamentals;

string text = "oi";
//NumberExperimentations numberClass = new();
NumberExperimentations.AddNumberTestIfAboveThanTen(10, 5);
NumberExperimentations.IsLong(text);

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
int userChoiceIfANumber;
if(int.TryParse(userChoice, out userChoiceIfANumber))
{
   userChoiceIfANumber = int.Parse(userChoice);
} else
{
    userChoiceIfANumber = 0;
}

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

Console.WriteLine("User input:" + (userChoiceIfANumber == 0 ? userChoice.GetType() : userChoiceIfANumber.GetType()) + " " + userChoiceIfANumber ?? userChoice);
Console.ReadKey();
