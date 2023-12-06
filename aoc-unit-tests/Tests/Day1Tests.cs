using FluentAssertions;

namespace aoc_unit_tests.Tests;
public class Day1Tests
{
    [Theory]
    [InlineData("1abc2", 12)]
    [InlineData("pqr3stu8vwx", 38)]
    [InlineData("a1b2c3d4e5f", 15)]
    [InlineData("treb7uchet", 77)]
    [InlineData("two1nine", 29)]
    [InlineData("eightwothree", 83)]
    [InlineData("abcone2threexyz", 13)]
    [InlineData("xtwone3four", 24)]
    [InlineData("4nineeightseven2", 42)]
    [InlineData("zoneight234", 14)]
    [InlineData("7pqrstsixteen", 76)]
    [InlineData("one", 11)]
    [InlineData("twone", 21)]
    public void Test1(string input, int expected)
    {
        Day1.GetCalibrationFromString(input).Should().Be(expected);
    }

    [Fact]
    public void Test2()
    {
        Day1.SumCalibrationValues(["1abc2", "pqr3stu8vwx", "a1b2c3d4e5f", "treb7uchet"]).Should().Be(142);
    }

    [Fact]
    public void Test3()
    {
        Day1.SumCalibrationValues([
            "two1nine",
            "eightwothree",
            "abcone2threexyz",
            "xtwone3four",
            "4nineeightseven2",
            "zoneight234",
            "7pqrstsixteen"])
        .Should().Be(281);
    }
}