﻿/* 
Given a digital LED pattern of a number. You have to find the number and print it. All inputs will be valid as shown.

Input
Input consists of LED patterns. Each pattern is given in set of fixed number of lines. You have to read input till EOF.

Output
Print the number corresponding to each pattern.

Example
Input:
 _  _  _  _  _  _ 
 _| _| _|| ||_||_ 
|_  _||_ |_|  | _|
    _     _     _ 
  ||_ |_||_   || |
  ||_|  ||_|  ||_|
 _  _  _  _     _ 
  ||_||_||_   ||_|
  |  |  | _|  ||_|


Output:
232095
164610
799518
*/
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static readonly Dictionary<string, string> digitPatterns = new Dictionary<string, string>
    {
        {" _ | ||_|", "0"},
        {"     |  |", "1"},
        {" _  _||_ ", "2"},
        {" _  _| _|", "3"},
        {"   |_|  |", "4"},
        {" _ |_  _|", "5"},
        {" _ |_ |_|", "6"},
        {" _   |  |", "7"},
        {" _ |_||_|", "8"},
        {" _ |_|  |", "9"}
    };

    static List<string> ParseLedPatterns(List<string> inputLines)
    {
        var result = new List<string>();

        // Divide input lines into groups of 3
        for (int i = 0; i < inputLines.Count; i += 3)
        {
            var group = inputLines.Skip(i).Take(3).ToList();
            var digits = new string[group[0].Length / 3];

            for (int j = 0; j < group.Count; j++)
            {
                for (int k = 0; k < digits.Length; k++)
                {
                    if (digits[k] == null) digits[k] = "";
                    digits[k] += group[j].Substring(k * 3, 3);
                }
            }

            // Decode digits
            result.Add(string.Join("", digits.Select(d => digitPatterns[d])));
        }

        return result;
    }

    static void Main()
    {
        var inputLines = new List<string>();
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            inputLines.Add(line);
        }
        var numbers = ParseLedPatterns(inputLines);
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
