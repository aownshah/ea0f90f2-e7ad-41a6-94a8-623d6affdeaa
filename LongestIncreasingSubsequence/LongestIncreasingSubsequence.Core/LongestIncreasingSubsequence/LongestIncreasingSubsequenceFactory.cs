using LongestIncreasingSubsequence.Core.LongestIncreasingSubsequence.Interfaces;

namespace LongestIncreasingSubsequence.Core.LongestIncreasingSubsequence;

public class LongestIncreasingSubsequenceFactory
{
    public ILongestIncreasingSubsequenceStrategy CreteStrategy()
    {
        return new LongestIncreasingSubsequenceDynamicProgrammingStrategy();
    }
}
