// See https://aka.ms/new-console-template for more information

using LongestIncreasingSubsequence.Core.LongestIncreasingSubsequence;

Console.WriteLine("Please int input string of any number of integers separated by single whitespace");
var inputNumbersString = Console.ReadLine();

var inputParser = new LongestIncreasingSubsequenceInputParser();
var inputNumbers = inputParser.TryParseInput(inputNumbersString);

var factory = new LongestIncreasingSubsequenceFactory();
var strategy = factory.CreteStrategy();

var result = strategy.Calculate(inputNumbers.ToArray());

Console.WriteLine("Result:");
Console.WriteLine(string.Join(' ', result));


