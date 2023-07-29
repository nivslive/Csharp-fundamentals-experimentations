int number = 0;
string @string = "test";
while(number < 10)
{
    number++;
    @string += "s";
    Console.WriteLine($"Number is: {number}");
    Console.WriteLine($"String is: {@string}");
}

Console.WriteLine("Loop is finished.");
Console.WriteLine("Click on any button for end the program.");
Console.ReadLine();