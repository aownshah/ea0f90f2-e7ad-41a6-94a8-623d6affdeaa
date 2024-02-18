namespace LongestIncreasingSubsequence.Core.LongestIncreasingSubsequence.Interfaces
{
    public interface ILongestIncreasingSubsequenceStrategy
    {
        IEnumerable<int> Calculate(IEnumerable<int> numbers);
    }
}
