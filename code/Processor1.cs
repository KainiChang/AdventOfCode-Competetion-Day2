using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace code;

public class Processor1
{
    public static long Process(string[] input)
    {
        long result = 0;
        // Console.WriteLine(input.Length);

        for (int i = 0; i < input.Length; i++)
        {
            // var numbers = ProcessAString(input[i]);
            var leftNumber = GetFirstNumber(input[i]);
            var rightNumber = GetLastNumber(input[i]);

            var tempNumber = ReturnTheNumber(leftNumber, rightNumber);

            result = result + tempNumber;
        }
        return result;
    }

    public static string GetFirstNumber(string input)
    {
        var numberWords = new Dictionary<string, string>
        {
            { "one", "1" },
            { "two", "2" },
            { "three", "3" },
            { "four", "4" },
            { "five", "5" },
            { "six", "6" },
            { "seven", "7" },
            { "eight", "8" },
            { "nine", "9" }
        };

        string pattern = @"(one|two|three|four|five|six|seven|eight|nine)|\d";

        // Find first match from the left
        Match firstMatch = Regex.Matches(input, pattern).FirstOrDefault();
        // Console.WriteLine(firstMatch);

        string result = "";

        if (firstMatch != null)
        {
            result += numberWords.TryGetValue(firstMatch.Value, out string digit) ? digit : firstMatch.Value;
        }
        // Console.WriteLine(result);
        return result;
    }

    public static string GetLastNumber(string input)
    {
        var numberWords = new Dictionary<string, string>
        {
            { "one", "1" },
            { "two", "2" },
            { "three", "3" },
            { "four", "4" },
            { "five", "5" },
            { "six", "6" },
            { "seven", "7" },
            { "eight", "8" },
            { "nine", "9" }
        };

        string pattern = @"(eno|owt|eerht|ruof|evif|xis|neves|thgie|enin)|\d";

        // Find first match from the right by reversing the string
        string reversedInput = new string(input.Reverse().ToArray());
        Match lastMatchReversed = Regex.Matches(reversedInput, pattern).FirstOrDefault();
        // Console.WriteLine(lastMatchReversed);

        string result = "";

        if (lastMatchReversed != null)
        {
            string reversedMatchValue = new string(lastMatchReversed.Value.Reverse().ToArray());
            result += numberWords.TryGetValue(reversedMatchValue, out string digit) ? digit : reversedMatchValue;
        }
        // Console.WriteLine(result);
        return result;
    }


    public static int ReturnTheNumber(string left, string right)
    {

        // get the first number and the last number, make them a string and parse them to int
        string numberWord = $"{left}{right}";
        int result = int.Parse(numberWord);
        // Console.WriteLine(result);
        return result;
    }

}
