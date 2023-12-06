using System.Text.RegularExpressions;

namespace aoc_2023.Days;
public class Day1
{
    private static readonly Dictionary<string, string> numberDict = new() {
        { "one", "1" },
        { "two", "2" },
        { "three", "3" },
        { "four", "4" },
        { "five", "5" },
        { "six", "6" },
        { "seven", "7" },
        { "eight", "8" },
        { "nine", "9" }
    };

    /// <summary>
    /// This is a stupid solution and I fucking hate RegEx
    /// </summary>
    public static int GetCalibrationFromString(string calString)
    {
        var first = Regex.Matches(calString, "[0-9]|one|two|three|four|five|six|seven|eight|nine");
        var charArray = calString.ToCharArray();
        Array.Reverse(charArray);

        var last = Regex.Matches(new string(charArray), "enin|thgie|neves|xis|evif|ruof|eerht|owt|eno|[0-9]");
        charArray = last[0].Value.ToCharArray();
        Array.Reverse(charArray);

        return int.Parse(ParseNumberWord(first[0].Value) + ParseNumberWord(new string(charArray)));
    }

    private static string ParseNumberWord(string input)
    {
        return !int.TryParse(input, out var _) ? numberDict[input] : input;
    }

    public static int SumCalibrationValues(string[] calStrings)
    {
        var total = 0;
        foreach (var calString in calStrings)
        {
            total += GetCalibrationFromString(calString);
        }

        return total;
    }
}
