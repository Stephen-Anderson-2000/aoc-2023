using System.Text.RegularExpressions;

namespace aoc_2023.Days;
public class Day1
{
    public static int GetCalibrationFromString(string calString)
    {
        var matches = Regex.Matches(calString, "[0-9]");
        return matches.Count > 0 ? int.Parse(matches.First().Value + matches.Last().Value) : 0;
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
