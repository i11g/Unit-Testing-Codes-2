﻿static bool IsPalindrome(List<string> words)
{
    return words
        .Select(s => s.ToLower())
        .All(word => word.SequenceEqual(word.Reverse()));
}
List<string> words= Console.ReadLine().Split(' ').ToList();
bool result = IsPalindrome(words);
Console.WriteLine(result);

