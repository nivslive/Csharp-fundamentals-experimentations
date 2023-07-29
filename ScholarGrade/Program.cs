static string ConvertPointsToGrade(int points)
{
    return points switch
    {
        10 or 9 or 8 or 7 => "Good!",
        6 or 5 or 4 => "Moreless...",
        3 or 2 or 1 => "bad!",
        0 => "Horrible. did you nothing on that month?",
        _ => "Not have points? wrong data?",
    };
}

Console.WriteLine(ConvertPointsToGrade(5));