// See https://aka.ms/new-console-template for more information

using aoc_2023.Days;

var days = new Dictionary<int, string>
{
    { 1, "Trebuchet?" },
    { 2, "Cube Conundrum" }
};

void PrintAvailable()
{
    foreach (var day in days)
    {
        Console.WriteLine($"\t{day.Key}: {day.Value}");
    }
}

// TODO: Improve later because this will become cumbersome
Console.WriteLine("Hello, which day would you like to run?");
PrintAvailable();
int.TryParse(Console.ReadLine(), out var userChoice);
var lines = File.ReadAllLines($"C:/Users/User/Documents/repos/aoc-2023/input-data/{userChoice}.txt");
Console.WriteLine($"\n\nFile {userChoice}.txt read successfully");

switch (userChoice)
{
    case 1:
        Console.WriteLine($"{Day1.SumCalibrationValues(lines)}");
        break;
    case 2:
        var input = Day2.ReadGameInput(lines);
        Console.WriteLine($"{Day2.SumPossibleGameIDs(input)}");
        break;
    default:
        Console.WriteLine("Day not yet supported");
        break;
}