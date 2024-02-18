namespace LongestIncreasingSubsequence.Core.LongestIncreasingSubsequence;

public class LongestIncreasingSubsequenceInputParser
{
    public IEnumerable<int> TryParseInput(string? input)
    {
        try
        {
            if (string.IsNullOrEmpty(input))
            {
                return Enumerable.Empty<int>();
            }

            var parts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var integers = new List<int>();

            foreach (var part in parts)
            {
                if (int.TryParse(part, out int parsedNumber))
                {
                    integers.Add(parsedNumber);
                }
                else
                {
                    // If any part fails to parse, return an empty sequence.
                    // This is a controlled exit, not due to an exception.
                    return Enumerable.Empty<int>();
                }
            }

            return integers;
        }
        catch
        {
            // In case of any exception, return an empty sequence.
            return Enumerable.Empty<int>();
        }
    }
}
