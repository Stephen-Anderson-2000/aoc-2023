using FluentAssertions;

namespace aoc_unit_tests.Tests;
public class Day1Tests
{
    [Fact]
    public void Test1()
    {
        var debug = Day1.GetCalibrationFromString("1abc2");

        Day1.GetCalibrationFromString("1abc2").Should().Be(12);
    }

    [Fact]
    public void Test2()
    {
        Day1.GetCalibrationFromString("pqr3stu8vwx").Should().Be(38);
    }

    [Fact]
    public void Test3()
    {
        Day1.GetCalibrationFromString("a1b2c3d4e5f").Should().Be(15);
    }

    [Fact]
    public void Test4()
    {
        Day1.GetCalibrationFromString("treb7uchet").Should().Be(77);
    }
}