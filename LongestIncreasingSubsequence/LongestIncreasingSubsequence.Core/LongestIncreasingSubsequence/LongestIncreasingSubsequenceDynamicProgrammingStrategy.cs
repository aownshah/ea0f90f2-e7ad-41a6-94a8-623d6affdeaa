using LongestIncreasingSubsequence.Core.LongestIncreasingSubsequence.Interfaces;

namespace LongestIncreasingSubsequence.Core.LongestIncreasingSubsequence;

public class LongestIncreasingSubsequenceDynamicProgrammingStrategy : ILongestIncreasingSubsequenceStrategy
{
    public IEnumerable<int> Calculate(int[] numbers)
    {
        int maxLength = 0, startIndex = -1;
        int[] lengths = Enumerable.Repeat(0, numbers.Length).ToArray();
        int[] predecessors = Enumerable.Repeat(-1, numbers.Length).ToArray();

        for (int i = (numbers.Length - 1); i >= 0; i--)
        {
            for (int j = (i + 1); j < numbers.Length; j++)
            {
                if (numbers[i] < numbers[j] && (lengths[j] + 1) > lengths[i])
                {
                    lengths[i] = lengths[j] + 1;
                    predecessors[i] = j;
                }
            }

            if (lengths[i] > maxLength)
            {
                maxLength = lengths[i];
                startIndex = i;
            }
        }


        var result = new List<int>();
        for (int i = startIndex; i != -1; i = predecessors[i])
        {
            result.Add(numbers[i]);
        }

        return result;
    }
}
