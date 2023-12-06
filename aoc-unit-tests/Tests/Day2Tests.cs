using FluentAssertions;

namespace aoc_unit_tests.Tests;
public class Day2Tests
{
    [Fact]
    public void Test1()
    {
        var gameInput = Day2.ParseGameFromString("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green");
        Day2.IsGamePossible(12, 13, 14, gameInput.Value).Should().BeTrue();
    }

    [Fact]
    public void Test2()
    {
        var gameInput = Day2.ParseGameFromString("Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue");
        Day2.IsGamePossible(12, 13, 14, gameInput.Value).Should().BeTrue();
    }

    [Fact]
    public void Test3()
    {
        var gameInput = Day2.ParseGameFromString("Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red");
        Day2.IsGamePossible(12, 13, 14, gameInput.Value).Should().BeFalse();
    }

    [Fact]
    public void Test4()
    {
        var gameInput = Day2.ParseGameFromString("Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red");
        Day2.IsGamePossible(12, 13, 14, gameInput.Value).Should().BeFalse();
    }

    [Fact]
    public void Test5()
    {
        var gameInput = Day2.ParseGameFromString("Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green");
        Day2.IsGamePossible(12, 13, 14, gameInput.Value).Should().BeTrue();
    }

    [Fact]
    public void Test6()
    {
        var inputStrings = new string[]
        {
            "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green",
            "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue",
            "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red",
            "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red",
            "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green"
        };
        var gameInput = Day2.ReadGameInput(inputStrings);
        Day2.SumPossibleGameIDs(gameInput).Should().Be(8);
    }
}