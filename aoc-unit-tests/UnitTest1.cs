using FluentAssertions;

namespace aoc_unit_tests;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        true.Should().Be(false);
    }
}