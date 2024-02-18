using LongestIncreasingSubsequence.Core.LongestIncreasingSubsequence;

namespace LongestIncreasingSubsequence.Core.Test;

public class LongestIncreasingSubsequenceDynamicProgrammingStrategyTests
{
    private readonly LongestIncreasingSubsequenceDynamicProgrammingStrategy _strategy = new LongestIncreasingSubsequenceDynamicProgrammingStrategy();

    [Theory]
    [InlineData("6 1 5 9 2", "1 5 9")]
    [InlineData("1710 2461 9288 10195 10431 12485", "1710 2461 9288 10195 10431 12485")]
    public void Calculate_ReturnsExpectedSequence(string inputNumbersString, string expectedSequenceString)
    {
        // Arrange
        var inputParser = new LongestIncreasingSubsequenceInputParser();
        var inputNumbers = inputParser.TryParseInput(inputNumbersString).ToArray();
        var expected = inputParser.TryParseInput(expectedSequenceString).ToArray();

        // Act
        var result = _strategy.Calculate(inputNumbers);

        // Assert
        Assert.Equal(expected, result.ToArray());
    }
}
